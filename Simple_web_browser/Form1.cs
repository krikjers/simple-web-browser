using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_web_browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //to create these functions below: select button in Form1.cs [design] and select events tab (a lightning) and double click on an event

        /// <summary>
        /// When button1 is clicked, run this code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("A button was clicked\r\n");        // \r\n Used as a new line character in Windows
        }


        /// <summary>
        /// run this code when mouse is inside button1 perimeter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.AppendText("the mouse has entered the button\r\n");
        }

        /// <summary>
        /// run code when the mouse leaves the button perimeter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.AppendText("the mouse leaves the button\r\n");
        }
    }
}
