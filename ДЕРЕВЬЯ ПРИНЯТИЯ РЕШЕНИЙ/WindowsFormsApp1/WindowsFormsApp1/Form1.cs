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

        bool isClicked = false;
        int deltaX ;
        int deltaY  ;
        
        Rectangle rec = new Rectangle(10,10,30,20);

        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        } 
        private class Mouse 
        {
        }

        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(textBox1,true);
            
        } 
       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { 
          //  deltaX = Cursor.Position.X;
         //   deltaY = Cursor.Position.Y;
           // deltaX = 100;
          //  deltaY = 100;

            
        }
       

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //deltaX = e.Location.X;
         //   deltaY = e.Location.X;


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            


        }

       

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            
            deltaX = e.Location.X;
            deltaY = e.Location.Y;
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
           
                
                e.Graphics.DrawEllipse(pen, deltaX, deltaY, 50, 50);

               pictureBox1.Refresh();
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = Cursor.Position.X.ToString();
            label4.Text = Cursor.Position.X.ToString();
        }

       
    }
}
