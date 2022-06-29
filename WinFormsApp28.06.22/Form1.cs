using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp28._06._22
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush redBrush = new SolidBrush(Color.Red);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
              if(radioButtonCircle.Checked)
            { 
                Pen pen = new Pen(Color.Red, 3);
                Rectangle rectangle = new Rectangle();
                panel2.CreateGraphics().DrawEllipse(pen, rectangle);
            }
              if(radioButtonEllipse.Checked)
            {
                
                Pen pen = new Pen(Color.Red, 3);
                Rectangle rectangle = new Rectangle();
                panel2.CreateGraphics().DrawEllipse(pen, rectangle);
            }
              if(radioButtonRectangle.Checked)
            {
                
                Pen pen = new Pen(Color.Red, 3);
                Rectangle rectangle = new Rectangle();
                panel2.CreateGraphics().DrawRectangle(pen, rectangle);
            }
             if(radioButtonLine.Checked)
            {
                Pen pen = new Pen(Color.Red, 3);
                Point p1 = new Point(1,69);
                Point p2 = new Point(26,98);
                panel2.CreateGraphics().DrawLine(pen,p1,p2);
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (radioButtonCircle.Checked)
            { 
                txtRadius.Enabled = true;
                txtLength.Enabled = false;
                txtWidth.Enabled = false;
            }
            if (radioButtonEllipse.Checked || radioButtonRectangle.Checked)
            {
                txtLength.Enabled = true;
                txtWidth.Enabled = true;
                txtRadius.Enabled = false;
            }
        }
    }
    }

