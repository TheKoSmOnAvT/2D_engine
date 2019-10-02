namespace line
{
    partial class drawarea
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Del_Line = new System.Windows.Forms.Button();
            this.LineofEq = new System.Windows.Forms.TextBox();
            this.Button_move = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_move_y = new System.Windows.Forms.TextBox();
            this.text_move_x = new System.Windows.Forms.TextBox();
            this.text_rotate = new System.Windows.Forms.TextBox();
            this.button_rotate = new System.Windows.Forms.Button();
            this.text_scale_x = new System.Windows.Forms.TextBox();
            this.text_scale_y = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_scale = new System.Windows.Forms.Button();
            this.textBox_fscale = new System.Windows.Forms.TextBox();
            this.button_fscale = new System.Windows.Forms.Button();
            this.button_mirror = new System.Windows.Forms.Button();
            this.text_project_p = new System.Windows.Forms.TextBox();
            this.text_project_q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_poject = new System.Windows.Forms.Button();
            this.button_area = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Canvas.Location = new System.Drawing.Point(4, 5);
            this.Canvas.Margin = new System.Windows.Forms.Padding(4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(900, 500);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Click += new System.EventHandler(this.PictureBox1_Click);
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(1292, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить линию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Del_Line
            // 
            this.Del_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Del_Line.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Del_Line.Location = new System.Drawing.Point(1284, 107);
            this.Del_Line.Margin = new System.Windows.Forms.Padding(4);
            this.Del_Line.MaximumSize = new System.Drawing.Size(136, 28);
            this.Del_Line.MinimumSize = new System.Drawing.Size(136, 28);
            this.Del_Line.Name = "Del_Line";
            this.Del_Line.Size = new System.Drawing.Size(136, 28);
            this.Del_Line.TabIndex = 2;
            this.Del_Line.Text = "Удалить линию";
            this.Del_Line.UseVisualStyleBackColor = true;
            this.Del_Line.Click += new System.EventHandler(this.Del_Line_Click);
            // 
            // LineofEq
            // 
            this.LineofEq.AcceptsTab = true;
            this.LineofEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineofEq.Location = new System.Drawing.Point(1260, 164);
            this.LineofEq.Margin = new System.Windows.Forms.Padding(4);
            this.LineofEq.Name = "LineofEq";
            this.LineofEq.ReadOnly = true;
            this.LineofEq.Size = new System.Drawing.Size(181, 22);
            this.LineofEq.TabIndex = 3;
            this.LineofEq.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Button_move
            // 
            this.Button_move.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_move.Location = new System.Drawing.Point(1260, 225);
            this.Button_move.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_move.MaximumSize = new System.Drawing.Size(65, 31);
            this.Button_move.MinimumSize = new System.Drawing.Size(65, 31);
            this.Button_move.Name = "Button_move";
            this.Button_move.Size = new System.Drawing.Size(65, 31);
            this.Button_move.TabIndex = 4;
            this.Button_move.Text = "move";
            this.Button_move.UseVisualStyleBackColor = true;
            this.Button_move.Click += new System.EventHandler(this.Button_move_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1351, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1404, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // text_move_y
            // 
            this.text_move_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_move_y.Location = new System.Drawing.Point(1394, 234);
            this.text_move_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_move_y.Name = "text_move_y";
            this.text_move_y.Size = new System.Drawing.Size(49, 22);
            this.text_move_y.TabIndex = 7;
            this.text_move_y.TextChanged += new System.EventHandler(this.Text_move_y_TextChanged);
            // 
            // text_move_x
            // 
            this.text_move_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_move_x.Location = new System.Drawing.Point(1338, 234);
            this.text_move_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_move_x.Name = "text_move_x";
            this.text_move_x.Size = new System.Drawing.Size(49, 22);
            this.text_move_x.TabIndex = 8;
            this.text_move_x.TextChanged += new System.EventHandler(this.Text_move_x_TextChanged);
            // 
            // text_rotate
            // 
            this.text_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_rotate.Location = new System.Drawing.Point(1338, 303);
            this.text_rotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_rotate.Name = "text_rotate";
            this.text_rotate.Size = new System.Drawing.Size(104, 22);
            this.text_rotate.TabIndex = 13;
            // 
            // button_rotate
            // 
            this.button_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rotate.Location = new System.Drawing.Point(1260, 294);
            this.button_rotate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rotate.MaximumSize = new System.Drawing.Size(65, 31);
            this.button_rotate.MinimumSize = new System.Drawing.Size(65, 31);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(65, 31);
            this.button_rotate.TabIndex = 9;
            this.button_rotate.Text = "rotate";
            this.button_rotate.UseVisualStyleBackColor = true;
            this.button_rotate.Click += new System.EventHandler(this.Button_rotate_Click);
            // 
            // text_scale_x
            // 
            this.text_scale_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_scale_x.Location = new System.Drawing.Point(1338, 369);
            this.text_scale_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_scale_x.Name = "text_scale_x";
            this.text_scale_x.Size = new System.Drawing.Size(49, 22);
            this.text_scale_x.TabIndex = 18;
            // 
            // text_scale_y
            // 
            this.text_scale_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_scale_y.Location = new System.Drawing.Point(1394, 369);
            this.text_scale_y.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_scale_y.Name = "text_scale_y";
            this.text_scale_y.Size = new System.Drawing.Size(49, 22);
            this.text_scale_y.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1404, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1351, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            // 
            // button_scale
            // 
            this.button_scale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_scale.Location = new System.Drawing.Point(1260, 361);
            this.button_scale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_scale.MaximumSize = new System.Drawing.Size(65, 31);
            this.button_scale.MinimumSize = new System.Drawing.Size(65, 31);
            this.button_scale.Name = "button_scale";
            this.button_scale.Size = new System.Drawing.Size(65, 31);
            this.button_scale.TabIndex = 14;
            this.button_scale.Text = "scale";
            this.button_scale.UseVisualStyleBackColor = true;
            this.button_scale.Click += new System.EventHandler(this.Button_scale_Click);
            // 
            // textBox_fscale
            // 
            this.textBox_fscale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fscale.Location = new System.Drawing.Point(1394, 419);
            this.textBox_fscale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_fscale.Name = "textBox_fscale";
            this.textBox_fscale.Size = new System.Drawing.Size(49, 22);
            this.textBox_fscale.TabIndex = 20;
            this.textBox_fscale.TextChanged += new System.EventHandler(this.TextBox_fscale_TextChanged);
            // 
            // button_fscale
            // 
            this.button_fscale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_fscale.Location = new System.Drawing.Point(1260, 412);
            this.button_fscale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_fscale.MaximumSize = new System.Drawing.Size(107, 27);
            this.button_fscale.MinimumSize = new System.Drawing.Size(107, 27);
            this.button_fscale.Name = "button_fscale";
            this.button_fscale.Size = new System.Drawing.Size(107, 27);
            this.button_fscale.TabIndex = 19;
            this.button_fscale.Text = "full scale";
            this.button_fscale.UseVisualStyleBackColor = true;
            this.button_fscale.Click += new System.EventHandler(this.Button_fscale_Click);
            // 
            // button_mirror
            // 
            this.button_mirror.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_mirror.Location = new System.Drawing.Point(1335, 458);
            this.button_mirror.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_mirror.MaximumSize = new System.Drawing.Size(107, 27);
            this.button_mirror.MinimumSize = new System.Drawing.Size(107, 27);
            this.button_mirror.Name = "button_mirror";
            this.button_mirror.Size = new System.Drawing.Size(107, 27);
            this.button_mirror.TabIndex = 21;
            this.button_mirror.Text = "mirror";
            this.button_mirror.UseVisualStyleBackColor = true;
            this.button_mirror.Click += new System.EventHandler(this.Button_mirror_Click);
            // 
            // text_project_p
            // 
            this.text_project_p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_project_p.Location = new System.Drawing.Point(1335, 526);
            this.text_project_p.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_project_p.Name = "text_project_p";
            this.text_project_p.Size = new System.Drawing.Size(49, 22);
            this.text_project_p.TabIndex = 26;
            this.text_project_p.TextChanged += new System.EventHandler(this.Text_project_p_TextChanged);
            // 
            // text_project_q
            // 
            this.text_project_q.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_project_q.Location = new System.Drawing.Point(1394, 526);
            this.text_project_q.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_project_q.Name = "text_project_q";
            this.text_project_q.Size = new System.Drawing.Size(49, 22);
            this.text_project_q.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1404, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Q";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1351, 492);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "P";
            // 
            // button_poject
            // 
            this.button_poject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_poject.Location = new System.Drawing.Point(1260, 517);
            this.button_poject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_poject.MaximumSize = new System.Drawing.Size(65, 31);
            this.button_poject.MinimumSize = new System.Drawing.Size(65, 31);
            this.button_poject.Name = "button_poject";
            this.button_poject.Size = new System.Drawing.Size(65, 31);
            this.button_poject.TabIndex = 22;
            this.button_poject.Text = "project";
            this.button_poject.UseVisualStyleBackColor = true;
            this.button_poject.Click += new System.EventHandler(this.Button_poject_Click);
            // 
            // button_area
            // 
            this.button_area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_area.Location = new System.Drawing.Point(1292, 12);
            this.button_area.MaximumSize = new System.Drawing.Size(127, 29);
            this.button_area.MinimumSize = new System.Drawing.Size(127, 29);
            this.button_area.Name = "button_area";
            this.button_area.Size = new System.Drawing.Size(127, 29);
            this.button_area.TabIndex = 27;
            this.button_area.Text = "Поле";
            this.button_area.UseVisualStyleBackColor = true;
            this.button_area.Click += new System.EventHandler(this.Button_area_Click);
            // 
            // drawarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1684, 789);
            this.Controls.Add(this.button_area);
            this.Controls.Add(this.text_project_p);
            this.Controls.Add(this.text_project_q);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_poject);
            this.Controls.Add(this.button_mirror);
            this.Controls.Add(this.textBox_fscale);
            this.Controls.Add(this.button_fscale);
            this.Controls.Add(this.text_scale_x);
            this.Controls.Add(this.text_scale_y);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_scale);
            this.Controls.Add(this.text_rotate);
            this.Controls.Add(this.button_rotate);
            this.Controls.Add(this.text_move_x);
            this.Controls.Add(this.text_move_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_move);
            this.Controls.Add(this.LineofEq);
            this.Controls.Add(this.Del_Line);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Canvas);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1702, 824);
            this.Name = "drawarea";
            this.Text = "2D_ENGINE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Drawarea_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Drawarea_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Del_Line;
        protected internal System.Windows.Forms.TextBox LineofEq;
        private System.Windows.Forms.Button Button_move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_move_y;
        private System.Windows.Forms.TextBox text_move_x;
        private System.Windows.Forms.TextBox text_rotate;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.TextBox text_scale_x;
        private System.Windows.Forms.TextBox text_scale_y;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_scale;
        private System.Windows.Forms.TextBox textBox_fscale;
        private System.Windows.Forms.Button button_fscale;
        private System.Windows.Forms.Button button_mirror;
        private System.Windows.Forms.TextBox text_project_p;
        private System.Windows.Forms.TextBox text_project_q;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_poject;
        private System.Windows.Forms.Button button_area;
    }
}

