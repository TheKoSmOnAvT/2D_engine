﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;

namespace line
{
    class Lines
    {
        private float x1;
        private float y1;
        private float x2;
        private float y2;

        public bool p1 = false; //работа с краями или центром линии
        public bool p2 = false;
        public bool p3 = false;

        public Pen pen = new Pen(Color.Black, 3);

        public float dX = 0; //дельта переменные
        public float dY = 0;
        public float xm = 0;
        public float ym = 0;


        public Lines()
        {
            x1 = y1 = x2 = y2 = 0;
            //pen = new Pen(Color.Black, 3);
        }
        public Lines(float X, float Y, float XX, float YY)
        {
            X1 = X;
            Y1 = Y;
            X2 = XX;
            Y2 = YY;
        }

        public float X1
        {
            set
            {
                x1 = value;
            }
            get { return x1; }
        }
        public float X2
        {
            set
            {
                x2 = value;
            }
            get { return x2; }
        }
        public float Y1
        {
            set
            {
                y1 = value;
            }
            get { return y1; }
        }
        public float Y2
        {
            set
            {
                y2 = value;
            }
            get { return y2; }

        }

        public string equation()
        {
            string str = null;
            double b = Math.Round(Math.Abs(x1 - x2) / Math.Abs(x1 * y2 - y1 * x2),3)*1000;
            double a = Math.Round(Math.Abs(y1 - y2) / Math.Abs(x1 * y2 - y1 * x2),3)*1000;
            str = a.ToString() + "X+" + b.ToString() + "Y+1=0";
            return str;
        }

        public void DownBool() //сброс временных переменных при окончании действия мышью
        {
            p1 = false;
            p2 = false;
            p3 = false; 
        }


        public bool Mouse_Down(MouseEventArgs e, Pen GR) //проверка точки на линии (first, middle, second)
        {
            if ((e.X >= X1 - 10) && (e.X <= X1 + 10)) //first point
            {
                if ((e.Y >= Y1 - 10) && (e.Y <= Y1 + 10))
                {
                    p1 = true;
                    pen = GR;
                    dX = e.X - X1;
                    dY = e.Y - Y1;
                    return true;
                }

            }

            if ((e.X >= X2 - 10) && (e.X <= X2 + 10)) //second point
            {
                if ((e.Y >= Y2 - 10) && (e.Y <= Y2 + 10))
                {
                    p2 = true;
                    pen = GR;
                    dX = e.X - X2;
                    dY = e.Y - Y2;
                    return true;
                }
            }

            if (e.X >= ((X2 + X1) / 2) - 10 && e.X <= ((X2 + X1) / 2) + 10)//middle point
            {
                if (e.Y >= ((Y2 + Y1) / 2) - 10 && e.Y <= ((Y2 + Y1) / 2) + 10)
                {
                   
                    p3 = true;
                    pen = GR;
                    xm = (X2 - X1) / 2;
                    ym = (Y2 - Y1) / 2;
                    return true;
                }
            }
            return false;
        }

        public void Mouse_Move(MouseEventArgs e)
        {
            if (p1)
            {
                X1 = e.X - dX;
                Y1 = e.Y - dY;
            }

            if (p2)
            {
                X2 = e.X - dX;
                Y2 = e.Y - dY;
            }
            if (p3)
            {
                X1 = e.X - xm;
                Y1 = e.Y - ym;
                X2 = e.X + xm;
                Y2 = e.Y + ym;
            }
        }

    }
}


    

    

