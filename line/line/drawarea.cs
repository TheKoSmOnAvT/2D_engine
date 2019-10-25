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
        /// <summary>
        /// ///////
        /// </summary>
        //bool area = false;
        //Random rnd = new Random();
        //bool Clicked = false; //нажатие ПКМ
        //bool ctr = false; //нажат ctrl
        //int NumOfLine = -1; //обработка массива            
        //List<Lines> ln_mas = new List<Lines>(); //словарь координат линий
        //int count = 0;
        //Pen GR = new Pen(Color.SeaGreen, 3); //цвет для отрисовки выбранных объектов
        //SolidBrush redBrush = new SolidBrush(Color.Red); //станд. рисовки закрашенной окружности (цвет)

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


        //public int Check_func(MouseEventArgs e) //обход массива с точками для поиска и обработки нужной iй линии
        //{
        //    count = ln_mas.Count-1;
        //    for (int i=0;i<ln_mas.Count;i++)
        //    {
        //        if((e.X >= ln_mas[i].X1-2 && e.X <= ln_mas[i].X2+2) || (e.X >= ln_mas[i].X2-2 && e.X <= ln_mas[i].X1+2)) //+- от  Х
        //        {
        //            if ((e.Y >= ln_mas[i].Y1-2 && e.Y <= ln_mas[i].Y2+2) || (e.Y >= ln_mas[i].Y2-2 && e.Y <= ln_mas[i].Y1+2))  //+- от  Y
        //            {
        //                Lines exmpl = ln_mas[i];
        //                ln_mas.Remove(exmpl);
        //                ln_mas.Insert(count, exmpl);
        //                NumOfLine = i;
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}

        //public void BacktoBlack()
        //{
        //    for (int i = 0; i < ln_mas.Count; i++)
        //    {
        //        ln_mas[i].pen = new Pen(Color.Black, 3);
        //    }
        //}

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //if (ctr == true && Check_func(e) != -1)
            //{
            //        ln_mas[NumOfLine].Mouse_Down(e, GR);

            //}
            //else
            //{
            //    if (Check_func(e) == -1)//нашло ли линию
            //    {
            //        BacktoBlack();
            //    }
            //    else
            //    {
            //        BacktoBlack();

            //        ln_mas[NumOfLine].Mouse_Down(e, GR);
            //        Clicked = true;
            //        LineofEq.Text = ln_mas[NumOfLine].equation();
            //    }
            //}
            figures.Canvas_MouseDown(sender, e);
            LineofEq.Text = figures.toString();
        }

        //public void Draw_Area(PaintEventArgs e) //отрисовка поля
        //{
        //    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        //    if(area ==true)
        //    {
        //        for(int i=0;i<30;i++)
        //        {
        //            e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, i*100, 2000, i*100);
        //            e.Graphics.DrawLine(new Pen(Color.Black, 1),  i * 100, 0, i * 100, 2000);
        //            if (i == 4)
        //            {
        //                e.Graphics.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), 450, 400, new StringFormat());
        //                e.Graphics.DrawString("Y", new Font("Arial", 20), new SolidBrush(Color.Black), 420, 50, new StringFormat());

        //                e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, i * 100, 2000, i * 100);
        //                e.Graphics.DrawLine(new Pen(Color.Black, 3), i * 100, 0, i * 100, 2000);
        //            }
        //        }
        //    }

        //}


        private void Canvas_Paint(object sender, PaintEventArgs e) //отрисовка линий
        {
            figures.Draw_Area(e);
            //for (int i = 0; i < ln_mas.Count; i++)
            //{
            //    e.Graphics.DrawLine(ln_mas[i].pen, ln_mas[i].X1, ln_mas[i].Y1, ln_mas[i].X2, ln_mas[i].Y2);
            //    e.Graphics.FillEllipse(redBrush, ln_mas[i].X1, ln_mas[i].Y1, 5, 5);
            //    e.Graphics.FillEllipse(redBrush, (ln_mas[i].X2 + ln_mas[i].X1) / 2, (ln_mas[i].Y2 + ln_mas[i].Y1) / 2, 5, 5);
            //    e.Graphics.FillEllipse(redBrush, ln_mas[i].X2, ln_mas[i].Y2, 5, 5);
            //}
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) //обновление координат линий
        {

            figures.Canvas_MouseMove(sender, e);
            LineofEq.Text = figures.toString();
            Canvas.Invalidate();
            //if (Clicked && (ln_mas[NumOfLine].p1 || ln_mas[NumOfLine].p2 || ln_mas[NumOfLine].p3)) 
            //{
            //    ln_mas[NumOfLine].Mouse_Move(e);
            //    LineofEq.Text = ln_mas[NumOfLine].equation();
            //    Canvas.Invalidate();
            //}

        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) //сброс временных переменных при окончании действия мышью
        {
            //figures.Clicked = false;
            //if (figures.NumOfLine != -1)
            //{
            //    figures.ln_mas[figures.NumOfLine].DownBool();//линия
            //    Canvas.Invalidate();
            //}
            figures.Canvas_MouseUp(sender,e);
            Canvas.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //ln_mas.Add(new Lines(rnd.Next(50, 300), rnd.Next(80, 350), rnd.Next(50, 400), rnd.Next(10, 200)));
            figures.Add();
            Canvas.Invalidate();
        }


        //public Stack<int> check_colore() //проверка наличия фокуса
        //{
        //    Stack<int> nums = new Stack<int>();
        //    for (int i = 0; i < ln_mas.Count; i++)
        //    {
        //        if (ln_mas[i].pen == GR)
        //        {
        //            nums.Push(i);
        //        }
        //    }
        //    return nums;
        //}
        //public void del_lines() //удаление линий
        //{
        //    Stack<int> nums = check_colore();
        //    foreach(int i in nums)
        //    {
        //        ln_mas.RemoveAt(i);
        //        Canvas.Invalidate();
        //    }
        //    NumOfLine = -1;
           
        //}

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
                //Stack<int> nums = figures.check_colore();
                //foreach (int i in nums)
                //{
                //    float x = 0;
                //    float y = 0;
                //   try { x = (float)Convert.ToDouble(text_move_x.Text) * 100; }
                //    catch { x = 0; }
                //   try { y = (float)Convert.ToDouble(text_move_y.Text) * 100; }
                //    catch { y = 0; }
                //    figures.ln_mas[i].Button_move(x, y);//линия
                figures.Button_move_Click(sender,e, text_move_x.Text, text_move_y.Text);
                LineofEq.Text = figures.toString();
                Canvas.Invalidate();
            }
           
        }

        private void Button_rotate_Click(object sender, EventArgs e) //доделать
        {
            if (figures.NumOfLine != -1)
            {
                //Stack<int> nums = figures.check_colore();
                //foreach (int i in nums)
                //{
                //    float q = 0;
                //    try { q = (float)Convert.ToDouble(text_rotate.Text); }
                //    catch { q = 0; }
                //    figures.ln_mas[i].Button_rotate(q);//линия
                figures.Button_rotate_Click(sender,e, text_rotate.Text);
                LineofEq.Text = figures.toString();
                Canvas.Invalidate();
            }
            
        }

        private void Button_fscale_Click(object sender, EventArgs e)
        {
            if (figures.NumOfLine != -1)
            {
                //    Stack<int> nums = figures.check_colore();
                //    foreach (int i in nums)
                //    {
                //        float q = 1;
                //        try { q = (float)Convert.ToDouble(textBox_fscale.Text); }
                //        catch { q = 1; }
                //        figures.ln_mas[i].Button_fscale(q);//линия
                figures.Button_fscale_Click(sender,e, textBox_fscale.Text);
                LineofEq.Text = figures.toString();
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
                //Stack<int> nums = figures.check_colore();
                //foreach (int i in nums)
                //{
                //    float q1 = 1;
                //    float q2 = 1;
                //    try { q1 = (float)Convert.ToDouble(text_scale_x.Text); }
                //    catch { q1 = 1; }
                //    try { q2 = (float)Convert.ToDouble(text_scale_y.Text); }
                //    catch { q2 = 1; }
                //    figures.ln_mas[i].Button_fscale_xy(q1, q2);//линия
                figures.Button_scale_Click(sender,e, text_scale_x.Text, text_scale_y.Text);
                LineofEq.Text = figures.toString();
                Canvas.Invalidate();
            } 
        }

        private void Button_poject_Click(object sender, EventArgs e) //???
        {
            if (figures.NumOfLine != -1)
            {
                //Stack<int> nums = figures.check_colore();
                //foreach (int i in nums)
                //{
                //    float p = 0;
                //    float q = 0;
                //    try { p = (float)Convert.ToDouble(text_project_p.Text); }
                //    catch { p = 0; }
                //    try { q = (float)Convert.ToDouble(text_project_q.Text); }
                //    catch { q = 0; }
                //    figures.ln_mas[i].Button_proj(p, q);//линия
                figures.Button_poject_Click(sender, e , text_project_p.Text, text_project_q.Text);
                LineofEq.Text = figures.toString();
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
                //Stack<int> nums = figures.check_colore();
                //foreach (int i in nums)
                //{
                //    figures.ln_mas[i].Button_Mirror();//линия
                //    LineofEq.Text = figures.ln_mas[i].equation();
                //}
                figures.Button_mirror_Click(sender,e);
                LineofEq.Text = figures.toString();
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
    }
}
