using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsHelloWorld
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void HelloWorld_Load(object sender, EventArgs e)
        {
            // TextBox1.Text = " ";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "- cleared -";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "You pressed the button";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
