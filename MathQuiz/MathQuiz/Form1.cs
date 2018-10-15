using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variable store the numbers
        // for the additional problem.
        int addend1;
        int addend2;

        int timeLeft;

        public void StartQuiz()
        {

            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void plusRightLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Display the new time left by updating the timeLeft label.
            if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                startButton.Enabled = true;
            }
        }
    }
}
