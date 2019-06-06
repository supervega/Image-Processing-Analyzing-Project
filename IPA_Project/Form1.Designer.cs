namespace IPA_Project
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
            this.ImageGB = new System.Windows.Forms.GroupBox();
            this.ConvexHullControl = new System.Windows.Forms.CheckBox();
            this.ConvexHullGB = new System.Windows.Forms.GroupBox();
            this.AllowFillCB = new System.Windows.Forms.CheckBox();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Computebtn = new System.Windows.Forms.Button();
            this.Modifiersbtn = new System.Windows.Forms.Button();
            this.Undobtn = new System.Windows.Forms.Button();
            this.SaveImagebtn = new System.Windows.Forms.Button();
            this.LoadImagebtn = new System.Windows.Forms.Button();
            this.ImagePB = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Equalizebtn = new System.Windows.Forms.Button();
            this.Histogrambtn = new System.Windows.Forms.Button();
            this.HistogramPB = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Convertlbl = new System.Windows.Forms.Label();
            this.Dilationbtn = new System.Windows.Forms.Button();
            this.Erosionbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ThresholdNUD = new System.Windows.Forms.NumericUpDown();
            this.Convertbtn = new System.Windows.Forms.Button();
            this.GrayScaleCB = new System.Windows.Forms.RadioButton();
            this.BinaryCB = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ImageGB.SuspendLayout();
            this.ConvexHullGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPB)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageGB
            // 
            this.ImageGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImageGB.Controls.Add(this.ConvexHullControl);
            this.ImageGB.Controls.Add(this.ConvexHullGB);
            this.ImageGB.Controls.Add(this.Modifiersbtn);
            this.ImageGB.Controls.Add(this.Undobtn);
            this.ImageGB.Controls.Add(this.SaveImagebtn);
            this.ImageGB.Controls.Add(this.LoadImagebtn);
            this.ImageGB.Controls.Add(this.ImagePB);
            this.ImageGB.Location = new System.Drawing.Point(12, 12);
            this.ImageGB.Name = "ImageGB";
            this.ImageGB.Size = new System.Drawing.Size(647, 641);
            this.ImageGB.TabIndex = 0;
            this.ImageGB.TabStop = false;
            this.ImageGB.Text = "Image";
            // 
            // ConvexHullControl
            // 
            this.ConvexHullControl.AutoSize = true;
            this.ConvexHullControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvexHullControl.Location = new System.Drawing.Point(610, 595);
            this.ConvexHullControl.Name = "ConvexHullControl";
            this.ConvexHullControl.Size = new System.Drawing.Size(15, 14);
            this.ConvexHullControl.TabIndex = 13;
            this.ConvexHullControl.UseVisualStyleBackColor = true;
            this.ConvexHullControl.CheckedChanged += new System.EventHandler(this.ConvexHullControl_CheckedChanged);
            // 
            // ConvexHullGB
            // 
            this.ConvexHullGB.Controls.Add(this.AllowFillCB);
            this.ConvexHullGB.Controls.Add(this.Clearbtn);
            this.ConvexHullGB.Controls.Add(this.Computebtn);
            this.ConvexHullGB.Enabled = false;
            this.ConvexHullGB.Location = new System.Drawing.Point(242, 595);
            this.ConvexHullGB.Name = "ConvexHullGB";
            this.ConvexHullGB.Size = new System.Drawing.Size(365, 44);
            this.ConvexHullGB.TabIndex = 9;
            this.ConvexHullGB.TabStop = false;
            this.ConvexHullGB.Text = "Convex Hull";
            // 
            // AllowFillCB
            // 
            this.AllowFillCB.AutoSize = true;
            this.AllowFillCB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllowFillCB.Location = new System.Drawing.Point(64, 15);
            this.AllowFillCB.Name = "AllowFillCB";
            this.AllowFillCB.Size = new System.Drawing.Size(81, 20);
            this.AllowFillCB.TabIndex = 12;
            this.AllowFillCB.Text = "Allow Fill";
            this.AllowFillCB.UseVisualStyleBackColor = true;
            this.AllowFillCB.CheckedChanged += new System.EventHandler(this.AllowFillCB_CheckedChanged);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.Location = new System.Drawing.Point(164, 5);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(61, 35);
            this.Clearbtn.TabIndex = 11;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Computebtn
            // 
            this.Computebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Computebtn.Location = new System.Drawing.Point(231, 5);
            this.Computebtn.Name = "Computebtn";
            this.Computebtn.Size = new System.Drawing.Size(105, 35);
            this.Computebtn.TabIndex = 10;
            this.Computebtn.Text = "Compute";
            this.Computebtn.UseVisualStyleBackColor = true;
            this.Computebtn.Click += new System.EventHandler(this.Computebtn_Click);
            // 
            // Modifiersbtn
            // 
            this.Modifiersbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifiersbtn.Location = new System.Drawing.Point(610, 261);
            this.Modifiersbtn.Name = "Modifiersbtn";
            this.Modifiersbtn.Size = new System.Drawing.Size(37, 33);
            this.Modifiersbtn.TabIndex = 8;
            this.Modifiersbtn.Text = ">>";
            this.Modifiersbtn.UseVisualStyleBackColor = true;
            this.Modifiersbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Undobtn
            // 
            this.Undobtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Undobtn.Location = new System.Drawing.Point(159, 600);
            this.Undobtn.Name = "Undobtn";
            this.Undobtn.Size = new System.Drawing.Size(59, 35);
            this.Undobtn.TabIndex = 4;
            this.Undobtn.Text = "Undo";
            this.Undobtn.UseVisualStyleBackColor = true;
            this.Undobtn.Click += new System.EventHandler(this.Undobtn_Click);
            // 
            // SaveImagebtn
            // 
            this.SaveImagebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveImagebtn.Location = new System.Drawing.Point(96, 600);
            this.SaveImagebtn.Name = "SaveImagebtn";
            this.SaveImagebtn.Size = new System.Drawing.Size(57, 35);
            this.SaveImagebtn.TabIndex = 2;
            this.SaveImagebtn.Text = "Save";
            this.SaveImagebtn.UseVisualStyleBackColor = true;
            this.SaveImagebtn.Click += new System.EventHandler(this.SaveImagebtn_Click);
            // 
            // LoadImagebtn
            // 
            this.LoadImagebtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImagebtn.Location = new System.Drawing.Point(31, 600);
            this.LoadImagebtn.Name = "LoadImagebtn";
            this.LoadImagebtn.Size = new System.Drawing.Size(59, 35);
            this.LoadImagebtn.TabIndex = 1;
            this.LoadImagebtn.Text = "Load";
            this.LoadImagebtn.UseVisualStyleBackColor = true;
            this.LoadImagebtn.Click += new System.EventHandler(this.LoadImagebtn_Click);
            // 
            // ImagePB
            // 
            this.ImagePB.BackColor = System.Drawing.Color.Black;
            this.ImagePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePB.Location = new System.Drawing.Point(32, 19);
            this.ImagePB.Name = "ImagePB";
            this.ImagePB.Size = new System.Drawing.Size(575, 575);
            this.ImagePB.TabIndex = 0;
            this.ImagePB.TabStop = false;
            this.ImagePB.Paint += new System.Windows.Forms.PaintEventHandler(this.ImagePB_Paint);
            this.ImagePB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImagePB_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(659, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 641);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifiers";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Equalizebtn);
            this.groupBox4.Controls.Add(this.Histogrambtn);
            this.groupBox4.Controls.Add(this.HistogramPB);
            this.groupBox4.Location = new System.Drawing.Point(6, 350);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 276);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Histogram && Equlizing Histogram";
            // 
            // Equalizebtn
            // 
            this.Equalizebtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equalizebtn.Location = new System.Drawing.Point(194, 247);
            this.Equalizebtn.Name = "Equalizebtn";
            this.Equalizebtn.Size = new System.Drawing.Size(75, 23);
            this.Equalizebtn.TabIndex = 9;
            this.Equalizebtn.Text = "Equalize";
            this.Equalizebtn.UseVisualStyleBackColor = true;
            this.Equalizebtn.Click += new System.EventHandler(this.Equalizebtn_Click);
            // 
            // Histogrambtn
            // 
            this.Histogrambtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Histogrambtn.Location = new System.Drawing.Point(54, 247);
            this.Histogrambtn.Name = "Histogrambtn";
            this.Histogrambtn.Size = new System.Drawing.Size(75, 23);
            this.Histogrambtn.TabIndex = 8;
            this.Histogrambtn.Text = "Histogrambtn";
            this.Histogrambtn.UseVisualStyleBackColor = true;
            this.Histogrambtn.Click += new System.EventHandler(this.Histogrambtn_Click);
            // 
            // HistogramPB
            // 
            this.HistogramPB.BackColor = System.Drawing.Color.Black;
            this.HistogramPB.Location = new System.Drawing.Point(8, 19);
            this.HistogramPB.Name = "HistogramPB";
            this.HistogramPB.Size = new System.Drawing.Size(306, 225);
            this.HistogramPB.TabIndex = 0;
            this.HistogramPB.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Convertlbl);
            this.groupBox3.Controls.Add(this.Dilationbtn);
            this.groupBox3.Controls.Add(this.Erosionbtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(6, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 219);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Erosion && Dilation";
            // 
            // Convertlbl
            // 
            this.Convertlbl.AutoSize = true;
            this.Convertlbl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convertlbl.ForeColor = System.Drawing.Color.Red;
            this.Convertlbl.Location = new System.Drawing.Point(103, 16);
            this.Convertlbl.Name = "Convertlbl";
            this.Convertlbl.Size = new System.Drawing.Size(0, 13);
            this.Convertlbl.TabIndex = 9;
            // 
            // Dilationbtn
            // 
            this.Dilationbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dilationbtn.Location = new System.Drawing.Point(194, 191);
            this.Dilationbtn.Name = "Dilationbtn";
            this.Dilationbtn.Size = new System.Drawing.Size(75, 23);
            this.Dilationbtn.TabIndex = 8;
            this.Dilationbtn.Text = "Dilation";
            this.Dilationbtn.UseVisualStyleBackColor = true;
            this.Dilationbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Erosionbtn
            // 
            this.Erosionbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Erosionbtn.Location = new System.Drawing.Point(54, 191);
            this.Erosionbtn.Name = "Erosionbtn";
            this.Erosionbtn.Size = new System.Drawing.Size(75, 23);
            this.Erosionbtn.TabIndex = 7;
            this.Erosionbtn.Text = "Erosion";
            this.Erosionbtn.UseVisualStyleBackColor = true;
            this.Erosionbtn.Click += new System.EventHandler(this.Erosionbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mask :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.textBox9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 116);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(184, 80);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(85, 20);
            this.textBox9.TabIndex = 8;
            this.textBox9.Text = "1";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(94, 80);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(83, 20);
            this.textBox8.TabIndex = 7;
            this.textBox8.Text = "1";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(4, 80);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(83, 20);
            this.textBox7.TabIndex = 6;
            this.textBox7.Text = "1";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(184, 42);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(85, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "1";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(94, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(83, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "1";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(4, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "1";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(184, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(94, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted To:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ThresholdNUD);
            this.groupBox2.Controls.Add(this.Convertbtn);
            this.groupBox2.Controls.Add(this.GrayScaleCB);
            this.groupBox2.Controls.Add(this.BinaryCB);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Threshold:";
            // 
            // ThresholdNUD
            // 
            this.ThresholdNUD.Location = new System.Drawing.Point(80, 50);
            this.ThresholdNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ThresholdNUD.Name = "ThresholdNUD";
            this.ThresholdNUD.Size = new System.Drawing.Size(49, 20);
            this.ThresholdNUD.TabIndex = 3;
            this.ThresholdNUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Convertbtn
            // 
            this.Convertbtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convertbtn.Location = new System.Drawing.Point(124, 71);
            this.Convertbtn.Name = "Convertbtn";
            this.Convertbtn.Size = new System.Drawing.Size(75, 23);
            this.Convertbtn.TabIndex = 2;
            this.Convertbtn.Text = "Convert";
            this.Convertbtn.UseVisualStyleBackColor = true;
            this.Convertbtn.Click += new System.EventHandler(this.Convertbtn_Click);
            // 
            // GrayScaleCB
            // 
            this.GrayScaleCB.AutoSize = true;
            this.GrayScaleCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayScaleCB.Location = new System.Drawing.Point(194, 19);
            this.GrayScaleCB.Name = "GrayScaleCB";
            this.GrayScaleCB.Size = new System.Drawing.Size(108, 23);
            this.GrayScaleCB.TabIndex = 1;
            this.GrayScaleCB.Text = "GrayScale";
            this.GrayScaleCB.UseVisualStyleBackColor = true;
            // 
            // BinaryCB
            // 
            this.BinaryCB.AutoSize = true;
            this.BinaryCB.Checked = true;
            this.BinaryCB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinaryCB.Location = new System.Drawing.Point(29, 19);
            this.BinaryCB.Name = "BinaryCB";
            this.BinaryCB.Size = new System.Drawing.Size(79, 23);
            this.BinaryCB.TabIndex = 0;
            this.BinaryCB.TabStop = true;
            this.BinaryCB.Text = "Binary";
            this.BinaryCB.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 658);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImageGB);
            this.MaximumSize = new System.Drawing.Size(1011, 697);
            this.MinimumSize = new System.Drawing.Size(667, 697);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "IPA Powered By Mohamad Ammar Al-Azem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ImageGB.ResumeLayout(false);
            this.ImageGB.PerformLayout();
            this.ConvexHullGB.ResumeLayout(false);
            this.ConvexHullGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPB)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ImageGB;
        private System.Windows.Forms.PictureBox ImagePB;
        private System.Windows.Forms.Button SaveImagebtn;
        private System.Windows.Forms.Button LoadImagebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Convertbtn;
        private System.Windows.Forms.RadioButton GrayScaleCB;
        private System.Windows.Forms.RadioButton BinaryCB;
        private System.Windows.Forms.Button Undobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ThresholdNUD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dilationbtn;
        private System.Windows.Forms.Button Erosionbtn;
        private System.Windows.Forms.Label Convertlbl;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Equalizebtn;
        private System.Windows.Forms.Button Histogrambtn;
        private System.Windows.Forms.PictureBox HistogramPB;
        private System.Windows.Forms.Button Modifiersbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox ConvexHullGB;
        private System.Windows.Forms.Button Computebtn;
        private System.Windows.Forms.CheckBox AllowFillCB;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.CheckBox ConvexHullControl;
    }
}

