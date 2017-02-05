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
    public partial class ChatForm : Form
    {
        Generator gen;
        public ChatForm()
        {
           
            InitializeComponent();
            gen = new Generator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chatik.Text = gen.AddAnswer(gen.GenerateAnswer(PoleVvoda.Text));
                PoleVvoda.Text = "";
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
