using PomodoroClock.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace PomodoroClock
{
    public partial class Form1 : Form
    {


        Stopwatch stopWatch = new Stopwatch();


        private SoundPlayer chiriAlarm;
        public Form1()
        {

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//QUita el borde
            this.BackColor = Color.DimGray;
            this.TransparencyKey = Color.DimGray;//Transparencia todo lo que esta en ese color/Recordar usar color WEB

            InitializeComponent();
            INIT();
            chiriAlarm = new SoundPlayer(@"C:\Users\petro\source\repos\PomodoroClock\PomodoroClock\Resources\chiriAudio.wav");

        }

        private Point firstPoint = new Point();
        public void INIT()
        {
            moveObj.MouseDown += (a, b) =>
            {
                if (b.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    firstPoint = Control.MousePosition;
                }
            };
            moveObj.MouseMove += (a, b) =>
            {
                if (b.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Point temp = Control.MousePosition;
                    Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                    moveObj.Location = new Point(moveObj.Location.X - res.X, moveObj.Location.Y - res.Y);

                    firstPoint = temp;
                }
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0, (int)stopWatch.ElapsedMilliseconds);
            timerPomodoro time = new timerPomodoro(timeSpan);
            ///string mili;
            textBox1.Text = time.hours();
            textBox2.Text = time.minutes();
            textBox3.Text = time.seconds();
     
            if (textBox3.Text == "10")
            {
                //  timer1.Stop();
                // timer1.Stop();
                chiriAlarm.Play();
                stopWatch.Stop();
                stopWatch.Reset();
               // stopWatch.Start();


                // chiriAlarm.Stop();
                // chiriAlarm.Dispose();
                // timer1.Start();

            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            
        }
    }
} 


