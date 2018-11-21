using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // label1.Text = DateTime.Now.ToString();
            //   label1.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
            // DateTime time = new DateTime();
            label1.Text = DateTime.Now.ToLongTimeString();
           
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if  (e.KeyData == Keys.A && FormBorderStyle == FormBorderStyle.FixedSingle)
            {
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else if(e.KeyData == Keys.A && FormBorderStyle == FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
        }
    }
}
