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
        Point finish = new Point();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        /// <summary>
        /// определяем стартовую позицию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            var location = e.Location;
            Start.X = location.X;
            Start.Y = location.Y;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// делаем выбор фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 3);
              if(radioButtonCircle.Checked&&txtRadius.Text!=null)
            {
                try {Rectangle rectangle = new Rectangle(Start.X,Start.Y,
                    Convert.ToInt32(txtRadius.Text)*2,Convert.ToInt32(txtRadius.Text)*2);
                panel2.CreateGraphics().DrawEllipse(pen, rectangle); }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
              if(radioButtonEllipse.Checked&& txtLength.Text!=null&& txtWidth.Text!=null)
            {
                try
                { 
                Rectangle rectangle = new Rectangle(Start.X, Start.Y, Convert.ToInt32(txtLength.Text) ,
                    Convert.ToInt32(txtWidth.Text));
                panel2.CreateGraphics().DrawEllipse(pen, rectangle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
              if(radioButtonRectangle.Checked && txtLength.Text != null && txtWidth.Text != null)
            {
                try
                {
                  Rectangle rectangle = new Rectangle(Start.X, Start.Y, Convert.ToInt32(txtLength.Text),
                        Convert.ToInt32(txtWidth.Text));
                        panel2.CreateGraphics().DrawRectangle(pen, rectangle);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
             if(radioButtonLine.Checked && txtCoordinateX.Text != null && txtCoordinateY.Text != null)
            {
                try
                {
                    finish.X = Convert.ToInt32(txtCoordinateX.Text);
                    finish.Y = Convert.ToInt32(txtCoordinateY.Text);
                    panel2.CreateGraphics().DrawLine(pen, Start, finish);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //else
            //{
            //    MessageBox.Show("Задайте параметры!");
            //}
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
        /// <summary>
        /// контроль доступности текстбокса в зависимости от выбранной фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// очищение панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            panel2.CreateGraphics().Clear(Color.White);
        }
        /// <summary>
        /// выход из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

