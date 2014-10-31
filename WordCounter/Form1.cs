using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCounter
{
    public partial class Form1 : Form
    {
        public string[] words;

        public Form1()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            words = File.ReadAllText("c:\\doi.txt").Split(' ');
            StringBuilder sbwords = new StringBuilder();

            foreach (var s in textBox1.Text.Split(','))
            {
                var i = int.Parse(s);
                sbwords.Append(words[i].Substring(0,1));
            }
            textBox2.Text = sbwords.ToString();
        }
    }
}
