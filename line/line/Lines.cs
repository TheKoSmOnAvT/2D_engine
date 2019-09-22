using System;
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
            double b = (x2 - x1) / (x1 * y2 - y1 * x2);
            double a = (y1 - y2) / (x1 * y2 - y1 * x2);
            str = a.ToString() + "X+" + b.ToString() + "Y+1=0";
            return str;
        }

        public void DownBool() //сброс временных переменных при окончании действия мышью
        {
            p1 = false;
            p2 = false;
            p3 = false; 

        }
    }
}


    

    

