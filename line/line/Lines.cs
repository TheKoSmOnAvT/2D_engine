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

        public Lines()
        {
            x1 = y1 = x2 = y2 = 0;
        }
        public Lines(float X,float Y, float XX, float YY)
        {
            X1= X;
            Y1= Y;
            X2= XX;
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
            get {return y2; }
            
        }


    }
}


    

    

