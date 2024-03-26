using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        Boolean isTextSet = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            if (isTextSet)
            {
                labelHelloWorld.Text = "";
            } else
            {
                labelHelloWorld.Text = "Hello World";
            }
            isTextSet = !isTextSet;
        }

        private void nxtPageBtn_Click(object sender, EventArgs e)
        {
            Page2 page2 = new Page2();
            this.Hide();
            page2.Show();
        }

        private void userControlFormBtn_Click(object sender, EventArgs e)
        {
            Page3 page3 = new Page3();
            this.Hide();
            page3.Show();
        }
    }
}
