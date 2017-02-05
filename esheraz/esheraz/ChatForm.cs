using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esheraz
{
    public partial class СhatForm : Form
    {
        string otpravlennoe;
        Random Randomizer;
        Generator gen;
        public СhatForm()
        {
           
            InitializeComponent();
             gen = new Generator();
            Randomizer = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(PoleVvoda.Text))
            {
                chatik.Text += "\r\nTы: " + PoleVvoda.Text;
                otpravlennoe = PoleVvoda.Text;
                PoleVvoda.Text = "";
                timer.Interval = Randomizer.Next(500, 1000);
                label2.Text = timer.Interval.ToString()+ " ms до ответа";
                timer.Start();
                
            }
            else
                MessageBox.Show("Даже не пытайся", ":)");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chatik.Text += gen.AddAnswer(gen.GenerateAnswer(otpravlennoe));
            
            chatik.SelectionStart = chatik.TextLength;
            chatik.ScrollToCaret();
            PoleVvoda.Select();
            timer.Stop();
        }
    }
}
