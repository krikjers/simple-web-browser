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

        /// <summary>
        /// exits program when exit in menu bar clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simple web browser based on .NET framework.\n by Kristian, 2017");
        }

        /// <summary>
        /// go to url from textbox
        /// </summary>
        private void NavigateToPageFromTextbox()
        {
            button1.Enabled = false;         //don't use textbox and button while pag is loading
            textBox1.Enabled = false;
            webBrowser1.Navigate(textBox1.Text);
            toolStripStatusLabel1.Text = " ";

        }

        /// <summary>
        /// navigate button, make web browser goto URL in the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            NavigateToPageFromTextbox();
        }

        /// <summary>
        /// run function evey time "enter" key is pressed and released    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {                
                NavigateToPageFromTextbox();
                // button1_Click(null, null);     simulate button click
            }
        }

        /// <summary>
        /// call when finished loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "page finished loading";
            textBox1.Text = webBrowser1.Url.ToString();
            changeImages();
        }

        /// <summary>
        /// call when bytes of webpages loads 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.MaximumProgress != 0)     //don't divide by 0 
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress / e.MaximumProgress) * 100;     //convert bytes loaded to percentage and display in progress bar
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void changeImages()
        {
            foreach(HtmlElement image in webBrowser1.Document.Images)
            {
                if (image.GetAttribute("src") != "http://evelyngarone.files.wordpress.com/2012/01/little-cat.jpg")
                {
                    image.SetAttribute("src", "http://evelyngarone.files.wordpress.com/2012/01/little-cat.jpg");
                }
                
            }

        }
    }
}   