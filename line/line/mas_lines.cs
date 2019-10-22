﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace line
{
    class mas_lines : Lines
    {
        public bool area = false;
        Random rnd = new Random();

        public bool Clicked = false; //нажатие ПКМ
        public bool ctr = false; //нажат ctrl
        public int NumOfLine = -1; //обработка массива 

        public List<Lines> ln_mas = new List<Lines>(); //словарь координат линий
        int count = 0;
        Pen GR = new Pen(Color.SeaGreen, 3); //цвет для отрисовки выбранных объектов
        SolidBrush redBrush = new SolidBrush(Color.Red); //станд. рисовки закрашенной окружности (цвет)

        public int Check_func(MouseEventArgs e) //обход массива с точками для поиска и обработки нужной iй линии
        {
            count = ln_mas.Count - 1;
            for (int i = 0; i < ln_mas.Count; i++)
            {
                if ((e.X >= ln_mas[i].X1 - 2 && e.X <= ln_mas[i].X2 + 2) || (e.X >= ln_mas[i].X2 - 2 && e.X <= ln_mas[i].X1 + 2)) //+- от  Х
                {
                    if ((e.Y >= ln_mas[i].Y1 - 2 && e.Y <= ln_mas[i].Y2 + 2) || (e.Y >= ln_mas[i].Y2 - 2 && e.Y <= ln_mas[i].Y1 + 2))  //+- от  Y
                    {
                        Lines exmpl = ln_mas[i];
                        ln_mas.Remove(exmpl);
                        ln_mas.Insert(count, exmpl);
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

        public void Draw_Area(PaintEventArgs e) //отрисовка поля
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            if (area == true)
            {
                for (int i = 0; i < 30; i++)
                {
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), 0, i * 100, 2000, i * 100);
                    e.Graphics.DrawLine(new Pen(Color.Black, 1), i * 100, 0, i * 100, 2000);
                    if (i == 4)
                    {
                        e.Graphics.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), 450, 400, new StringFormat());
                        e.Graphics.DrawString("Y", new Font("Arial", 20), new SolidBrush(Color.Black), 420, 50, new StringFormat());

                        e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, i * 100, 2000, i * 100);
                        e.Graphics.DrawLine(new Pen(Color.Black, 3), i * 100, 0, i * 100, 2000);
                    }
                }
            }
            for (int i = 0; i < ln_mas.Count; i++)
            {
                e.Graphics.DrawLine(ln_mas[i].pen, ln_mas[i].X1, ln_mas[i].Y1, ln_mas[i].X2, ln_mas[i].Y2);
                e.Graphics.FillEllipse(redBrush, ln_mas[i].X1, ln_mas[i].Y1, 5, 5);
                e.Graphics.FillEllipse(redBrush, (ln_mas[i].X2 + ln_mas[i].X1) / 2, (ln_mas[i].Y2 + ln_mas[i].Y1) / 2, 5, 5);
                e.Graphics.FillEllipse(redBrush, ln_mas[i].X2, ln_mas[i].Y2, 5, 5);
            }
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

        public void Canvas_MouseDown(object sender, MouseEventArgs e)
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

                    ln_mas[NumOfLine].Mouse_Down(e, GR);
                    Clicked = true;
                 }
            }
        }
  
        public string toString()
        {
            if (NumOfLine != -1)
            {
                return ln_mas[NumOfLine].equation();
            }
            else
            {
                return "";
            }
        }

        public void Canvas_MouseMove(object sender, MouseEventArgs e) //обновление координат линий
        {
            if (Clicked && (ln_mas[NumOfLine].p1 || ln_mas[NumOfLine].p2 || ln_mas[NumOfLine].p3))
            {
                ln_mas[NumOfLine].Mouse_Move(e);
                //LineofEq.Text = ln_mas[NumOfLine].equation();
                //Canvas.Invalidate();
                
            }

        }

        public void Canvas_MouseUp(object sender, MouseEventArgs e) //сброс временных переменных при окончании действия мышью
        {
            Clicked = false;
            if (NumOfLine != -1)
            {
                ln_mas[NumOfLine].DownBool();//линия
            }
            
        }

        public void Add()
        {
            ln_mas.Add(new Lines(rnd.Next(50, 300), rnd.Next(80, 350), rnd.Next(50, 400), rnd.Next(10, 200)));
        }

        public void del_lines() //удаление линий
        {
            Stack<int> nums = check_colore();
            foreach (int i in nums)
            {
                ln_mas.RemoveAt(i);
            }
            NumOfLine = -1;

        }
        
    }
}
