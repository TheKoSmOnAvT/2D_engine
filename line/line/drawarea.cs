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
        Random rnd = new Random();
        bool Clicked = false; //нажатие ПКМ
        bool ctr = false; //нажат ctrl
        int NumOfLine = -1; //обработка массива 

           
        List<Lines> ln_mas = new List<Lines>(); //словарь координат линий
        Pen GR = new Pen(Color.SeaGreen, 3); //цвет для отрисовки выбранных объектов
        SolidBrush redBrush = new SolidBrush(Color.Red); //станд. рисовки закрашенной окружности (цвет)

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


        public int Check_func(MouseEventArgs e) //обход массива с точками для поиска и обработки нужной iй линии
        {
            for(int i=0;i<ln_mas.Count;i++)
            {
                if((e.X >= ln_mas[i].X1 && e.X <= ln_mas[i].X2) || (e.X >= ln_mas[i].X2-10 && e.X <= ln_mas[i].X1+10)) //+- от  Х
                {
                    if ((e.Y >= ln_mas[i].Y1 && e.Y <= ln_mas[i].Y2) || (e.Y >= ln_mas[i].Y2-10 && e.Y <= ln_mas[i].Y1+10))  //+- от  Y
                    {
                        NumOfLine = i;
                        return i;
                    }
                }
            }
            return -1;
        }

        public void BacktoBlack()
        {
            for (int i = 0; i < ln_mas.Count; i++)
            {
                ln_mas[i].pen = new Pen(Color.Black, 3);
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (ctr == true && Check_func(e) != -1)
            {
                    ln_mas[NumOfLine].Mouse_Down(e, GR);
            }
            else
            {
                if (Check_func(e) == -1)//нашло ли линию
                {
                    BacktoBlack();
                }
                else
                {
                    BacktoBlack();
                    if (ln_mas[NumOfLine].Mouse_Down(e, GR))
                    {
                        Clicked = true;
                        LineofEq.Text = ln_mas[NumOfLine].equation();
                    }
                }
            }

        }

        private void Canvas_Paint(object sender, PaintEventArgs e) //отрисовка линий
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawString("Y", new Font("Arial", 20), new SolidBrush(Color.Black), 10, 480, new StringFormat());
            e.Graphics.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), 480, 10, new StringFormat());
            e.Graphics.DrawLine(new Pen(Color.Black, 8), 0,0,0, 500);
            e.Graphics.DrawLine(new Pen(Color.Black, 8), 0, 0, 500, 0);

            e.Graphics.DrawLine(new Pen(Color.Black, 5), 0, 100, 10, 100);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 0, 200, 10, 200);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 0, 300, 10, 300);

            e.Graphics.DrawLine(new Pen(Color.Black, 5), 100, 0, 100, 10);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 200, 0, 200, 10);
            e.Graphics.DrawLine(new Pen(Color.Black, 5), 300, 0, 300, 10);

            for (int i = 0; i < ln_mas.Count; i++)
            {
                e.Graphics.DrawLine(ln_mas[i].pen, ln_mas[i].X1, ln_mas[i].Y1, ln_mas[i].X2, ln_mas[i].Y2);
                e.Graphics.FillEllipse(redBrush, ln_mas[i].X1, ln_mas[i].Y1, 7, 7);
                e.Graphics.FillEllipse(redBrush, (ln_mas[i].X2 + ln_mas[i].X1) / 2, (ln_mas[i].Y2 + ln_mas[i].Y1) / 2, 7, 7);
                e.Graphics.FillEllipse(redBrush, ln_mas[i].X2, ln_mas[i].Y2, 7, 7);
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e) //обновление координат линий
        {
            if (Clicked && (ln_mas[NumOfLine].p1 || ln_mas[NumOfLine].p2 || ln_mas[NumOfLine].p3)) 
            {
                ln_mas[NumOfLine].Mouse_Move(e);
                LineofEq.Text = ln_mas[NumOfLine].equation();
                Canvas.Invalidate();
            }
            
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) //сброс временных переменных при окончании действия мышью
        {
            Clicked = false;
            if (NumOfLine != -1)
            {
                ln_mas[NumOfLine].DownBool();//линия
            }
            Canvas.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ln_mas.Add(new Lines(rnd.Next(50, 300), rnd.Next(80, 350), rnd.Next(50, 400), rnd.Next(10, 200)));
            Canvas.Invalidate();
        }


        public Stack<int> check_colore() //проверка наличия фокуса
        {
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < ln_mas.Count; i++)
            {
                if (ln_mas[i].pen == GR)
                {
                    nums.Push(i);
                }
            }
            return nums;
        }
        public void del_lines() //удаление линий
        {
            Stack<int> nums = check_colore();
            foreach(int i in nums)
            {
                ln_mas.RemoveAt(i);
                Canvas.Invalidate();
            }
            NumOfLine = -1;
            //while (check_colore())
            //{
            //    NumOfLine = -1;
            //    for (int i = 0; i < ln_mas.Count; i++)
            //    {
            //        if (ln_mas[i].pen == GR)
            //        {
            //            ln_mas.RemoveAt(i);
            //            Canvas.Invalidate();
            //            i = 0;
            //        }
            //    }
            //}
        }

        private void Del_Line_Click(object sender, EventArgs e)
        {
            del_lines();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Drawarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                ctr = true;
            }
        }

        private void Drawarea_KeyUp(object sender, KeyEventArgs e)
        {
                ctr = false;
        }
    }
}
