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
        bool Clicked = false; //нажатие ПКМ
        int NumOfLine = 0; //обработка массива 

        bool p1 = false; //работа с краями или центром линии
        bool p2 = false;
        bool p3 = false;
        
        float dX = 0; //дельта переменные
        float dY = 0;
        float xm = 0;
        float ym = 0;

        Lines ln; //для удобства оформления кода

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
            if (Check_func(e) == -1)//нашло ли линию
            {
                BacktoBlack();
            }
            else
            {
                BacktoBlack();
                ln = ln_mas[NumOfLine];
                if ((e.X >= ln.X1 - 10) && (e.X <= ln.X1 + 10)) //first point
                {
                    if ((e.Y >= ln.Y1 - 10) && (e.Y <= ln.Y1 + 10))
                    {
                        Clicked = true;
                        p1 = true;
                        ln_mas[NumOfLine].pen = GR;
                        dX = e.X - ln.X1;
                        dY = e.Y - ln.Y1;
                    }

                }

                if ((e.X >= ln.X2 -10) && (e.X <= ln.X2 + 10)) //second point
                {
                    if ((e.Y >= ln.Y2 - 10) && (e.Y <= ln.Y2 + 10))
                    {
                        Clicked = true;
                        p2 = true;
                        ln_mas[NumOfLine].pen = GR;
                        dX = e.X - ln.X2;
                        dY = e.Y - ln.Y2;
                    }
                }

                if (e.X >= ((ln.X2 + ln.X1) / 2) - 10 && e.X <= ((ln.X2 + ln.X1) / 2) + 10)//middle point
                {
                    if (e.Y >= ((ln.Y2 + ln.Y1) / 2) - 10 && e.Y <= ((ln.Y2 + ln.Y1) / 2) + 10)
                    {
                        Clicked = true;
                        p3 = true;
                        ln_mas[NumOfLine].pen = GR;
                        xm = (ln.X2 - ln.X1) / 2;
                        ym = (ln.Y2 - ln.Y1) / 2;
                    }
                }
            }

        }

        private void Canvas_Paint(object sender, PaintEventArgs e) //отрисовка линий
        {
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
            if (Clicked && p1) 
            {
                ln.X1 = e.X - dX;
                ln.Y1 = e.Y - dY;
                Canvas.Invalidate();
            }
            if (Clicked && p2)
            {
                ln.X2 = e.X - dX;
                ln.Y2 = e.Y - dY;
                Canvas.Invalidate();
            }
            if (Clicked && p3)
            {
                ln.X1 = e.X - xm;
                ln.Y1 = e.Y - ym;
                              
                ln.X2 = e.X + xm;
                ln.Y2 = e.Y + ym;
                Canvas.Invalidate();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e) //сброс временных переменных при окончании действия мышью
        {
            Clicked = false;
            p1 = false;
            p2 = false;
            p3 = false;
           // ln_mas[NumOfLine].pen = new Pen(Color.Black, 3);
            Canvas.Invalidate();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ln_mas.Add(new Lines(100, 100, 150, 150));
            ln_mas.Add(new Lines(80, 80, 50, 50));
            ln_mas.Add(new Lines(200, 200, 400, 400));
            Canvas.Invalidate();
        }

        private void Del_Line_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ln_mas.Count; i++)
            {
               if(ln_mas[i].pen == GR)
                {
                    ln_mas.RemoveAt(i);
                    Canvas.Invalidate();
                }
            }
        }
    }
}
