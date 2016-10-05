using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonApplayObserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click += AngelListener;
            button1.Click += DevilListener;
        }

        private void AngelListener(object sender, EventArgs e)
        {
            Console.WriteLine("Don't do it, you might regret it!");
        }

        private void DevilListener(object sender, EventArgs e)
        {
            Console.WriteLine("Come on, do it!");
        }
    }
}
