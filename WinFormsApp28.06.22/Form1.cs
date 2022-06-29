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
        Point Start = new Point();
        Point start = new Point();
        Point finish = new Point();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.MouseClick += OnPanel2Clicked;
            void OnPanel2Clicked(object sender, MouseEventArgs args)
            {
                var location = args.Location;
                Start.X = location.X;
                Start.Y = location.Y;
            }
            
        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
              if(radioButtonCircle.Checked)
            { 
                
                Rectangle rectangle = new Rectangle(Start.X,Start.Y,
                    Convert.ToInt32(txtRadius.Text)*2,Convert.ToInt32(txtRadius.Text)*2);
                panel2.CreateGraphics().DrawEllipse(pen, rectangle);
            }
              if(radioButtonEllipse.Checked)
            {
                Rectangle rectangle = new Rectangle(Start.X, Start.Y, Convert.ToInt32(txtLength.Text) ,
                    Convert.ToInt32(txtWidth.Text));
                panel2.CreateGraphics().DrawEllipse(pen, rectangle);
            }
              if(radioButtonRectangle.Checked)
            {
                Rectangle rectangle = new Rectangle(Start.X, Start.Y, Convert.ToInt32(txtLength.Text),
                    Convert.ToInt32(txtWidth.Text));
                panel2.CreateGraphics().DrawRectangle(pen, rectangle);
            }
             if(radioButtonLine.Checked)
            {
                
                Point p2 = new Point(63,98);
                panel2.CreateGraphics().DrawLine(pen,Start,p2);
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
                txtCoordinateX.Enabled = false;
                txtCoordinateY.Enabled = false;
            }
            if (radioButtonEllipse.Checked || radioButtonRectangle.Checked)
            {
                txtLength.Enabled = true;
                txtWidth.Enabled = true;
                txtRadius.Enabled = false;
                txtCoordinateX.Enabled = false;
                txtCoordinateY.Enabled = false;
            }
            if(radioButtonLine.Checked)
            {
                txtLength.Enabled = false;
                txtWidth.Enabled = false;
                txtRadius.Enabled = false;
                txtCoordinateX.Enabled = true;
                txtCoordinateY.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            panel2.CreateGraphics().Clear(Color.White);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

