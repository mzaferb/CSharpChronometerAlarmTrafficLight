namespace TimerYucedag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour = 0;
        int minute = 0;
        int second = 0;

        int rCounter = 15;
        int yCounter = 2;
        int gCounter = 8;

        //CHRONOMETER
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = hour.ToString("D2");
            label2.Text = minute.ToString("D2");
            label3.Text = second.ToString("D2");
            timerChr.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second += 1;
            if (second == 60)
            {
                minute += 1;
                second = 0;
            }
            if (minute == 60)
            {
                hour += 1;
                minute = 0;
            }

            label1.Text = hour.ToString("D2");
            label2.Text = minute.ToString("D2");
            label3.Text = second.ToString("D2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerChr.Stop();

            listBox1.Items.Add(label1.Text + " : " + label2.Text + " : " + label3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerChr.Stop();

            hour = 0;
            minute = 0;
            second = 0;

            label1.Text = hour.ToString("D2");
            label2.Text = minute.ToString("D2");
            label3.Text = second.ToString("D2");

            listBox1.Items.Clear();
        }
        //ALARM
        private void button4_Click(object sender, EventArgs e)
        {
            if (btnAlarm.Text == "Alarm Off")
            {
                timerAlarm.Stop();
                btnAlarm.Text = "Alarm On";
                label8.Text = "OFF";
                label8.BackColor = Color.Red;
                return;
            }
            timerAlarm.Start();
            btnAlarm.Text = "Alarm Off";
            label8.Text = " ON";
            label8.BackColor = Color.Green;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            if (hour == nudHour.Value && minute == nudMinute.Value)
            {
                timerAlarm.Stop();
                MessageBox.Show("Alarm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAlarm.Text = "Alarm On";
                label8.Text = "OFF";
                label8.BackColor = Color.Red;
            }
        }
        //TRAFFIC LIGHT
        private void button8_Click(object sender, EventArgs e)
        {
            btnRed.BackColor = Color.Red;
            lblRed.Visible = true;
            timerTraf.Start();
            btnTrafStart.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            if (rCounter != 1)
            {
                rCounter--;
                lblRed.Text = rCounter.ToString();
                lblRed.Visible = true;

                return;
            }
            if (yCounter != 0)
            {
                lblYellow.Text = yCounter.ToString();
                yCounter--;
                btnYellow.BackColor = Color.Yellow;
                lblYellow.Visible = true;
                lblRed.Visible = false;

                return;
            }
            if (gCounter != 0)
            {
                lblGreen.Text = gCounter.ToString();
                gCounter--;
                btnGreen.BackColor = Color.Green;
                lblGreen.Visible = true;
                lblYellow.Visible = false;
                btnRed.BackColor = Color.Black;
                btnYellow.BackColor = Color.Black;

                return;
            }
            timerTraf.Stop();
            btnTrafStart.Enabled = true;
            btnGreen.BackColor = Color.Black;
            lblGreen.Visible = false;
            rCounter = 15;
            lblRed.Text = rCounter.ToString();
            yCounter = 2;
            gCounter = 8;
        }
    }
}