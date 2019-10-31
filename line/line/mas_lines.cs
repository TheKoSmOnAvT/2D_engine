using System;
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
    [Serializable]
    public class mas_lines : Lines
    {
        public bool area = false;
        Random rnd = new Random();

        public bool Clicked = false; //нажатие ПКМ
        public bool ctr = false; //нажат ctrl
        public int NumOfLine = -1; //обработка массива 

        public List<Lines> ln_mas = new List<Lines>(); //словарь координат линий
        int count = 0;
        protected Pen GR = new Pen(Color.SeaGreen, 3); //цвет для отрисовки выбранных объектов
        SolidBrush redBrush = new SolidBrush(Color.Red); //станд. рисовки закрашенной окружности (цвет)

        public mas_lines(List<Lines> new_mas)
        {
            for(int i=0;i< new_mas.Count; i++)
            {
                ln_mas.Add(new_mas[i]);
            }
           // ln_mas = new_mas;
        }
        public mas_lines()
        {
        }
        public void remove_mas(Stack<int> gr_mas)
        {
            foreach (int i in gr_mas)
            {
                ln_mas.RemoveAt(i);
            }
            NumOfLine = -1;
        }

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
                ln_mas[i].Pen_black();
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
                        e.Graphics.DrawString("X", new Font("Arial", 20), new SolidBrush(Color.Black), 450, 410, new StringFormat());
                        e.Graphics.DrawString("Y", new Font("Arial", 20), new SolidBrush(Color.Black), 410, 450, new StringFormat());

                        e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, i * 100, 2000, i * 100);
                        e.Graphics.DrawLine(new Pen(Color.Black, 3), i * 100, 0, i * 100, 2000);
                        e.Graphics.FillEllipse(redBrush, 400, 400, 5, 5);
                    }
                }
            }
            for (int i = 0; i < ln_mas.Count; i++)
            {
                e.Graphics.DrawLine(ln_mas[i].what_pen(), ln_mas[i].X1, ln_mas[i].Y1, ln_mas[i].X2, ln_mas[i].Y2);
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
                if (ln_mas[i].what_pen() == GR)
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

        public string toString_xyz1()
        {
            if (NumOfLine != -1)
            {
                return ln_mas[NumOfLine].xyz1();
            }
            else
            {
                return "";
            }
        }
        public string toString_xyz2()
        {
            if (NumOfLine != -1)
            {
                return ln_mas[NumOfLine].xyz2();
            }
            else
            {
                return "";
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



        public void Button_move_Click(object sender, EventArgs e, string sx, string sy , string sz)
        {
            if (NumOfLine != -1)
            {
                Stack<int> nums = check_colore();
                foreach (int i in nums)
                {
                    float x = 0;
                    float y = 0;
                    float z = 0;
                    try { x = (float)Convert.ToDouble(sx) * 100; }
                    catch { x = 0; }
                    try { y = (float)Convert.ToDouble(sy) * 100; }
                    catch { y = 0; }
                    try { z = (float)Convert.ToDouble(sz) * 100; }
                    catch { z = 0; }
                    ln_mas[i].Button_move(x, y,z);//линия
                }
            }
        }
        public void Button_rotate_Click(object sender, EventArgs e, string text_x, string text_y, string text_z) 
        {
            if (NumOfLine != -1)
            {
                Stack<int> nums = check_colore();
                foreach (int i in nums)
                {
                    float x = 0;
                    float y = 0;
                    float z = 0;
                    try { x = (float)Convert.ToDouble(text_x); }
                    catch { x = 0; }
                    try { y = (float)Convert.ToDouble(text_y); }
                    catch { y = 0; }
                    try { z = (float)Convert.ToDouble(text_z); }
                    catch { z = 0; }
                    ln_mas[i].Button_rotate(x,y,z);//линия
                }
            }
        }


        public void Button_fscale_Click(object sender, EventArgs e, string textBox_fscale)
        {
            if (NumOfLine != -1)
            {
                Stack<int> nums = check_colore();
                foreach (int i in nums)
                {
                    float q = 1;
                    try { q = (float)Convert.ToDouble(textBox_fscale); }
                    catch { q = 1; }
                    ln_mas[i].Button_fscale(q);//линия
                }
            }
        }


        public void Button_scale_Click(object sender, EventArgs e, string text_scale_x, string text_scale_y, string text_scale_z)
        {
            if (NumOfLine != -1)
            {
                Stack<int> nums = check_colore();
                foreach (int i in nums)
                {
                    float q1 = 1;
                    float q2 = 1;
                    float q3 = 1;
                    try { q1 = (float)Convert.ToDouble(text_scale_x); }
                    catch { q1 = 1; }
                    try { q2 = (float)Convert.ToDouble(text_scale_y); }
                    catch { q2 = 1; }
                    try { q3 = (float)Convert.ToDouble(text_scale_z); }
                    catch { q3 = 1; }
                    ln_mas[i].Button_fscale_xy(q1, q2,q3);//линия
                }
            }
        }

        public void Button_poject_Click(object sender, EventArgs e, string text_project_p, string text_project_q) 
        {
            if (NumOfLine != -1)
            {
                Stack<int> nums = check_colore();
                foreach (int i in nums)
                {
                    float p = 0;
                    float q = 0;
                    try { p = (float)Convert.ToDouble(text_project_p); }
                    catch { p = 0; }
                    try { q = (float)Convert.ToDouble(text_project_q); }
                    catch { q = 0; }
                    ln_mas[i].Button_proj(p, q);//линия
                }
            }
        }

        public void Button_mirror_Click(object sender, EventArgs e)
        {
            if (NumOfLine != -1)
            {
                Stack<int> nums = check_colore();
                foreach (int i in nums)
                {
                    ln_mas[i].Button_Mirror();//линия
                }
            }
        }
    }
}
