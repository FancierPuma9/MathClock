using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

using MathClock;

namespace MathClockClass
{
    public partial class Form1 : Form
    {
        MathClock.MathClock mathClock = new MathClock.MathClock();
        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            mathClock.curTimeStartCall();
            mathClock.SoundFile = "C:\\Users\\idont\\PROJECTS\\C#\\MathClock\\alarm_sound.wav"; //FILE NEEDS TO BE ON SERVER
            mathClock.SoundReplayTime = 3000;
        }
        
        private void startAlarm_Click(object sender, EventArgs e)
        {
            if (startAlarm.Text == "Start")
            {
                mathClock.AlarmTime = timePicker.Value;
                mathClock.startAlarm();
                if (mathClock.AlarmOn == true)
                {
                    startAlarm.Text = "Stop";
                }
            }
            else
            {
                mathClock.stopAlarm();
                startAlarm.Text = "Start";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            curTimeLabel.Text = String.Format("{0}",mathClock.CurTime.ToString());
            if (mathClock.AlarmReachedBool == true)
            {
                problemLabel.Text = String.Format("{0} + {1} =", mathClock.Num1, mathClock.Num2);
            }
            else
            {
                problemLabel.Text = " ";
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            wrongLabel.Text = mathClock.testAnswer(Int32.Parse(answerBox.Text));
            if(mathClock.AlarmOn == false)
            {
                startAlarm.Text = "Start";
            }
        }
    }
}
