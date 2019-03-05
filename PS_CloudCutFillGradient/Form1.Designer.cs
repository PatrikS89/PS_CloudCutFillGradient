namespace PS_CloudCutFillGradient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.btnBrowseInputPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbExportRGBType = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbExportSeparator = new System.Windows.Forms.ComboBox();
            this.cbExportMode = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbImportRGBType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbImportMode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbRowsToSkip = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbImportSeparator = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCylinderRadius = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbIgnorePointsAboveBelow = new System.Windows.Forms.CheckBox();
            this.txtCylinderHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCylinderZ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCylinderY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCylinderX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelColorMidDistance = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIntensityMax = new System.Windows.Forms.ComboBox();
            this.cbIntensityMin = new System.Windows.Forms.ComboBox();
            this.panelColorOutsideDistance = new System.Windows.Forms.Panel();
            this.panelColorMaxDistance = new System.Windows.Forms.Panel();
            this.panelColorMinDistance = new System.Windows.Forms.Panel();
            this.lblColorOutsideDistance = new System.Windows.Forms.Label();
            this.lblColorMaxDistance = new System.Windows.Forms.Label();
            this.lblColorMinDistance = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbColorType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbColorMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOutsidePointsMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbColorByMode = new System.Windows.Forms.ComboBox();
            this.txtMaxDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fil:";
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(40, 13);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(336, 20);
            this.txtInputPath.TabIndex = 1;
            // 
            // btnBrowseInputPath
            // 
            this.btnBrowseInputPath.Location = new System.Drawing.Point(382, 12);
            this.btnBrowseInputPath.Name = "btnBrowseInputPath";
            this.btnBrowseInputPath.Size = new System.Drawing.Size(36, 22);
            this.btnBrowseInputPath.TabIndex = 2;
            this.btnBrowseInputPath.Text = "...";
            this.btnBrowseInputPath.UseVisualStyleBackColor = true;
            this.btnBrowseInputPath.Click += new System.EventHandler(this.btnBrowseInputPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(17, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 493);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inställningar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbExportRGBType);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.cbExportSeparator);
            this.groupBox6.Controls.Add(this.cbExportMode);
            this.groupBox6.Location = new System.Drawing.Point(8, 407);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(387, 79);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Export";
            // 
            // cbExportRGBType
            // 
            this.cbExportRGBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportRGBType.FormattingEnabled = true;
            this.cbExportRGBType.Items.AddRange(new object[] {
            "0-255",
            "0.0-1.0"});
            this.cbExportRGBType.Location = new System.Drawing.Point(84, 46);
            this.cbExportRGBType.Name = "cbExportRGBType";
            this.cbExportRGBType.Size = new System.Drawing.Size(66, 21);
            this.cbExportRGBType.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(45, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "RGB:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(224, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Separator:";
            // 
            // cbExportSeparator
            // 
            this.cbExportSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportSeparator.FormattingEnabled = true;
            this.cbExportSeparator.Items.AddRange(new object[] {
            "Mellanslag",
            "Komma",
            "Punkt"});
            this.cbExportSeparator.Location = new System.Drawing.Point(286, 19);
            this.cbExportSeparator.Name = "cbExportSeparator";
            this.cbExportSeparator.Size = new System.Drawing.Size(82, 21);
            this.cbExportSeparator.TabIndex = 5;
            // 
            // cbExportMode
            // 
            this.cbExportMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExportMode.FormattingEnabled = true;
            this.cbExportMode.Items.AddRange(new object[] {
            "XYZI",
            "XYZRGB",
            "XYZRGBI",
            "XYZIC",
            "XYZRGBC",
            "XYZRGBIC",
            "CloudCompareXYZIC"});
            this.cbExportMode.Location = new System.Drawing.Point(10, 19);
            this.cbExportMode.Name = "cbExportMode";
            this.cbExportMode.Size = new System.Drawing.Size(140, 21);
            this.cbExportMode.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbImportRGBType);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.cbImportMode);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.cbRowsToSkip);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.cbImportSeparator);
            this.groupBox5.Location = new System.Drawing.Point(6, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(387, 81);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Import";
            // 
            // cbImportRGBType
            // 
            this.cbImportRGBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImportRGBType.FormattingEnabled = true;
            this.cbImportRGBType.Items.AddRange(new object[] {
            "0-255",
            "0.0-1.0"});
            this.cbImportRGBType.Location = new System.Drawing.Point(86, 49);
            this.cbImportRGBType.Name = "cbImportRGBType";
            this.cbImportRGBType.Size = new System.Drawing.Size(66, 21);
            this.cbImportRGBType.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(47, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "RGB:";
            // 
            // cbImportMode
            // 
            this.cbImportMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImportMode.FormattingEnabled = true;
            this.cbImportMode.Items.AddRange(new object[] {
            "XYZ",
            "XYZI",
            "XYZRGB",
            "XYZRGBI",
            "XYZIC",
            "XYZRGBC",
            "XYZRGBCI",
            "CloudCompareXYZIC"});
            this.cbImportMode.Location = new System.Drawing.Point(12, 19);
            this.cbImportMode.Name = "cbImportMode";
            this.cbImportMode.Size = new System.Drawing.Size(140, 21);
            this.cbImportMode.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(228, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Separator:";
            // 
            // cbRowsToSkip
            // 
            this.cbRowsToSkip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRowsToSkip.FormattingEnabled = true;
            this.cbRowsToSkip.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbRowsToSkip.Location = new System.Drawing.Point(290, 19);
            this.cbRowsToSkip.Name = "cbRowsToSkip";
            this.cbRowsToSkip.Size = new System.Drawing.Size(78, 21);
            this.cbRowsToSkip.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(167, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Antal rader att ignorera:";
            // 
            // cbImportSeparator
            // 
            this.cbImportSeparator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImportSeparator.FormattingEnabled = true;
            this.cbImportSeparator.Items.AddRange(new object[] {
            "Mellanslag",
            "Komma",
            "Punkt"});
            this.cbImportSeparator.Location = new System.Drawing.Point(290, 49);
            this.cbImportSeparator.Name = "cbImportSeparator";
            this.cbImportSeparator.Size = new System.Drawing.Size(78, 21);
            this.cbImportSeparator.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtCylinderRadius);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cbIgnorePointsAboveBelow);
            this.groupBox4.Controls.Add(this.txtCylinderHeight);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtCylinderZ);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtCylinderY);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtCylinderX);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(7, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(387, 108);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lodrät Cylinder";
            // 
            // txtCylinderRadius
            // 
            this.txtCylinderRadius.Location = new System.Drawing.Point(157, 45);
            this.txtCylinderRadius.Name = "txtCylinderRadius";
            this.txtCylinderRadius.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCylinderRadius.Size = new System.Drawing.Size(83, 20);
            this.txtCylinderRadius.TabIndex = 14;
            this.txtCylinderRadius.Text = "0,000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Radie:";
            // 
            // cbIgnorePointsAboveBelow
            // 
            this.cbIgnorePointsAboveBelow.AutoSize = true;
            this.cbIgnorePointsAboveBelow.Enabled = false;
            this.cbIgnorePointsAboveBelow.Location = new System.Drawing.Point(164, 80);
            this.cbIgnorePointsAboveBelow.Name = "cbIgnorePointsAboveBelow";
            this.cbIgnorePointsAboveBelow.Size = new System.Drawing.Size(204, 17);
            this.cbIgnorePointsAboveBelow.TabIndex = 12;
            this.cbIgnorePointsAboveBelow.Text = "Ignorera Punkter ovan/under Cylinder";
            this.cbIgnorePointsAboveBelow.UseVisualStyleBackColor = true;
            // 
            // txtCylinderHeight
            // 
            this.txtCylinderHeight.Enabled = false;
            this.txtCylinderHeight.Location = new System.Drawing.Point(285, 45);
            this.txtCylinderHeight.Name = "txtCylinderHeight";
            this.txtCylinderHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCylinderHeight.Size = new System.Drawing.Size(83, 20);
            this.txtCylinderHeight.TabIndex = 11;
            this.txtCylinderHeight.Text = "0,000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Höjd:";
            // 
            // txtCylinderZ
            // 
            this.txtCylinderZ.Enabled = false;
            this.txtCylinderZ.Location = new System.Drawing.Point(285, 19);
            this.txtCylinderZ.Name = "txtCylinderZ";
            this.txtCylinderZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCylinderZ.Size = new System.Drawing.Size(83, 20);
            this.txtCylinderZ.TabIndex = 9;
            this.txtCylinderZ.Text = "0,000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Z:";
            // 
            // txtCylinderY
            // 
            this.txtCylinderY.Location = new System.Drawing.Point(157, 19);
            this.txtCylinderY.Name = "txtCylinderY";
            this.txtCylinderY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCylinderY.Size = new System.Drawing.Size(83, 20);
            this.txtCylinderY.TabIndex = 7;
            this.txtCylinderY.Text = "0,000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Y:";
            // 
            // txtCylinderX
            // 
            this.txtCylinderX.Location = new System.Drawing.Point(29, 19);
            this.txtCylinderX.Name = "txtCylinderX";
            this.txtCylinderX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCylinderX.Size = new System.Drawing.Size(83, 20);
            this.txtCylinderX.TabIndex = 5;
            this.txtCylinderX.Text = "0,000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "X:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelColorMidDistance);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbIntensityMax);
            this.groupBox3.Controls.Add(this.cbIntensityMin);
            this.groupBox3.Controls.Add(this.panelColorOutsideDistance);
            this.groupBox3.Controls.Add(this.panelColorMaxDistance);
            this.groupBox3.Controls.Add(this.panelColorMinDistance);
            this.groupBox3.Controls.Add(this.lblColorOutsideDistance);
            this.groupBox3.Controls.Add(this.lblColorMaxDistance);
            this.groupBox3.Controls.Add(this.lblColorMinDistance);
            this.groupBox3.Location = new System.Drawing.Point(237, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 177);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Färger och Intensitet";
            // 
            // panelColorMidDistance
            // 
            this.panelColorMidDistance.BackColor = System.Drawing.Color.Yellow;
            this.panelColorMidDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorMidDistance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panelColorMidDistance.Location = new System.Drawing.Point(7, 43);
            this.panelColorMidDistance.Name = "panelColorMidDistance";
            this.panelColorMidDistance.Size = new System.Drawing.Size(20, 20);
            this.panelColorMidDistance.TabIndex = 8;
            this.panelColorMidDistance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorMidDistance_MouseClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(33, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Vid Mitt Avstånd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Intensitet Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Intensitet Min";
            // 
            // cbIntensityMax
            // 
            this.cbIntensityMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntensityMax.FormattingEnabled = true;
            this.cbIntensityMax.Location = new System.Drawing.Point(81, 144);
            this.cbIntensityMax.Name = "cbIntensityMax";
            this.cbIntensityMax.Size = new System.Drawing.Size(66, 21);
            this.cbIntensityMax.TabIndex = 10;
            // 
            // cbIntensityMin
            // 
            this.cbIntensityMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIntensityMin.FormattingEnabled = true;
            this.cbIntensityMin.Location = new System.Drawing.Point(9, 144);
            this.cbIntensityMin.Name = "cbIntensityMin";
            this.cbIntensityMin.Size = new System.Drawing.Size(66, 21);
            this.cbIntensityMin.TabIndex = 9;
            // 
            // panelColorOutsideDistance
            // 
            this.panelColorOutsideDistance.BackColor = System.Drawing.Color.Gray;
            this.panelColorOutsideDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorOutsideDistance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panelColorOutsideDistance.Location = new System.Drawing.Point(7, 95);
            this.panelColorOutsideDistance.Name = "panelColorOutsideDistance";
            this.panelColorOutsideDistance.Size = new System.Drawing.Size(20, 20);
            this.panelColorOutsideDistance.TabIndex = 8;
            this.panelColorOutsideDistance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorOutsideMaxDistance_MouseClick);
            // 
            // panelColorMaxDistance
            // 
            this.panelColorMaxDistance.BackColor = System.Drawing.Color.Red;
            this.panelColorMaxDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorMaxDistance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panelColorMaxDistance.Location = new System.Drawing.Point(7, 69);
            this.panelColorMaxDistance.Name = "panelColorMaxDistance";
            this.panelColorMaxDistance.Size = new System.Drawing.Size(20, 20);
            this.panelColorMaxDistance.TabIndex = 7;
            this.panelColorMaxDistance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorMaxDistance_MouseClick);
            // 
            // panelColorMinDistance
            // 
            this.panelColorMinDistance.BackColor = System.Drawing.Color.Lime;
            this.panelColorMinDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorMinDistance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panelColorMinDistance.Location = new System.Drawing.Point(7, 16);
            this.panelColorMinDistance.Name = "panelColorMinDistance";
            this.panelColorMinDistance.Size = new System.Drawing.Size(20, 20);
            this.panelColorMinDistance.TabIndex = 6;
            this.panelColorMinDistance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelColorMinDistance_MouseClick);
            // 
            // lblColorOutsideDistance
            // 
            this.lblColorOutsideDistance.AutoSize = true;
            this.lblColorOutsideDistance.Location = new System.Drawing.Point(33, 97);
            this.lblColorOutsideDistance.Name = "lblColorOutsideDistance";
            this.lblColorOutsideDistance.Size = new System.Drawing.Size(84, 13);
            this.lblColorOutsideDistance.TabIndex = 5;
            this.lblColorOutsideDistance.Text = "Utanför Avstånd";
            // 
            // lblColorMaxDistance
            // 
            this.lblColorMaxDistance.AutoSize = true;
            this.lblColorMaxDistance.Location = new System.Drawing.Point(33, 71);
            this.lblColorMaxDistance.Name = "lblColorMaxDistance";
            this.lblColorMaxDistance.Size = new System.Drawing.Size(87, 13);
            this.lblColorMaxDistance.TabIndex = 3;
            this.lblColorMaxDistance.Text = "Vid Max Avstånd";
            // 
            // lblColorMinDistance
            // 
            this.lblColorMinDistance.AutoSize = true;
            this.lblColorMinDistance.Location = new System.Drawing.Point(33, 19);
            this.lblColorMinDistance.Name = "lblColorMinDistance";
            this.lblColorMinDistance.Size = new System.Drawing.Size(84, 13);
            this.lblColorMinDistance.TabIndex = 1;
            this.lblColorMinDistance.Text = "Vid Min Avstånd";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbColorType);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbColorMode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbOutsidePointsMode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbColorByMode);
            this.groupBox2.Controls.Add(this.txtMaxDistance);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 180);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Avståndsfärgsättning";
            // 
            // cbColorType
            // 
            this.cbColorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorType.FormattingEnabled = true;
            this.cbColorType.Items.AddRange(new object[] {
            "Färg",
            "Intensitet"});
            this.cbColorType.Location = new System.Drawing.Point(116, 128);
            this.cbColorType.Name = "cbColorType";
            this.cbColorType.Size = new System.Drawing.Size(95, 21);
            this.cbColorType.TabIndex = 8;
            this.cbColorType.SelectedIndexChanged += new System.EventHandler(this.cbColorType_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Färgsätt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Färgsätt sidor:";
            // 
            // cbColorMode
            // 
            this.cbColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorMode.FormattingEnabled = true;
            this.cbColorMode.Items.AddRange(new object[] {
            "Utsida & Insida",
            "Utsida",
            "Insida"});
            this.cbColorMode.Location = new System.Drawing.Point(88, 101);
            this.cbColorMode.Name = "cbColorMode";
            this.cbColorMode.Size = new System.Drawing.Size(123, 21);
            this.cbColorMode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Färgsätt enligt:";
            // 
            // cbOutsidePointsMode
            // 
            this.cbOutsidePointsMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOutsidePointsMode.FormattingEnabled = true;
            this.cbOutsidePointsMode.Items.AddRange(new object[] {
            "Ignorera",
            "Ta Bort",
            "Färgsätt"});
            this.cbOutsidePointsMode.Location = new System.Drawing.Point(138, 72);
            this.cbOutsidePointsMode.Name = "cbOutsidePointsMode";
            this.cbOutsidePointsMode.Size = new System.Drawing.Size(73, 21);
            this.cbOutsidePointsMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punkter utanför Avstånd:";
            // 
            // cbColorByMode
            // 
            this.cbColorByMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorByMode.FormattingEnabled = true;
            this.cbColorByMode.Items.AddRange(new object[] {
            "Längsta Avståndet",
            "Max Avstånd"});
            this.cbColorByMode.Location = new System.Drawing.Point(88, 19);
            this.cbColorByMode.Name = "cbColorByMode";
            this.cbColorByMode.Size = new System.Drawing.Size(123, 21);
            this.cbColorByMode.TabIndex = 0;
            // 
            // txtMaxDistance
            // 
            this.txtMaxDistance.Location = new System.Drawing.Point(157, 46);
            this.txtMaxDistance.Name = "txtMaxDistance";
            this.txtMaxDistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaxDistance.Size = new System.Drawing.Size(54, 20);
            this.txtMaxDistance.TabIndex = 1;
            this.txtMaxDistance.Text = "0,300";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Max Avstånd:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(343, 549);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colorDialog
            // 
            this.colorDialog.Color = System.Drawing.Color.White;
            this.colorDialog.FullOpen = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 581);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowseInputPath);
            this.Controls.Add(this.txtInputPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cloud Cut/Fill Gradient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Button btnBrowseInputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbOutsidePointsMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbColorByMode;
        private System.Windows.Forms.TextBox txtMaxDistance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCylinderRadius;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbIgnorePointsAboveBelow;
        private System.Windows.Forms.TextBox txtCylinderHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCylinderZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCylinderY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCylinderX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblColorOutsideDistance;
        private System.Windows.Forms.Label lblColorMaxDistance;
        private System.Windows.Forms.Label lblColorMinDistance;
        private System.Windows.Forms.Panel panelColorMinDistance;
        private System.Windows.Forms.Panel panelColorOutsideDistance;
        private System.Windows.Forms.Panel panelColorMaxDistance;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbRowsToSkip;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbImportSeparator;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cbExportMode;
        private System.Windows.Forms.ComboBox cbIntensityMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIntensityMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbColorMode;
        private System.Windows.Forms.ComboBox cbColorType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbImportMode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbExportSeparator;
        private System.Windows.Forms.ComboBox cbExportRGBType;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbImportRGBType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panelColorMidDistance;
        private System.Windows.Forms.Label label19;
    }
}

