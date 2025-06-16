using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.XImgProc;

namespace Brush_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            drawingPen = new Pen(Color.Green, (int)nud_brushSize.Value);
            drawingPen.StartCap = drawingPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        Mat imgMain = new Mat();
        Mat imgMainCopy = new Mat();
        Mat blackImg = new Mat();
        Mat binaryMask = new Mat();
        Mat thinningControl = new Mat();
        Mat thinningControlCopy = new Mat();

        int idx = 0;
        int actualX = 0;
        int actualY = 0;
        int polygonX = 0;
        int polygonY = 0;
        int classIndex = 0;

        List<string> yoloText = new List<string>();
        string[] folderContents;
        string fileName = "";
        string outFilename;

        bool draw = true;
        bool IsMouseDown = false;
        bool forPolygon = false;
        bool forClassChange = false;
        bool forPolygonWidth = false;
        bool resetScale = true;

        OpenCvSharp.Point StartLocation;
        OpenCvSharp.Point polygonPoint;
        List<OpenCvSharp.Point[]> lastSetPoints = new List<OpenCvSharp.Point[]>();
        List<string> classLabels = new List<string>();

        Pen drawingPen;
        Graphics pictureBoxGraphics;

        List<Scalar> classColors = new List<Scalar> {
        Scalar.Green, Scalar.Blue, Scalar.Orange, Scalar.Purple, Scalar.Pink, Scalar.Yellow, Scalar.Red, Scalar.Brown, Scalar.BlanchedAlmond, Scalar.Beige,
        Scalar.Cyan, Scalar.Magenta, Scalar.Lime, Scalar.Maroon, Scalar.SpringGreen, Scalar.Teal, Scalar.Aquamarine, Scalar.Azure, Scalar.DarkRed, Scalar.DarkOrange
        };
       

        private void btn_browseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] pngFiles = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*.png");
                string[] jpgFiles = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*.jpg");
                folderContents = pngFiles.Concat(jpgFiles).ToArray();
                //folderContents = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*.png");
                tb_outputPath.Text = folderBrowserDialog1.SelectedPath;
                fileName = Path.GetFileName(folderContents[idx]);
                outFilename = fileName.Remove(fileName.Length - 4);

                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    tb_Status.Text = "PROCESSED";
                    tb_Status.BackColor = Color.Green;
                    tb_Status.ForeColor = Color.White;
                }
                else
                {
                    tb_Status.Text = "UNPROCESSED";
                    tb_Status.BackColor = Color.Red;
                    tb_Status.ForeColor = Color.White;
                }

                tb_filename.Text = fileName;
                imgMain = new Mat(folderContents[idx]);
                imgMain.CopyTo(imgMainCopy);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                binaryMask = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                //pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (idx > 0)
            {
                btn_saveFinalText.PerformClick();
                idx--;
                fileName = Path.GetFileName(folderContents[idx]);
                tb_filename.Text = fileName;
                outFilename = fileName.Remove(fileName.Length - 4);

                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    tb_Status.Text = "PROCESSED";
                    tb_Status.BackColor = Color.Green;
                    tb_Status.ForeColor = Color.White;
                }
                else
                {
                    tb_Status.Text = "UNPROCESSED";
                    tb_Status.BackColor = Color.Red;
                    tb_Status.ForeColor = Color.White;
                }

                btn_ReadAnnot.Text = "Polygon Off";
                btn_ReadAnnot.BackColor = Color.Red;
                tb_saveStatus.Clear();
                tb_saveStatus.BackColor = Color.White;
                
                imgMain = new Mat(folderContents[idx]);
                imgMain.CopyTo(imgMainCopy);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                binaryMask = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                //pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (idx < folderContents.Length - 1)
            {
                btn_saveFinalText.PerformClick();
                idx++;
                fileName = Path.GetFileName(folderContents[idx]);
                tb_filename.Text = fileName;
                outFilename = fileName.Remove(fileName.Length - 4);

                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    tb_Status.Text = "PROCESSED";
                    tb_Status.BackColor = Color.Green;
                    tb_Status.ForeColor = Color.White;
                }
                else
                {
                    tb_Status.Text = "UNPROCESSED";
                    tb_Status.BackColor = Color.Red;
                    tb_Status.ForeColor = Color.White;
                }

                btn_ReadAnnot.Text = "Polygon Off";
                btn_ReadAnnot.BackColor = Color.Red;
                tb_saveStatus.Clear();
                tb_saveStatus.BackColor = Color.White;
                //btn_ReadAnnot.PerformClick();
                
                imgMain = new Mat(folderContents[idx]);
                imgMain.CopyTo(imgMainCopy);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                binaryMask = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                pb_imgDisplay.Image = imgMain.ToBitmap();
                //pb_imgDisplay.SizeMode = PictureBoxSizeMode.AutoSize;
                pb_imgDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pb_imgDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (IsMouseDown == false)
                    IsMouseDown = true;
                StartLocation = new OpenCvSharp.Point(e.X, e.Y);
            }
            if (forPolygon)
            {
                polygonPoint = new OpenCvSharp.Point(e.X, e.Y);
                double scaleX = (double)imgMain.Width / pb_imgDisplay.Size.Width;
                double scaleY = (double)imgMain.Height / pb_imgDisplay.Size.Height;
                polygonX = (int)(e.X * scaleX);
                polygonY = (int)(e.Y * scaleY);

                List<string> linesToKeep = new List<string>();
                string[] lines = File.ReadAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt");
                foreach (string line in lines)
                {
                    string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int classID = int.Parse(values[0]);
                    values = values.Skip(1).ToArray();
                    List<OpenCvSharp.Point> allPointsIn = new List<OpenCvSharp.Point>();

                    for (int i = 0; i < values.Length; i += 2)
                    {
                        int xVal = (int)(Convert.ToDouble(values[i]) * imgMain.Width);
                        int yVal = (int)(Convert.ToDouble(values[i + 1]) * imgMain.Height);
                        allPointsIn.Add(new OpenCvSharp.Point(xVal, yVal));
                    }

                    OpenCvSharp.Point testPoint = new OpenCvSharp.Point(polygonX, polygonY);
                    bool isInside = PolygonHelper.IsPointInside(testPoint, allPointsIn);
                    if (!isInside)
                    {
                        linesToKeep.Add(line);
                    }
                }
                File.WriteAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt", linesToKeep);
                btn_ReadAnnot.PerformClick();
                btn_ReadAnnot.PerformClick();
            }
            if (forClassChange)
            {
                polygonPoint = new OpenCvSharp.Point(e.X, e.Y);
                double scaleX = (double)imgMain.Width / pb_imgDisplay.Size.Width;
                double scaleY = (double)imgMain.Height / pb_imgDisplay.Size.Height;
                polygonX = (int)(e.X * scaleX);
                polygonY = (int)(e.Y * scaleY);

                List<string> modifiedLines = new List<string>();
                string[] lines = File.ReadAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt");
                foreach (string line in lines)
                {
                    string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int classID = int.Parse(values[0]);
                    values = values.Skip(1).ToArray();
                    List<OpenCvSharp.Point> allPointsIn = new List<OpenCvSharp.Point>();

                    for (int i = 0; i < values.Length; i += 2)
                    {
                        int xVal = (int)(Convert.ToDouble(values[i]) * imgMain.Width);
                        int yVal = (int)(Convert.ToDouble(values[i + 1]) * imgMain.Height);
                        allPointsIn.Add(new OpenCvSharp.Point(xVal, yVal));
                    }

                    OpenCvSharp.Point testPoint = new OpenCvSharp.Point(polygonX, polygonY);
                    bool isInside = PolygonHelper.IsPointInside(testPoint, allPointsIn);
                    if (isInside)
                    {
                        classID = classIndex;
                        string modifiedLine = classID.ToString() + " " + string.Join(" ", values);
                    }
                    else
                    {
                        modifiedLines.Add(line);
                    }
                }
                File.WriteAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt", modifiedLines);
                btn_ReadAnnot.PerformClick();
                btn_ReadAnnot.PerformClick();
            }
            if (forPolygonWidth)
            {
                polygonPoint = new OpenCvSharp.Point(e.X, e.Y);
                if (forPolygonWidth)
                {
                    double scaleX = (double)imgMain.Width / pb_imgDisplay.Size.Width;
                    double scaleY = (double)imgMain.Height / pb_imgDisplay.Size.Height;
                    polygonX = (int)(polygonPoint.X * scaleX);
                    polygonY = (int)(polygonPoint.Y * scaleY);

                    string[] lines = File.ReadAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt");
                    List<string> modifiedLines = new List<string>();

                    foreach (string line in lines)
                    {
                        string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int classID = int.Parse(values[0]);
                        values = values.Skip(1).ToArray();

                        List<OpenCvSharp.Point> polygonPoints = new List<OpenCvSharp.Point>();
                        foreach (var i in Enumerable.Range(0, values.Length / 2))
                        {
                            int xVal = (int)(Convert.ToDouble(values[i * 2]) * imgMain.Width);
                            int yVal = (int)(Convert.ToDouble(values[i * 2 + 1]) * imgMain.Height);
                            polygonPoints.Add(new OpenCvSharp.Point(xVal, yVal));
                        }

                        OpenCvSharp.Point testPoint = new OpenCvSharp.Point(polygonX, polygonY);
                        bool isInside = PolygonHelper.IsPointInside(testPoint, polygonPoints);

                        if (isInside)
                        {
                            thinningControl = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                            List<OpenCvSharp.Point[]> polygons = new List<OpenCvSharp.Point[]>() { polygonPoints.ToArray() };
                            Cv2.FillPoly(thinningControl, polygons, Scalar.White);
                            //CvXImgProc.Thinning(thinningControl, thinningControl, ThinningTypes.GUOHALL);
                        }
                        else
                        {
                            modifiedLines.Add(line);
                        }
                    }

                    //File.WriteAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt", modifiedLines);
                    //btn_ReadAnnot.PerformClick();
                    //btn_ReadAnnot.PerformClick();
                }
            }
        }

        private void pb_imgDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (draw && IsMouseDown)
                {
                    OpenCvSharp.Point currentPoint = new OpenCvSharp.Point(e.X, e.Y);

                    pictureBoxGraphics.DrawLine(drawingPen, StartLocation.X, StartLocation.Y, currentPoint.X, currentPoint.Y);
                    StartLocation = currentPoint;
                    double scaleX = (double)imgMain.Width / pb_imgDisplay.Size.Width;
                    double scaleY = (double)imgMain.Height / pb_imgDisplay.Size.Height;
                    actualX = (int)(e.X * scaleX);
                    actualY = (int)(e.Y * scaleY);

                    Cv2.Circle(imgMain, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, classColors[classIndex], -1);

                    Cv2.Circle(blackImg, new OpenCvSharp.Point(actualX, actualY), (int)nud_brushSize.Value, Scalar.White, -1);
                    pb_imgDisplay.Image = imgMain.ToBitmap();
                    pb_imgDisplay.Invalidate();
                    GC.Collect();
                }
            }
            catch (Exception exc)
            {
                btn_saveFinalText.PerformClick();
                pb_imgDisplay.Image = imgMain.ToBitmap();
                Console.WriteLine(exc.Message);
                //MessageBox.Show(exc.Message);
            }
        }

        private void pb_imgDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw && IsMouseDown)
            {
                //pb_imgDisplay.Image = imgMain.ToBitmap();
                IsMouseDown = false;
                btn_saveSingle.Enabled = true;
                btn_saveSingle.PerformClick();
            }
        }

        private void btn_Brush_Click(object sender, EventArgs e)
        {
            if (draw == false)
            {
                draw = true;
                btn_Brush.BackColor = Color.Green;
                forPolygon = false;
                forClassChange = false;
                forPolygonWidth = false;
                Cursor = Cursors.Default;
            }
            else
            {
                draw = false;
                btn_Brush.BackColor = Color.Red;
            }
        }

        private void nud_brushSize_ValueChanged(object sender, EventArgs e)
        {
            drawingPen.Width = (int)nud_brushSize.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            pictureBoxGraphics = pb_imgDisplay.CreateGraphics();
            timer1.Start();
            loadClasses();
        }

   


        private void btn_saveSingle_Click(object sender, EventArgs e)
        {
            try
            {
                string yoloTxtToWrite = "";

                yoloTxtToWrite = classIndex.ToString();
                Mat blackImgCopy = new Mat();
                blackImg.CopyTo(blackImgCopy);

                OpenCvSharp.Point[][] points;
                HierarchyIndex[] indices;
                Cv2.FindContours(blackImgCopy, out points, out indices, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
                OpenCvSharp.Point[] finalPoints = points[0];
                lastSetPoints.Add(finalPoints);
                foreach (var finalPoint in finalPoints)
                {
                    int pixelX = finalPoint.X;
                    int pixelY = finalPoint.Y;
                    double finalX = (double)pixelX / imgMain.Width;
                    double finalY = (double)pixelY / imgMain.Height;

                    yoloTxtToWrite = yoloTxtToWrite + " " + finalX.ToString() + " " + finalY.ToString();
                }
                yoloText.Add(yoloTxtToWrite);
                blackImg = new Mat(imgMain.Rows, imgMain.Cols, MatType.CV_8UC1, Scalar.Black);
                btn_saveSingle.Enabled = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_saveFinalText_Click(object sender, EventArgs e)
        {
            try
            {
                if (yoloText.Count > 0)
                {
                    tb_saveStatus.BackColor = Color.OrangeRed;
                    tb_saveStatus.ForeColor = Color.White;
                    tb_saveStatus.Text = "Saving...";


                    if (!File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                        {
                            foreach (string line in yoloText)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt", true))
                        {
                            foreach (string line in yoloText)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                    yoloText = new List<string>();
                    lastSetPoints = new List<OpenCvSharp.Point[]>();
                    tb_saveStatus.BackColor = Color.Green;
                    tb_saveStatus.ForeColor = Color.White;
                    tb_saveStatus.Text = "Saved!";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Focus();
            switch (e.KeyChar)
            {
                case 'a':
                    btn_previous.PerformClick();
                    break;
                case 'd':
                    btn_next.PerformClick();
                    break;
                case 'b':
                    btn_Brush.PerformClick();
                    break;
                case 'o':
                    btn_browseFolder.PerformClick();
                    break;
                case 's':
                    btn_saveFinalText.PerformClick();
                    break;
                case 't':
                    btn_ReadAnnot.PerformClick();
                    break;
            }
        }

        private void tb_outputPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_outputPath.Text.Length > 5)
                {
                    btn_previous.Enabled = true;
                    btn_next.Enabled = true;
                    btn_browseFolder.Enabled = true;
                    btn_Brush.Enabled = true;
                    btn_saveFinalText.Enabled = true;
                    btn_removePolygon.Enabled = true;
                    btn_changeClass.Enabled = true;
                    btn_polygonWidth.Enabled = true;
                }
                else
                {
                    btn_previous.Enabled = false;
                    btn_next.Enabled = false;
                    btn_browseFolder.Enabled = false;
                    btn_Brush.Enabled = false;
                    btn_saveFinalText.Enabled = false;
                    btn_removePolygon.Enabled = false;
                    btn_changeClass.Enabled = false;
                    btn_polygonWidth.Enabled = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btn_ReadAnnot_Click(object sender, EventArgs e)
        {
            if (btn_ReadAnnot.Text == "Polygon Off")
            {
                if (File.Exists(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt"))
                {
                    btn_ReadAnnot.Text = "Polygon On";
                    btn_ReadAnnot.BackColor = Color.Green;
                    string[] lines = File.ReadAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt");
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        int classID = int.Parse(values[0]);
                        values = values.Skip(1).ToArray();
                        List<OpenCvSharp.Point> pointsList = new List<OpenCvSharp.Point>();
                        List<List<OpenCvSharp.Point>> ListOfListOfPoint = new List<List<OpenCvSharp.Point>>();

                        for (int i = 0; i < values.Length; i += 2)
                        {
                            int xVal = (int)(Convert.ToDouble(values[i]) * imgMain.Width);
                            int yVal = (int)(Convert.ToDouble(values[i + 1]) * imgMain.Height);
                            pointsList.Add(new OpenCvSharp.Point(xVal, yVal));
                        }

                        OpenCvSharp.Point[] pointsArray = pointsList.ToArray();
                        ListOfListOfPoint.Add(pointsList);
                        
                        Cv2.Polylines(imgMain, ListOfListOfPoint, true, classColors[classID], 1);
                    }
                    pb_imgDisplay.Image = imgMain.ToBitmap();
                }                
            }
            else if (btn_ReadAnnot.Text == "Polygon On")
            {
                imgMainCopy.CopyTo(imgMain);
                btn_ReadAnnot.Text = "Polygon Off";
                btn_ReadAnnot.BackColor = Color.Red;
                pb_imgDisplay.Image = imgMainCopy.ToBitmap();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btn_saveFinalText.PerformClick();
        }

        private void btn_selectPolygon_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.No;
            if (btn_Brush.BackColor == Color.Green)
                btn_Brush.PerformClick();
            forPolygon = true;
            forClassChange = false;
            forPolygonWidth = false;
        }

        private void btn_changeClass_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            forClassChange = true;
            forPolygon = false;
            forPolygonWidth = false;
            if (btn_Brush.BackColor == Color.Green)
            {
                btn_Brush.PerformClick();
            }
        }

        private void btn_polygonWidth_Click(object sender, EventArgs e)
        {
            forClassChange = false;
            forPolygon = false;
            forPolygonWidth = true;
            trBr_Scale.Value = 0;
            resetScale = false;
            if (btn_Brush.BackColor == Color.Green)
            {
                btn_Brush.PerformClick();
            }
        }

        private void setScale()
        {
            OpenCvSharp.Point[][] points;
            HierarchyIndex[] indices;
            Cv2.FindContours(thinningControlCopy, out points, out indices, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            OpenCvSharp.Point[] finalPoints = points[0];

            string[] lines = File.ReadAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt");
            List<string> modifiedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] values = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int classID = int.Parse(values[0]);
                values = values.Skip(1).ToArray();

                List<OpenCvSharp.Point> polygonPoints = new List<OpenCvSharp.Point>();
                foreach (var i in Enumerable.Range(0, values.Length / 2))
                {
                    int xVal = (int)(Convert.ToDouble(values[i * 2]) * imgMain.Width);
                    int yVal = (int)(Convert.ToDouble(values[i * 2 + 1]) * imgMain.Height);
                    polygonPoints.Add(new OpenCvSharp.Point(xVal, yVal));
                }

                OpenCvSharp.Point testPoint = new OpenCvSharp.Point(polygonX, polygonY);
                bool isInside = PolygonHelper.IsPointInside(testPoint, polygonPoints);

                if (isInside)
                {
                    string modifiedLine = classID.ToString();
                    foreach (var finalPoint in finalPoints)
                    {
                        int pixelX = finalPoint.X;
                        int pixelY = finalPoint.Y;
                        double finalX = (double)pixelX / imgMain.Width;
                        double finalY = (double)pixelY / imgMain.Height;

                        modifiedLine = modifiedLine + " " + finalX.ToString() + " " + finalY.ToString();
                    }
                    modifiedLines.Add(modifiedLine);
                }
                else
                {
                    modifiedLines.Add(line);
                }
            }
            File.WriteAllLines(folderBrowserDialog1.SelectedPath + "\\" + outFilename + ".txt", modifiedLines);
            btn_ReadAnnot.PerformClick();
            btn_ReadAnnot.PerformClick();
        }

        private void trBr_Scale_Scroll(object sender, EventArgs e)
        {
            if (resetScale == false)
            {
                thinningControl.CopyTo(thinningControlCopy);
                int nudValue = (int)trBr_Scale.Value;
                Mat element = Cv2.GetStructuringElement(MorphShapes.Rect, new OpenCvSharp.Size(3, 3));
                if (nudValue > 0)
                {
                    Cv2.Dilate(thinningControl, thinningControlCopy, element, iterations: nudValue);
                }
                else if (nudValue < 0)
                {
                    Cv2.Erode(thinningControl, thinningControlCopy, element, iterations: Math.Abs(nudValue));
                }
                setScale();
            }
        }

        private void saveClasses()
        {
            List<string> items = cmb_newClass.Items.Cast<string>().ToList();
            File.WriteAllLines("classes.txt", items);
        }

        private void loadClasses()
        {
            if (File.Exists("classes.txt"))
            {
                var lines = File.ReadAllLines("classes.txt");
                cmb_newClass.Items.AddRange(lines);
            }
        }

        private void btn_AddClass_Click(object sender, EventArgs e)
        {
            string newClass = tb_addNewClass.Text;
            if (!cmb_newClass.Items.Contains(newClass))
            {
                cmb_newClass.Items.Add(newClass);
                saveClasses();
                tb_addNewClass.Clear();
            }
        }

        private void btn_deleteClass_Click(object sender, EventArgs e)
        {
            if (cmb_newClass.SelectedItem != null)
            {
                cmb_newClass.Items.Remove(cmb_newClass.SelectedItem);
                saveClasses();
            }
        }

        public static Color scalarToColor(Scalar scalar)
        {
            return Color.FromArgb(
                255,
                (int)scalar.Val2,
                (int)scalar.Val1,
                (int)scalar.Val0
                );
        }

        private void cmb_newClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            classIndex = cmb_newClass.SelectedIndex;
            drawingPen = new Pen(scalarToColor(classColors[classIndex]), (int)nud_brushSize.Value);
        }
    }

    public class PolygonHelper
    {
        public static bool IsPointInside(OpenCvSharp.Point p, List<OpenCvSharp.Point> vertices)
        {
            int count = 0;
            int n = vertices.Count;

            for (int i = 0; i < n; i++)
            {
                OpenCvSharp.Point v1 = vertices[i];
                OpenCvSharp.Point v2 = vertices[(i + 1) % n];

                if (IsIntersecting(p, v1, v2))
                {
                    count++;
                }
            }

            return (count % 2 == 1);
        }

        private static bool IsIntersecting(OpenCvSharp.Point p, OpenCvSharp.Point v1, OpenCvSharp.Point v2)
        {
            if (v1.Y > v2.Y)
            {
                OpenCvSharp.Point temp = v1;
                v1 = v2;
                v2 = temp;
            }

            if (p.Y == v1.Y || p.Y == v2.Y)
            {
                p.Y += 1;
            }

            if (p.Y < v1.Y || p.Y > v2.Y)
            {
                return false;
            }

            if (p.X >= Math.Max(v1.X, v2.X))
            {
                return false;
            }

            if (p.X < Math.Min(v1.X, v2.X))
            {
                return true;
            }

            double slope = (double)(v2.Y - v1.Y) / (v2.X - v1.X);
            double intersectionX = v1.X + (p.Y - v1.Y) / slope;

            return p.X < intersectionX;
        }
    }
}
