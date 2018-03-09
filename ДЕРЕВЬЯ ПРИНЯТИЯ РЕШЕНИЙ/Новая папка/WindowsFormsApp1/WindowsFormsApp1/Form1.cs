using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int k = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void rez()
        {
            String v = textBox1.Text;
            int ver = Int32.Parse(v);

            while (k < ver) {
                k++;
                WindowsFormsApp2 form2 = new WindowsFormsApp2();
                TextBox tb2 = new TextBox();
                form2.add
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    internal class WindowsFormsApp2
    {
    }
}
