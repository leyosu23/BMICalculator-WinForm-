using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This Load event allows enable timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            ProgressTimer.Enabled = true;
            LoadingTimer.Enabled = true;
        }



        /// <summary>
        /// This Tick event allows progressbar increases every tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (SplashFormProgressBar.Value < 100)
            {
                SplashFormProgressBar.Value += 5;
            }
            else
            {
                ProgressTimer.Enabled = false;
            }
        }



        /// <summary>
        /// This Tick event allows hide splashForm and show up  MainForm at 3 secs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Program.Forms["BMICalculatorForm"].Show();
            LoadingTimer.Enabled = false;
            ProgressTimer.Enabled = false;
        }


        /// <summary>
        /// This allows exit safely
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
