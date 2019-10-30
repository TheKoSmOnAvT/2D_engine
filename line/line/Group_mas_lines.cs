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
    class Group_mas_lines : mas_lines
    {
        public List<mas_lines> Mas_group_lines = new List<mas_lines>(); //словарь групп. линий
        public List<string> groups_name = new List<string>(); //имена групп. линий
        Pen GR = new Pen(Color.SeaGreen, 3); //цвет для отрисовки выбранных объектов
        public Stack<int> nums;

        public int view_group = -1;
        
        
        public void add(mas_lines figures) //добавление группы в словарь 
        {
            view_group = -1;
            nums = new Stack<int>();
            List<Lines> mas = new List<Lines>();
            Stack<int>  old_line = figures.check_colore();
            nums = old_line;
            foreach (int i in old_line)
            {
                mas.Add(figures.ln_mas[i]);
            }
                       Mas_group_lines.Add(new mas_lines(mas));
            groups_name.Add("num: "+( groups_name.Count+1));
          
        }
        public new void Draw_Area(PaintEventArgs e)
        {
            if (view_group != -1)
            {
                Mas_group_lines[view_group].Draw_Area(e);
            }
        }

        public void all_green()
        {
            for (int i = 0; i < Mas_group_lines.Count; i++)
            {
                for (int j = 0;j < Mas_group_lines[i].ln_mas.Count; j++)
                {
                    Mas_group_lines[i].ln_mas[j].pen = Mas_group_lines[i].GR;
                }
            }
        }
        public void Search_group(string gr)
        {
            for (int i = 0; i < groups_name.Count; i++)
            {
                if (groups_name[i] == gr)
                {
                    view_group = i;
                    return;
                }
            }
            view_group = -1;
        }
    }
}
