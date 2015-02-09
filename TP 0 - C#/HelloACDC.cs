using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "Hello ACDC";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "The Bullshit is strong with this one")
            {
                button1.BackColor = Color.Blue;
                button1.ForeColor = Color.White;
                button1.Text = "Hello ACDC";
            }
            else
            {
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.Black;
                button1.Text = "The Bullshit is strong with this one";
            }
            
        }
    }
}