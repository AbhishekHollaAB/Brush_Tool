namespace Brush_Tool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_browseFolder = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.pb_imgDisplay = new System.Windows.Forms.PictureBox();
            this.btn_Brush = new System.Windows.Forms.Button();
            this.nud_brushSize = new System.Windows.Forms.NumericUpDown();
            this.btn_saveSingle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_saveFinalText = new System.Windows.Forms.Button();
            this.tb_saveStatus = new System.Windows.Forms.TextBox();
            this.tb_filename = new System.Windows.Forms.TextBox();
            this.tb_outputPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.btn_ReadAnnot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_removePolygon = new System.Windows.Forms.Button();
            this.btn_changeClass = new System.Windows.Forms.Button();
            this.btn_polygonWidth = new System.Windows.Forms.Button();
            this.trBr_Scale = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmb_newClass = new System.Windows.Forms.ComboBox();
            this.btn_AddClass = new System.Windows.Forms.Button();
            this.tb_addNewClass = new System.Windows.Forms.TextBox();
            this.btn_deleteClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBr_Scale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Brush Annotation To YOLO ";
            // 
            // btn_browseFolder
            // 
            this.btn_browseFolder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browseFolder.Location = new System.Drawing.Point(1100, 95);
            this.btn_browseFolder.Name = "btn_browseFolder";
            this.btn_browseFolder.Size = new System.Drawing.Size(120, 75);
            this.btn_browseFolder.TabIndex = 6;
            this.btn_browseFolder.Text = "Browse Folder";
            this.btn_browseFolder.UseVisualStyleBackColor = true;
            this.btn_browseFolder.Click += new System.EventHandler(this.btn_browseFolder_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Enabled = false;
            this.btn_previous.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.Location = new System.Drawing.Point(1067, 95);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(33, 75);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "<";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(1220, 95);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(36, 75);
            this.btn_next.TabIndex = 12;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // pb_imgDisplay
            // 
            this.pb_imgDisplay.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pb_imgDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_imgDisplay.Location = new System.Drawing.Point(12, 91);
            this.pb_imgDisplay.Name = "pb_imgDisplay";
            this.pb_imgDisplay.Size = new System.Drawing.Size(1020, 820);
            this.pb_imgDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imgDisplay.TabIndex = 13;
            this.pb_imgDisplay.TabStop = false;
            this.pb_imgDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseDown);
            this.pb_imgDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseMove);
            this.pb_imgDisplay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_imgDisplay_MouseUp);
            // 
            // btn_Brush
            // 
            this.btn_Brush.BackColor = System.Drawing.Color.Green;
            this.btn_Brush.Enabled = false;
            this.btn_Brush.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Brush.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Brush.Location = new System.Drawing.Point(1074, 431);
            this.btn_Brush.Name = "btn_Brush";
            this.btn_Brush.Size = new System.Drawing.Size(114, 78);
            this.btn_Brush.TabIndex = 14;
            this.btn_Brush.Text = "Brush";
            this.btn_Brush.UseVisualStyleBackColor = false;
            this.btn_Brush.Click += new System.EventHandler(this.btn_Brush_Click);
            // 
            // nud_brushSize
            // 
            this.nud_brushSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_brushSize.Location = new System.Drawing.Point(1190, 459);
            this.nud_brushSize.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nud_brushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_brushSize.Name = "nud_brushSize";
            this.nud_brushSize.Size = new System.Drawing.Size(81, 26);
            this.nud_brushSize.TabIndex = 15;
            this.nud_brushSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_brushSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_brushSize.ValueChanged += new System.EventHandler(this.nud_brushSize_ValueChanged);
            // 
            // btn_saveSingle
            // 
            this.btn_saveSingle.Enabled = false;
            this.btn_saveSingle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveSingle.Location = new System.Drawing.Point(1074, 515);
            this.btn_saveSingle.Name = "btn_saveSingle";
            this.btn_saveSingle.Size = new System.Drawing.Size(98, 78);
            this.btn_saveSingle.TabIndex = 16;
            this.btn_saveSingle.Text = "Save Single";
            this.btn_saveSingle.UseVisualStyleBackColor = true;
            this.btn_saveSingle.Click += new System.EventHandler(this.btn_saveSingle_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(809, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 25);
            this.panel1.TabIndex = 17;
            // 
            // btn_saveFinalText
            // 
            this.btn_saveFinalText.Enabled = false;
            this.btn_saveFinalText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveFinalText.Location = new System.Drawing.Point(1176, 515);
            this.btn_saveFinalText.Name = "btn_saveFinalText";
            this.btn_saveFinalText.Size = new System.Drawing.Size(96, 78);
            this.btn_saveFinalText.TabIndex = 18;
            this.btn_saveFinalText.Text = "Save Final Text";
            this.btn_saveFinalText.UseVisualStyleBackColor = true;
            this.btn_saveFinalText.Click += new System.EventHandler(this.btn_saveFinalText_Click);
            // 
            // tb_saveStatus
            // 
            this.tb_saveStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_saveStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_saveStatus.Location = new System.Drawing.Point(1077, 599);
            this.tb_saveStatus.Name = "tb_saveStatus";
            this.tb_saveStatus.ReadOnly = true;
            this.tb_saveStatus.Size = new System.Drawing.Size(195, 32);
            this.tb_saveStatus.TabIndex = 19;
            this.tb_saveStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_filename
            // 
            this.tb_filename.BackColor = System.Drawing.Color.Yellow;
            this.tb_filename.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filename.Location = new System.Drawing.Point(42, 52);
            this.tb_filename.Name = "tb_filename";
            this.tb_filename.ReadOnly = true;
            this.tb_filename.Size = new System.Drawing.Size(216, 26);
            this.tb_filename.TabIndex = 20;
            this.tb_filename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_outputPath
            // 
            this.tb_outputPath.BackColor = System.Drawing.Color.Yellow;
            this.tb_outputPath.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_outputPath.Location = new System.Drawing.Point(1079, 176);
            this.tb_outputPath.Name = "tb_outputPath";
            this.tb_outputPath.ReadOnly = true;
            this.tb_outputPath.Size = new System.Drawing.Size(177, 22);
            this.tb_outputPath.TabIndex = 23;
            this.tb_outputPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_outputPath.TextChanged += new System.EventHandler(this.tb_outputPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1066, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1243, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "d";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1113, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 15);
            this.label9.TabIndex = 32;
            this.label9.Text = "b";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1251, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "s";
            // 
            // tb_Status
            // 
            this.tb_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Status.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Status.Location = new System.Drawing.Point(839, 3);
            this.tb_Status.Multiline = true;
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(411, 73);
            this.tb_Status.TabIndex = 39;
            this.tb_Status.Text = "STATUS";
            this.tb_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ReadAnnot
            // 
            this.btn_ReadAnnot.BackColor = System.Drawing.Color.IndianRed;
            this.btn_ReadAnnot.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadAnnot.Location = new System.Drawing.Point(1100, 204);
            this.btn_ReadAnnot.Name = "btn_ReadAnnot";
            this.btn_ReadAnnot.Size = new System.Drawing.Size(120, 47);
            this.btn_ReadAnnot.TabIndex = 40;
            this.btn_ReadAnnot.Text = "Polygon Off";
            this.btn_ReadAnnot.UseVisualStyleBackColor = false;
            this.btn_ReadAnnot.Click += new System.EventHandler(this.btn_ReadAnnot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1155, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "o";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1207, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "t";
            // 
            // timer1
            // 
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_removePolygon
            // 
            this.btn_removePolygon.Enabled = false;
            this.btn_removePolygon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removePolygon.Location = new System.Drawing.Point(1077, 695);
            this.btn_removePolygon.Name = "btn_removePolygon";
            this.btn_removePolygon.Size = new System.Drawing.Size(195, 52);
            this.btn_removePolygon.TabIndex = 43;
            this.btn_removePolygon.Text = "Remove Polygon";
            this.btn_removePolygon.UseVisualStyleBackColor = true;
            this.btn_removePolygon.Click += new System.EventHandler(this.btn_selectPolygon_Click);
            // 
            // btn_changeClass
            // 
            this.btn_changeClass.Enabled = false;
            this.btn_changeClass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changeClass.Location = new System.Drawing.Point(1077, 637);
            this.btn_changeClass.Name = "btn_changeClass";
            this.btn_changeClass.Size = new System.Drawing.Size(195, 52);
            this.btn_changeClass.TabIndex = 44;
            this.btn_changeClass.Text = "Change Class";
            this.btn_changeClass.UseVisualStyleBackColor = true;
            this.btn_changeClass.Click += new System.EventHandler(this.btn_changeClass_Click);
            // 
            // btn_polygonWidth
            // 
            this.btn_polygonWidth.Enabled = false;
            this.btn_polygonWidth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_polygonWidth.Location = new System.Drawing.Point(1077, 775);
            this.btn_polygonWidth.Name = "btn_polygonWidth";
            this.btn_polygonWidth.Size = new System.Drawing.Size(195, 52);
            this.btn_polygonWidth.TabIndex = 45;
            this.btn_polygonWidth.Text = "Change Polygon Width";
            this.btn_polygonWidth.UseVisualStyleBackColor = true;
            this.btn_polygonWidth.Click += new System.EventHandler(this.btn_polygonWidth_Click);
            // 
            // trBr_Scale
            // 
            this.trBr_Scale.Location = new System.Drawing.Point(1074, 833);
            this.trBr_Scale.Maximum = 7;
            this.trBr_Scale.Minimum = -1;
            this.trBr_Scale.Name = "trBr_Scale";
            this.trBr_Scale.Size = new System.Drawing.Size(197, 45);
            this.trBr_Scale.TabIndex = 48;
            this.trBr_Scale.Scroll += new System.EventHandler(this.trBr_Scale_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1077, 863);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 15);
            this.label10.TabIndex = 49;
            this.label10.Text = "-1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1251, 863);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1101, 863);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 15);
            this.label13.TabIndex = 51;
            this.label13.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1229, 863);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 15);
            this.label14.TabIndex = 52;
            this.label14.Text = "6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1208, 863);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 53;
            this.label15.Text = "5";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1186, 863);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 15);
            this.label16.TabIndex = 54;
            this.label16.Text = "4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1165, 863);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 15);
            this.label17.TabIndex = 55;
            this.label17.Text = "3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1144, 863);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 15);
            this.label18.TabIndex = 56;
            this.label18.Text = "2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1124, 863);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 15);
            this.label19.TabIndex = 57;
            this.label19.Text = "1";
            // 
            // cmb_newClass
            // 
            this.cmb_newClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_newClass.FormattingEnabled = true;
            this.cmb_newClass.Location = new System.Drawing.Point(1045, 316);
            this.cmb_newClass.Name = "cmb_newClass";
            this.cmb_newClass.Size = new System.Drawing.Size(154, 27);
            this.cmb_newClass.TabIndex = 58;
            this.cmb_newClass.SelectedIndexChanged += new System.EventHandler(this.cmb_newClass_SelectedIndexChanged);
            // 
            // btn_AddClass
            // 
            this.btn_AddClass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddClass.Location = new System.Drawing.Point(1193, 360);
            this.btn_AddClass.Name = "btn_AddClass";
            this.btn_AddClass.Size = new System.Drawing.Size(102, 52);
            this.btn_AddClass.TabIndex = 59;
            this.btn_AddClass.Text = "Add Class";
            this.btn_AddClass.UseVisualStyleBackColor = true;
            this.btn_AddClass.Click += new System.EventHandler(this.btn_AddClass_Click);
            // 
            // tb_addNewClass
            // 
            this.tb_addNewClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_addNewClass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addNewClass.Location = new System.Drawing.Point(1060, 373);
            this.tb_addNewClass.Name = "tb_addNewClass";
            this.tb_addNewClass.Size = new System.Drawing.Size(120, 29);
            this.tb_addNewClass.TabIndex = 60;
            // 
            // btn_deleteClass
            // 
            this.btn_deleteClass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteClass.Location = new System.Drawing.Point(1205, 302);
            this.btn_deleteClass.Name = "btn_deleteClass";
            this.btn_deleteClass.Size = new System.Drawing.Size(102, 52);
            this.btn_deleteClass.TabIndex = 61;
            this.btn_deleteClass.Text = "Delete Class";
            this.btn_deleteClass.UseVisualStyleBackColor = true;
            this.btn_deleteClass.Click += new System.EventHandler(this.btn_deleteClass_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 923);
            this.Controls.Add(this.btn_deleteClass);
            this.Controls.Add(this.tb_addNewClass);
            this.Controls.Add(this.btn_AddClass);
            this.Controls.Add(this.cmb_newClass);
            this.Controls.Add(this.pb_imgDisplay);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trBr_Scale);
            this.Controls.Add(this.btn_polygonWidth);
            this.Controls.Add(this.btn_changeClass);
            this.Controls.Add(this.btn_removePolygon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ReadAnnot);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_outputPath);
            this.Controls.Add(this.tb_filename);
            this.Controls.Add(this.tb_saveStatus);
            this.Controls.Add(this.btn_saveFinalText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_saveSingle);
            this.Controls.Add(this.nud_brushSize);
            this.Controls.Add(this.btn_Brush);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_browseFolder);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brush to YOLO Converter - v4.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imgDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trBr_Scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_browseFolder;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.PictureBox pb_imgDisplay;
        private System.Windows.Forms.Button btn_Brush;
        private System.Windows.Forms.NumericUpDown nud_brushSize;
        private System.Windows.Forms.Button btn_saveSingle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveFinalText;
        private System.Windows.Forms.TextBox tb_saveStatus;
        private System.Windows.Forms.TextBox tb_filename;
        private System.Windows.Forms.TextBox tb_outputPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.Button btn_ReadAnnot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_removePolygon;
        private System.Windows.Forms.Button btn_changeClass;
        private System.Windows.Forms.Button btn_polygonWidth;
        private System.Windows.Forms.TrackBar trBr_Scale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmb_newClass;
        private System.Windows.Forms.Button btn_AddClass;
        private System.Windows.Forms.TextBox tb_addNewClass;
        private System.Windows.Forms.Button btn_deleteClass;
    }
}

