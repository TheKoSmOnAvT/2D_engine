using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace line
{
    public partial class drawarea : Form
    {

        mas_lines figures = new mas_lines();


        public drawarea()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            figures.Canvas_MouseDown(sender, e);
            LineofEq.Text = figures.toString();
            coords();
        }

        private void Canvas_Paint(object sender, PaintEventArgs e) //отрисовка линий
        {
            figures.Draw_Area(e);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) //обновление координат линий
        {

            figures.Canvas_MouseMove(sender, e);
            LineofEq.Text = figures.toString();
            coords();
            Canvas.Invalidate();
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) //сброс временных переменных при окончании действия мышью
        {
            figures.Canvas_MouseUp(sender,e);
            Canvas.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            figures.Add();
            Canvas.Invalidate();
        }

        private void Del_Line_Click(object sender, EventArgs e)
        {
            figures.del_lines();
            Canvas.Invalidate();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Drawarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                figures.ctr = true;
            }
        }

        private void Drawarea_KeyUp(object sender, KeyEventArgs e)
        {
            figures.ctr = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Text_move_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void Text_move_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_move_Click(object sender, EventArgs e)
        {
            if (figures.NumOfLine != -1)
            {
                figures.Button_move_Click(sender,e, text_move_x.Text, text_move_y.Text, text_move_z.Text);
                LineofEq.Text = figures.toString();
                coords();
                Canvas.Invalidate();
            }
           
        }

        private void Button_rotate_Click(object sender, EventArgs e) //доделать
        {
            if (figures.NumOfLine != -1)
            {
                figures.Button_rotate_Click(sender,e, text_rotate_x.Text, text_rotate_y.Text, text_rotate_z.Text);
                LineofEq.Text = figures.toString();
                coords();
                Canvas.Invalidate();
            }
            
        }

        private void Button_fscale_Click(object sender, EventArgs e)
        {
            if (figures.NumOfLine != -1)
            {
                figures.Button_fscale_Click(sender,e, textBox_fscale.Text);
                LineofEq.Text = figures.toString();
                coords();
                Canvas.Invalidate();
            }
            
           
        }

        private void TextBox_fscale_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_scale_Click(object sender, EventArgs e)
        {
            if (figures.NumOfLine != -1)
            {
                figures.Button_scale_Click(sender,e, text_scale_x.Text, text_scale_y.Text, text_scale_z.Text);
                LineofEq.Text = figures.toString();
                coords();
                Canvas.Invalidate();
            } 
        }

        private void Button_poject_Click(object sender, EventArgs e) 
        {
            if (figures.NumOfLine != -1)
            {
                figures.Button_poject_Click(sender, e , text_project_p.Text, text_project_q.Text);
                LineofEq.Text = figures.toString();
                coords();
                Canvas.Invalidate();
            }
            
            
        }

        private void Text_project_p_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_mirror_Click(object sender, EventArgs e)
        {
            if (figures.NumOfLine != -1)
            {
                figures.Button_mirror_Click(sender,e);
                LineofEq.Text = figures.toString();
                coords();
                Canvas.Invalidate();
            }
           
        }

       private void Button_area_Click(object sender, EventArgs e)
        {
            if(figures.area == false)
            {
                figures.area = true;
                Canvas.Invalidate();
            }
            else
            {
                figures.area = false;
                Canvas.Invalidate();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void text_xyz_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_xyz_2_TextChanged(object sender, EventArgs e)
        {

        }
        private void coords()
        {
            text_xyz.Text = figures.toString_xyz1();
            text_xyz_2.Text = figures.toString_xyz2();
        }
    }
}
