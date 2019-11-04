using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace line
{
    public partial class Morfing : Form
    {
        Group_mas_lines groups = new Group_mas_lines();
        mas_lines morf = new mas_lines();
        mas_lines first_im = new mas_lines();
        mas_lines second_im = new mas_lines();
        public Morfing(Group_mas_lines group)
        {
            InitializeComponent();
            groups.Clone( group);
            add_comb();
        }

        private void Canvas_Click(object sender, EventArgs e)
        {

        }

        private void add_comb()
        {
            comboBox_t0.Items.Clear();
            comboBox_t1.Items.Clear();
            for (int i = 0; i < groups.groups_name.Count; i++)
            {
                comboBox_t0.Items.Add(groups.groups_name[i]);
                comboBox_t1.Items.Add(groups.groups_name[i]);
            }
        }
        private void View_button_Click(object sender, EventArgs e)
        {
            Canvas_new.Image = null;
            try
            {
                string st1 = comboBox_t0.SelectedItem.ToString();
                groups.Search_group(st1);
                first_im = groups.Mas_group_lines[groups.view_group];
                string st = comboBox_t1.SelectedItem.ToString();
                groups.Search_group(st);
                second_im = groups.Mas_group_lines[groups.view_group];
            }
            catch { }
            Canvas_new.Invalidate();
        }

        private void Canvas_new_Paint(object sender, PaintEventArgs e)
        {
            //figures.Draw_Area(e);
            first_im.Draw_Area(e);
            second_im.Draw_Area(e);
            morf.Draw_Area(e);
        }
        public void tt()
        {
            string st = comboBox_t0.SelectedItem.ToString();
            string st1 = comboBox_t1.SelectedItem.ToString();
            float n = trackBar1.Value;
            float t = n * (float)0.1;
           // double t1 = n ;
            //MessageBox.Show(t.ToString());
            morf.ln_mas.Clear();
            groups.Search_group(st);
            mas_lines mas1 = new mas_lines (groups.Mas_group_lines[groups.view_group]);
            groups.Search_group(st1);
            mas_lines mas2 = new mas_lines (groups.Mas_group_lines[groups.view_group]);
            for (int i=0;i< mas1.ln_mas.Count;i++ )
            {
                float x1 = 0;
                float x2 =0;
                float y1 =0;
                float y2 =0;
                try
                {
                    x1 = mas1.ln_mas[i].X1 * (1 - t) + mas2.ln_mas[i].X1 * t;
                    x2 = mas1.ln_mas[i].X2 * (1 - t) + mas2.ln_mas[i].X2 * t;
                    y1 = mas1.ln_mas[i].Y1 * (1 - t) + mas2.ln_mas[i].Y1 * t;
                    y2 = mas1.ln_mas[i].Y2 * (1 - t) + mas2.ln_mas[i].Y2 * t;

                    //MessageBox.Show(x1 + " "+ x2 + " " +y1 + " " + y2);
                    morf.Add(x1, y1, x2, y2);
                }
                catch { }
               
            }
               
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tt();
            Canvas_new.Invalidate();
        }
    }
}
