namespace TimerYucedag
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnChrStart = new Button();
            timerChr = new System.Windows.Forms.Timer(components);
            btnChrStop = new Button();
            btnChrReset = new Button();
            label4 = new Label();
            label5 = new Label();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btnAlarm = new Button();
            nudMinute = new NumericUpDown();
            label7 = new Label();
            nudHour = new NumericUpDown();
            label6 = new Label();
            timerAlarm = new System.Windows.Forms.Timer(components);
            groupBox3 = new GroupBox();
            lblGreen = new Label();
            lblYellow = new Label();
            lblRed = new Label();
            btnTrafStart = new Button();
            btnGreen = new Button();
            btnYellow = new Button();
            btnRed = new Button();
            timerTraf = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHour).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(34, 28);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 36);
            label2.Name = "label2";
            label2.Size = new Size(34, 28);
            label2.TabIndex = 1;
            label2.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(86, 36);
            label3.Name = "label3";
            label3.Size = new Size(34, 28);
            label3.TabIndex = 2;
            label3.Text = "00";
            // 
            // btnChrStart
            // 
            btnChrStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChrStart.Location = new Point(6, 67);
            btnChrStart.Name = "btnChrStart";
            btnChrStart.Size = new Size(114, 44);
            btnChrStart.TabIndex = 3;
            btnChrStart.Text = "Start";
            btnChrStart.UseVisualStyleBackColor = true;
            btnChrStart.Click += button1_Click;
            // 
            // timerChr
            // 
            timerChr.Interval = 1;
            timerChr.Tick += timer1_Tick;
            // 
            // btnChrStop
            // 
            btnChrStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChrStop.Location = new Point(6, 117);
            btnChrStop.Name = "btnChrStop";
            btnChrStop.Size = new Size(114, 44);
            btnChrStop.TabIndex = 4;
            btnChrStop.Text = "Stop";
            btnChrStop.UseVisualStyleBackColor = true;
            btnChrStop.Click += button2_Click;
            // 
            // btnChrReset
            // 
            btnChrReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChrReset.Location = new Point(6, 167);
            btnChrReset.Name = "btnChrReset";
            btnChrReset.Size = new Size(114, 44);
            btnChrReset.TabIndex = 5;
            btnChrReset.Text = "Reset";
            btnChrReset.UseVisualStyleBackColor = true;
            btnChrReset.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 36);
            label4.Name = "label4";
            label4.Size = new Size(16, 28);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(75, 36);
            label5.Name = "label5";
            label5.Size = new Size(16, 28);
            label5.TabIndex = 7;
            label5.Text = ":";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(145, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 172);
            listBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChrStart);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnChrReset);
            groupBox1.Controls.Add(btnChrStop);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 220);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chronometer";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnAlarm);
            groupBox2.Controls.Add(nudMinute);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(nudHour);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(340, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(153, 220);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Alarm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Red;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(49, 117);
            label8.Name = "label8";
            label8.Size = new Size(47, 28);
            label8.TabIndex = 5;
            label8.Text = "OFF";
            // 
            // btnAlarm
            // 
            btnAlarm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlarm.Location = new Point(7, 166);
            btnAlarm.Name = "btnAlarm";
            btnAlarm.Size = new Size(140, 44);
            btnAlarm.TabIndex = 4;
            btnAlarm.Text = "Alarm On";
            btnAlarm.UseVisualStyleBackColor = true;
            btnAlarm.Click += button4_Click;
            // 
            // nudMinute
            // 
            nudMinute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudMinute.Location = new Point(80, 64);
            nudMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinute.Name = "nudMinute";
            nudMinute.Size = new Size(67, 34);
            nudMinute.TabIndex = 3;
            nudMinute.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(77, 33);
            label7.Name = "label7";
            label7.Size = new Size(74, 28);
            label7.TabIndex = 2;
            label7.Text = "Minute";
            // 
            // nudHour
            // 
            nudHour.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudHour.Location = new Point(7, 64);
            nudHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            nudHour.Name = "nudHour";
            nudHour.Size = new Size(67, 34);
            nudHour.TabIndex = 1;
            nudHour.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 33);
            label6.Name = "label6";
            label6.Size = new Size(56, 28);
            label6.TabIndex = 0;
            label6.Text = "Hour";
            // 
            // timerAlarm
            // 
            timerAlarm.Interval = 1000;
            timerAlarm.Tick += timer2_Tick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblGreen);
            groupBox3.Controls.Add(lblYellow);
            groupBox3.Controls.Add(lblRed);
            groupBox3.Controls.Add(btnTrafStart);
            groupBox3.Controls.Add(btnGreen);
            groupBox3.Controls.Add(btnYellow);
            groupBox3.Controls.Add(btnRed);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(521, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(189, 220);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Traffic Light";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.BackColor = Color.Green;
            lblGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGreen.ForeColor = Color.White;
            lblGreen.Location = new Point(20, 169);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(27, 20);
            lblGreen.TabIndex = 10;
            lblGreen.Text = "00";
            lblGreen.TextAlign = ContentAlignment.MiddleCenter;
            lblGreen.Visible = false;
            // 
            // lblYellow
            // 
            lblYellow.AutoSize = true;
            lblYellow.BackColor = Color.Yellow;
            lblYellow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblYellow.ForeColor = Color.Black;
            lblYellow.Location = new Point(29, 111);
            lblYellow.Name = "lblYellow";
            lblYellow.Size = new Size(18, 20);
            lblYellow.TabIndex = 9;
            lblYellow.Text = "0";
            lblYellow.TextAlign = ContentAlignment.MiddleCenter;
            lblYellow.Visible = false;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.BackColor = Color.Red;
            lblRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblRed.ForeColor = Color.White;
            lblRed.Location = new Point(20, 54);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(27, 20);
            lblRed.TabIndex = 8;
            lblRed.Tag = "";
            lblRed.Text = "15";
            lblRed.TextAlign = ContentAlignment.MiddleCenter;
            lblRed.Visible = false;
            // 
            // btnTrafStart
            // 
            btnTrafStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrafStart.Location = new Point(74, 95);
            btnTrafStart.Name = "btnTrafStart";
            btnTrafStart.Size = new Size(100, 50);
            btnTrafStart.TabIndex = 7;
            btnTrafStart.Text = "Start";
            btnTrafStart.UseVisualStyleBackColor = true;
            btnTrafStart.Click += button8_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Black;
            btnGreen.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGreen.Location = new Point(8, 151);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(50, 50);
            btnGreen.TabIndex = 6;
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Black;
            btnYellow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYellow.Location = new Point(8, 95);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(50, 50);
            btnYellow.TabIndex = 5;
            btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Black;
            btnRed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRed.Location = new Point(8, 39);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(50, 50);
            btnRed.TabIndex = 4;
            btnRed.UseVisualStyleBackColor = false;
            // 
            // timerTraf
            // 
            timerTraf.Interval = 1000;
            timerTraf.Tick += timer3_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(722, 242);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHour).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnChrStart;
        private System.Windows.Forms.Timer timerChr;
        private Button btnChrStop;
        private Button btnChrReset;
        private Label label4;
        private Label label5;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown nudHour;
        private Label label6;
        private Button btnAlarm;
        private NumericUpDown nudMinute;
        private Label label7;
        private System.Windows.Forms.Timer timerAlarm;
        private Label label8;
        private GroupBox groupBox3;
        private Button btnRed;
        private Button btnTrafStart;
        private Button btnGreen;
        private Button btnYellow;
        private Label lblGreen;
        private Label lblYellow;
        private Label lblRed;
        private System.Windows.Forms.Timer timerTraf;
    }
}