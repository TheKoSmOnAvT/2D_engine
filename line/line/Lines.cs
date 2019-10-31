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
        private float z1;
        private float z2;

        public bool sys_coord = false; //false-global, true-local
        public bool p1 = false; //работа с краями или центром линии
        public bool p2 = false;
        public bool p3 = false;

        public Pen pen = new Pen(Color.Black, 3);

        public float dX = 0; //дельта переменные
        public float dY = 0;
        public float xm = 0;
        public float ym = 0;

        public float[,] matrix_line = {
            {0,0,0,0 },
            {0,0,0,0},
            {0,0,0,0 },
            {0,0,0,0 }
            };
        public float[,] matrix_rotate_x = {
            {0,0,0,0 },
            {0,0,0,0},
            {0,0,0,0 },
            {0,0,0,0 }
            };
        public float[,] matrix_rotate_y = {
            {0,0,0,0 },
            {0,0,0,0},
            {0,0,0,0 },
            {0,0,0,0 }
            };
        public float[,] matrix_rotate_z = {
            {0,0,0,0 },
            {0,0,0,0},
            {0,0,0,0 },
            {0,0,0,0 }
            };
        public float[,] matrix_mirror = {
            {-1,0,0,0 },
            {0,-1,0,0},
            {0,0,1,0 },
            {0,0,0,1 }
            };
        public float[,] matrix_proj_q = {
            {1,0,0,0 },
            {0,1,0,0 },
            {0,0,1,0 },
            {0,0,0,1 }
            };
        public float[,] matrix_proj_p = {
            {1,0,0,0 },
            {0,1,0,0 },
            {0,0,0,0 },
            {0,0,0,1 }
            };
        public float[,] matrix_move = {
            {1,0,0,0 },
            {0,1,0,0},
            {0,0,1,0 },
            {0,0,0,1 }
            };
        public void form_matrix()
        {
            matrix_line[0, 0] = x1;
            matrix_line[1, 0] = x2;

            matrix_line[0, 2] = z1;
            matrix_line[1, 2] = z2;

            matrix_line[0, 1] = y1;
            matrix_line[1, 1] = y2;
            matrix_line[0, 3] = matrix_line[1, 3] = matrix_line[3, 3] = 1;
        }

        public void form_matrix_rotate_x(float a)
        {
            matrix_rotate_x[0, 0] = 1;
            matrix_rotate_x[1, 1] = (float)Math.Cos(a);
            matrix_rotate_x[1, 2] = (float)Math.Sin(a);
            matrix_rotate_x[2, 1] = (-1) * (float)Math.Sin(a);
            matrix_rotate_x[2, 2] = (float)Math.Cos(a);           
            matrix_rotate_x[3, 3] = 1;
        }

        public void form_matrix_rotate_y(float a)
        {
            matrix_rotate_y[0, 0] = (float)Math.Cos(a);
            matrix_rotate_y[0, 2] = (-1) * (float)Math.Sin(a);
            matrix_rotate_y[1, 1] = 1;
            matrix_rotate_y[2, 0] = (float)Math.Sin(a);
            matrix_rotate_y[2, 2] = (float)Math.Cos(a);
            matrix_rotate_y[3, 3] = 1;
        }

        public void form_matrix_rotate_z(float a)
        {
            matrix_rotate_z[0, 0] = (float)Math.Cos(a);
            matrix_rotate_z[1, 0] = (-1) * (float)Math.Sin(a);
            matrix_rotate_z[2, 2] = 1;
            matrix_rotate_z[0, 1] = (float)Math.Sin(a);
            matrix_rotate_z[1, 1] = (float)Math.Cos(a);
            matrix_rotate_z[3, 3] = 1;
        }

        public void check_oc() //проверка О.К.
        {
            for(int i = 0; i < 4; i++)
            {
                if(matrix_line[i,3] !=1 && matrix_line[i,3] != 0)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrix_line[i, j] = matrix_line[i, j] / matrix_line[i, 3];
                        matrix_line[i, 3] = 1;
                    }
                }
            }
        }
        public void update_loc_form_matrix() //обновление координат
        {
            check_oc();
            x1 = matrix_line[0, 0] ;
            x2 = matrix_line[1, 0] ;
            z1 = matrix_line[0, 2] ;
            z2 = matrix_line[1, 2] ;
            y1 = matrix_line[0, 1] ;
            y2 = matrix_line[1, 1] ;
        }

        public Lines()
        {
            z1 = z2 = x1 = y1 = x2 = y2 = 0;
        }
        public Lines(float X, float Y, float XX, float YY)
        {
            X1 = X;
            Y1 = Y;
            X2 = XX;
            Y2 = YY;
        }

        public Lines(float X, float Y, float Z, float XX, float YY, float ZZ)
        {
            X1 = X;
            Y1 = Y;
            X2 = XX;
            Y2 = YY;
            Z1 = Z;
            Z2 = ZZ;
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
        public float Z1
        {
            set
            {
                z1 = value;
            }
            get { return z1; }
        }
        public float Z2
        {
            set
            {
                z2 = value;
            }
            get { return z2; }

        }

        public string xyz1()
        {
            unddraw();
            string st = "( " + X1 / 100 + " : " + Y1 / 100 + " : " + Z1 / 100 + ") ";
            todraw();
            return st;
        }
        public string xyz2()
        {
            unddraw();
            string st = "( " + X2 / 100 + " : " + Y2 / 100 + " : " + Z2 / 100 + ") ";
            todraw();
            return st;
        }
        public string equation()
        {
            string str = null;
            double c = Math.Round(x1 * y2 - y1 * x2,1);
            if ((c <=0.1 && c>=-0.1) /*&& Math.Round((x2 - x1), 1)== Math.Round((y1 - y2), 1)*/)
            {
                double b1 = Math.Round((x2 - x1), 4) /100;
                double a1 = Math.Round((y1 - y2), 4) /100;
                str = a1.ToString() + "X+(" + b1.ToString() + ")Y+0=0";
                return str;
            }
            double b = Math.Round((x2 - x1) / (c), 4) * 100;
            double a = Math.Round((y1 - y2) / (c), 4) * 100;
            str = a.ToString() + "X+(" + b.ToString() + ")Y+1=0";
            return str;
        }

        public void todraw()
        {
            x1+=400;
            y1+=400;
            x2+=400;
            y2+=400;
            z1+=400;
            z2 += 400;
        }
        public void unddraw()
        {
            x1 -= 400;
            y1 -= 400;
            x2 -= 400;
            y2 -= 400;
            z1 -= 400;
            z2 -= 400;
        }

        public void DownBool() //сброс временных переменных при окончании действия мышью
        {
            p1 = false;
            p2 = false;
            p3 = false; 
        }


        public bool Mouse_Down(MouseEventArgs e, Pen GR) //проверка точки на линии (first, middle, second)
        {
           
            if ((e.X >= ((X2 + X1) / 2) - 10 && e.X  <= ((X2 + X1) / 2) + 10) || ((e.X <= ((X2 + X1) / 2) - 10 && e.X >= ((X2 + X1) / 2) + 10))) //middle point
            {
                if (e.Y  >= ((Y2 + Y1) / 2) - 10 && e.Y  <= ((Y2 + Y1) / 2) + 10)
                {

                    p3 = true;
                    pen = GR;
                    xm = (X2 - X1) / 2;
                    ym = (Y2 - Y1) / 2;
                    return true;
                }
            }
            if ((e.X >= X1 - 10) && (e.X <= X1 +10)) //first point
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


        public void Button_move(float x, float y, float z)
        {
            unddraw();
            float z1 = 1 + z;
            //if (z == 0){ z1 = 1; }
            form_matrix();
            matrix_move[3,0]= x;
            matrix_move[3,1] =y;
            matrix_move[3, 2] = z;
           
            matrix_line = Matrix(matrix_line, matrix_move);
            update_loc_form_matrix();
            todraw();
        }
        public void change_or_z()
        {
            if (z1 == 0 )
            {
                return;
            }
            if (z2 == 0)
            {
               return;
            }
            //Console.WriteLine(z1.ToString() + " " + x1.ToString() + " " + y1.ToString() + " " + z2.ToString() + " " + x2.ToString() + " " + y2.ToString());
            X1 = z1 * X1;
            Y1 = z1 * Y1;

            X2 = z2 * X2;
            Y2 = z2 * Y2;
        }
        public void Button_rotate(double x, double y, double z)
        {
            unddraw();
            x = x / 100;
            y = y / 100;
            z = z / 100;
            form_matrix();
            form_matrix_rotate_x((float)x);
            form_matrix_rotate_y((float)y);
            form_matrix_rotate_z((float)z);
            matrix_line = Matrix(matrix_line, matrix_rotate_x);
            matrix_line = Matrix(matrix_line, matrix_rotate_y);
            matrix_line = Matrix(matrix_line, matrix_rotate_z);
            update_loc_form_matrix();
            todraw();
        }

        public void Button_fscale(float q)
        {
            unddraw();
            X1 = q * X1;
            Y1 = q * Y1;
            Z1 = q * Z1;
            Z2 = q * Z2;
            X2 = q * X2;
            Y2 = q * Y2;
            todraw();
        }
        public void Button_fscale_xy(float q1,float q2, float q3)
        {
            unddraw();
            X1 = q1 * X1;
            Y1 = q2 * Y1;
            Z1 = q3 * Z1;
            Z2 = q3 * Z2;

            X2 = q1 * X2;
            Y2 = q2 * Y2;
            todraw();
        }
        public void Button_proj(float p, float q)//q работает криво 
        {
            unddraw();
            matrix_proj_p[0, 3] = (1 / p)*(-1);
           

            form_matrix();
            if (p != 0)
            {
               matrix_line = Matrix(matrix_line, matrix_proj_p);
            }
            if (p != 0 && q != 0)
            {
                matrix_proj_p[1, 3] = (1 / q) * (-1);
                matrix_line = Matrix(matrix_line, matrix_proj_p);
            }
            update_loc_form_matrix();
            todraw();
        }
        public void Button_Mirror() 
        {
            unddraw();
            form_matrix();
            matrix_line = Matrix(matrix_line, matrix_mirror);
            update_loc_form_matrix();
            todraw();
        }

        public float[,] Matrix(float[,] a, float[,] b)
        {
            float[,] new_mas = new float[4, 4];
            float sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    sum = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        sum = sum + (a[i, j] * b[j, k]);
                    }
                    new_mas[i, k] = sum;
                }
            }
            return new_mas;
        }

    }
}


    

    

