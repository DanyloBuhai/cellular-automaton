namespace GameOfLife
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelAnt = new System.Windows.Forms.Label();
            this.cbAntPos = new System.Windows.Forms.CheckBox();
            this.cbReverse = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRule = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.gb2D = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nudBornMax = new System.Windows.Forms.NumericUpDown();
            this.nudDHigh = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudBornMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDLow = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.bntStart = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.tbSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBornMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBornMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.labelAnt);
            this.splitContainer1.Panel1.Controls.Add(this.cbAntPos);
            this.splitContainer1.Panel1.Controls.Add(this.cbReverse);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.btnRule);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cbMode);
            this.splitContainer1.Panel1.Controls.Add(this.gb2D);
            this.splitContainer1.Panel1.Controls.Add(this.bntStart);
            this.splitContainer1.Panel1.Controls.Add(this.trackBar1);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cbRandom);
            this.splitContainer1.Panel1.Controls.Add(this.btnPause);
            this.splitContainer1.Panel1.Controls.Add(this.tbSize);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(984, 567);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(9, 501);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(346, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Зберегти зображення";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelAnt
            // 
            this.labelAnt.AutoSize = true;
            this.labelAnt.Location = new System.Drawing.Point(16, 218);
            this.labelAnt.Name = "labelAnt";
            this.labelAnt.Size = new System.Drawing.Size(134, 13);
            this.labelAnt.TabIndex = 22;
            this.labelAnt.Text = "Виберіть клітинку на полі";
            this.labelAnt.Visible = false;
            // 
            // cbAntPos
            // 
            this.cbAntPos.AutoSize = true;
            this.cbAntPos.Location = new System.Drawing.Point(19, 196);
            this.cbAntPos.Name = "cbAntPos";
            this.cbAntPos.Size = new System.Drawing.Size(138, 17);
            this.cbAntPos.TabIndex = 21;
            this.cbAntPos.Text = "Задати позицію мурхи";
            this.cbAntPos.UseVisualStyleBackColor = true;
            this.cbAntPos.CheckedChanged += new System.EventHandler(this.cbAntPos_CheckedChanged);
            // 
            // cbReverse
            // 
            this.cbReverse.AutoSize = true;
            this.cbReverse.Location = new System.Drawing.Point(19, 221);
            this.cbReverse.Name = "cbReverse";
            this.cbReverse.Size = new System.Drawing.Size(138, 17);
            this.cbReverse.TabIndex = 20;
            this.cbReverse.Text = "Зворотне відтворення";
            this.cbReverse.UseVisualStyleBackColor = true;
            this.cbReverse.CheckedChanged += new System.EventHandler(this.cbReverse_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Клітинки розташовувати можна лише у першому рядку!";
            // 
            // btnRule
            // 
            this.btnRule.Location = new System.Drawing.Point(18, 191);
            this.btnRule.Name = "btnRule";
            this.btnRule.Size = new System.Drawing.Size(336, 24);
            this.btnRule.TabIndex = 18;
            this.btnRule.Text = "Задати правило";
            this.btnRule.UseVisualStyleBackColor = true;
            this.btnRule.Click += new System.EventHandler(this.btnRule_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Клітинний автомат";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Життєподібні КА",
            "Мураха Ленгтона",
            "Одновимірний КА",
            "Блочний КА"});
            this.cbMode.Location = new System.Drawing.Point(123, 164);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(231, 21);
            this.cbMode.TabIndex = 17;
            this.cbMode.SelectedIndexChanged += new System.EventHandler(this.cbMode_SelectedIndexChanged);
            // 
            // gb2D
            // 
            this.gb2D.Controls.Add(this.label6);
            this.gb2D.Controls.Add(this.label7);
            this.gb2D.Controls.Add(this.comboBox1);
            this.gb2D.Controls.Add(this.nudBornMax);
            this.gb2D.Controls.Add(this.nudDHigh);
            this.gb2D.Controls.Add(this.label3);
            this.gb2D.Controls.Add(this.nudBornMin);
            this.gb2D.Controls.Add(this.label4);
            this.gb2D.Controls.Add(this.nudDLow);
            this.gb2D.Controls.Add(this.label2);
            this.gb2D.Location = new System.Drawing.Point(17, 191);
            this.gb2D.Name = "gb2D";
            this.gb2D.Size = new System.Drawing.Size(337, 146);
            this.gb2D.TabIndex = 17;
            this.gb2D.TabStop = false;
            this.gb2D.Text = "Налаштування виживання клітини";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Оберіть окіл";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "до";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Окіл Мура",
            "Окіл фон Неймана"});
            this.comboBox1.Location = new System.Drawing.Point(95, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nudBornMax
            // 
            this.nudBornMax.Location = new System.Drawing.Point(275, 59);
            this.nudBornMax.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBornMax.Name = "nudBornMax";
            this.nudBornMax.ReadOnly = true;
            this.nudBornMax.Size = new System.Drawing.Size(27, 20);
            this.nudBornMax.TabIndex = 12;
            this.nudBornMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // nudDHigh
            // 
            this.nudDHigh.Location = new System.Drawing.Point(151, 85);
            this.nudDHigh.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudDHigh.Name = "nudDHigh";
            this.nudDHigh.ReadOnly = true;
            this.nudDHigh.Size = new System.Drawing.Size(27, 20);
            this.nudDHigh.TabIndex = 7;
            this.nudDHigh.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Максмальна к-ть клітин";
            // 
            // nudBornMin
            // 
            this.nudBornMin.Location = new System.Drawing.Point(217, 59);
            this.nudBornMin.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudBornMin.Name = "nudBornMin";
            this.nudBornMin.ReadOnly = true;
            this.nudBornMin.Size = new System.Drawing.Size(27, 20);
            this.nudBornMin.TabIndex = 6;
            this.nudBornMin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudBornMin.ValueChanged += new System.EventHandler(this.nudBorn_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Мінімальна к-ть клітин";
            // 
            // nudDLow
            // 
            this.nudDLow.Location = new System.Drawing.Point(151, 111);
            this.nudDLow.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudDLow.Name = "nudDLow";
            this.nudDLow.ReadOnly = true;
            this.nudDLow.Size = new System.Drawing.Size(26, 20);
            this.nudDLow.TabIndex = 8;
            this.nudDLow.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Діапазон клітин для народження:   від";
            // 
            // bntStart
            // 
            this.bntStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bntStart.Location = new System.Drawing.Point(8, 443);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(346, 23);
            this.bntStart.TabIndex = 2;
            this.bntStart.Text = "Розпочати";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(9, 78);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar1.Size = new System.Drawing.Size(346, 45);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 14;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.Location = new System.Drawing.Point(10, 530);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(345, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Завершити";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Швидкість оновлення";
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbRandom.Location = new System.Drawing.Point(10, 129);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(157, 17);
            this.cbRandom.TabIndex = 12;
            this.cbRandom.Text = "Випадкове стартове поле";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(9, 472);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(345, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(10, 30);
            this.tbSize.Maximum = 30;
            this.tbSize.Minimum = 2;
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(345, 45);
            this.tbSize.TabIndex = 5;
            this.tbSize.Value = 5;
            this.tbSize.Scroll += new System.EventHandler(this.tbSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Розмір клітини";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 563);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 567);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Клітинні автомати";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ClientSizeChanged += new System.EventHandler(this.Form1_ClientSizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb2D.ResumeLayout(false);
            this.gb2D.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBornMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBornMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar tbSize;
        private System.Windows.Forms.NumericUpDown nudDHigh;
        private System.Windows.Forms.NumericUpDown nudBornMin;
        private System.Windows.Forms.NumericUpDown nudDLow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.GroupBox gb2D;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown nudBornMax;
        private System.Windows.Forms.Button btnRule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbReverse;
        private System.Windows.Forms.CheckBox cbAntPos;
        private System.Windows.Forms.Label labelAnt;
        private System.Windows.Forms.Button btnSave;
    }
}

