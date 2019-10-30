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
            this.text_rotate_x = new System.Windows.Forms.TextBox();
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
            this.local = new System.Windows.Forms.CheckBox();
            this.text_move_z = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.text_rotate_z = new System.Windows.Forms.TextBox();
            this.text_rotate_y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_scale_z = new System.Windows.Forms.TextBox();
            this.text_xyz = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_xyz_2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.group_button = new System.Windows.Forms.Button();
            this.combo_group = new System.Windows.Forms.ComboBox();
            this.button_group_view = new System.Windows.Forms.Button();
            this.Hide_group = new System.Windows.Forms.Button();
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
            this.Canvas.Location = new System.Drawing.Point(3, 4);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1000, 620);
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
            this.button1.Location = new System.Drawing.Point(1057, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Del_Line
            // 
            this.Del_Line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Del_Line.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Del_Line.Location = new System.Drawing.Point(1122, 39);
            this.Del_Line.MaximumSize = new System.Drawing.Size(102, 23);
            this.Del_Line.MinimumSize = new System.Drawing.Size(102, 23);
            this.Del_Line.Name = "Del_Line";
            this.Del_Line.Size = new System.Drawing.Size(102, 23);
            this.Del_Line.TabIndex = 2;
            this.Del_Line.Text = "Delete Line";
            this.Del_Line.UseVisualStyleBackColor = true;
            this.Del_Line.Click += new System.EventHandler(this.Del_Line_Click);
            // 
            // LineofEq
            // 
            this.LineofEq.AcceptsTab = true;
            this.LineofEq.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineofEq.Location = new System.Drawing.Point(1122, 118);
            this.LineofEq.Name = "LineofEq";
            this.LineofEq.ReadOnly = true;
            this.LineofEq.Size = new System.Drawing.Size(137, 20);
            this.LineofEq.TabIndex = 3;
            this.LineofEq.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Button_move
            // 
            this.Button_move.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_move.Location = new System.Drawing.Point(1055, 153);
            this.Button_move.Margin = new System.Windows.Forms.Padding(2);
            this.Button_move.MaximumSize = new System.Drawing.Size(49, 25);
            this.Button_move.MinimumSize = new System.Drawing.Size(49, 25);
            this.Button_move.Name = "Button_move";
            this.Button_move.Size = new System.Drawing.Size(49, 25);
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
            this.label1.Location = new System.Drawing.Point(1124, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1164, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // text_move_y
            // 
            this.text_move_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_move_y.Location = new System.Drawing.Point(1156, 156);
            this.text_move_y.Margin = new System.Windows.Forms.Padding(2);
            this.text_move_y.Name = "text_move_y";
            this.text_move_y.Size = new System.Drawing.Size(38, 20);
            this.text_move_y.TabIndex = 7;
            this.text_move_y.TextChanged += new System.EventHandler(this.Text_move_y_TextChanged);
            // 
            // text_move_x
            // 
            this.text_move_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_move_x.Location = new System.Drawing.Point(1114, 156);
            this.text_move_x.Margin = new System.Windows.Forms.Padding(2);
            this.text_move_x.Name = "text_move_x";
            this.text_move_x.Size = new System.Drawing.Size(38, 20);
            this.text_move_x.TabIndex = 8;
            this.text_move_x.TextChanged += new System.EventHandler(this.Text_move_x_TextChanged);
            // 
            // text_rotate_x
            // 
            this.text_rotate_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_rotate_x.Location = new System.Drawing.Point(1114, 201);
            this.text_rotate_x.Margin = new System.Windows.Forms.Padding(2);
            this.text_rotate_x.Name = "text_rotate_x";
            this.text_rotate_x.Size = new System.Drawing.Size(38, 20);
            this.text_rotate_x.TabIndex = 13;
            // 
            // button_rotate
            // 
            this.button_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rotate.Location = new System.Drawing.Point(1055, 198);
            this.button_rotate.Margin = new System.Windows.Forms.Padding(2);
            this.button_rotate.MaximumSize = new System.Drawing.Size(49, 25);
            this.button_rotate.MinimumSize = new System.Drawing.Size(49, 25);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(49, 25);
            this.button_rotate.TabIndex = 9;
            this.button_rotate.Text = "rotate";
            this.button_rotate.UseVisualStyleBackColor = true;
            this.button_rotate.Click += new System.EventHandler(this.Button_rotate_Click);
            // 
            // text_scale_x
            // 
            this.text_scale_x.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_scale_x.Location = new System.Drawing.Point(1114, 242);
            this.text_scale_x.Margin = new System.Windows.Forms.Padding(2);
            this.text_scale_x.Name = "text_scale_x";
            this.text_scale_x.Size = new System.Drawing.Size(38, 20);
            this.text_scale_x.TabIndex = 18;
            // 
            // text_scale_y
            // 
            this.text_scale_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_scale_y.Location = new System.Drawing.Point(1156, 242);
            this.text_scale_y.Margin = new System.Windows.Forms.Padding(2);
            this.text_scale_y.Name = "text_scale_y";
            this.text_scale_y.Size = new System.Drawing.Size(38, 20);
            this.text_scale_y.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1163, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1123, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "X";
            // 
            // button_scale
            // 
            this.button_scale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_scale.Location = new System.Drawing.Point(1055, 239);
            this.button_scale.Margin = new System.Windows.Forms.Padding(2);
            this.button_scale.MaximumSize = new System.Drawing.Size(49, 25);
            this.button_scale.MinimumSize = new System.Drawing.Size(49, 25);
            this.button_scale.Name = "button_scale";
            this.button_scale.Size = new System.Drawing.Size(49, 25);
            this.button_scale.TabIndex = 14;
            this.button_scale.Text = "scale";
            this.button_scale.UseVisualStyleBackColor = true;
            this.button_scale.Click += new System.EventHandler(this.Button_scale_Click);
            // 
            // textBox_fscale
            // 
            this.textBox_fscale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_fscale.Location = new System.Drawing.Point(1202, 273);
            this.textBox_fscale.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_fscale.Name = "textBox_fscale";
            this.textBox_fscale.Size = new System.Drawing.Size(38, 20);
            this.textBox_fscale.TabIndex = 20;
            this.textBox_fscale.TextChanged += new System.EventHandler(this.TextBox_fscale_TextChanged);
            // 
            // button_fscale
            // 
            this.button_fscale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_fscale.Location = new System.Drawing.Point(1119, 271);
            this.button_fscale.Margin = new System.Windows.Forms.Padding(2);
            this.button_fscale.MaximumSize = new System.Drawing.Size(80, 22);
            this.button_fscale.MinimumSize = new System.Drawing.Size(80, 22);
            this.button_fscale.Name = "button_fscale";
            this.button_fscale.Size = new System.Drawing.Size(80, 22);
            this.button_fscale.TabIndex = 19;
            this.button_fscale.Text = "full scale";
            this.button_fscale.UseVisualStyleBackColor = true;
            this.button_fscale.Click += new System.EventHandler(this.Button_fscale_Click);
            // 
            // button_mirror
            // 
            this.button_mirror.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_mirror.Location = new System.Drawing.Point(1055, 268);
            this.button_mirror.Margin = new System.Windows.Forms.Padding(2);
            this.button_mirror.MaximumSize = new System.Drawing.Size(60, 25);
            this.button_mirror.MinimumSize = new System.Drawing.Size(60, 25);
            this.button_mirror.Name = "button_mirror";
            this.button_mirror.Size = new System.Drawing.Size(60, 25);
            this.button_mirror.TabIndex = 21;
            this.button_mirror.Text = "mirror";
            this.button_mirror.UseVisualStyleBackColor = true;
            this.button_mirror.Click += new System.EventHandler(this.Button_mirror_Click);
            // 
            // text_project_p
            // 
            this.text_project_p.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_project_p.Location = new System.Drawing.Point(1122, 313);
            this.text_project_p.Margin = new System.Windows.Forms.Padding(2);
            this.text_project_p.Name = "text_project_p";
            this.text_project_p.Size = new System.Drawing.Size(38, 20);
            this.text_project_p.TabIndex = 26;
            this.text_project_p.TextChanged += new System.EventHandler(this.Text_project_p_TextChanged);
            // 
            // text_project_q
            // 
            this.text_project_q.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_project_q.Location = new System.Drawing.Point(1167, 313);
            this.text_project_q.Margin = new System.Windows.Forms.Padding(2);
            this.text_project_q.Name = "text_project_q";
            this.text_project_q.Size = new System.Drawing.Size(38, 20);
            this.text_project_q.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1179, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Q";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1139, 298);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "P";
            // 
            // button_poject
            // 
            this.button_poject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_poject.Location = new System.Drawing.Point(1057, 308);
            this.button_poject.Margin = new System.Windows.Forms.Padding(2);
            this.button_poject.MaximumSize = new System.Drawing.Size(49, 25);
            this.button_poject.MinimumSize = new System.Drawing.Size(49, 25);
            this.button_poject.Name = "button_poject";
            this.button_poject.Size = new System.Drawing.Size(49, 25);
            this.button_poject.TabIndex = 22;
            this.button_poject.Text = "project";
            this.button_poject.UseVisualStyleBackColor = true;
            this.button_poject.Click += new System.EventHandler(this.Button_poject_Click);
            // 
            // button_area
            // 
            this.button_area.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_area.Location = new System.Drawing.Point(1122, 11);
            this.button_area.Margin = new System.Windows.Forms.Padding(2);
            this.button_area.MaximumSize = new System.Drawing.Size(95, 24);
            this.button_area.MinimumSize = new System.Drawing.Size(95, 24);
            this.button_area.Name = "button_area";
            this.button_area.Size = new System.Drawing.Size(95, 24);
            this.button_area.TabIndex = 27;
            this.button_area.Text = "Area";
            this.button_area.UseVisualStyleBackColor = true;
            this.button_area.Click += new System.EventHandler(this.Button_area_Click);
            // 
            // local
            // 
            this.local.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.local.AutoSize = true;
            this.local.Location = new System.Drawing.Point(1061, 11);
            this.local.Name = "local";
            this.local.Size = new System.Drawing.Size(48, 17);
            this.local.TabIndex = 31;
            this.local.Text = "local";
            this.local.UseVisualStyleBackColor = true;
            // 
            // text_move_z
            // 
            this.text_move_z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_move_z.Location = new System.Drawing.Point(1198, 156);
            this.text_move_z.Margin = new System.Windows.Forms.Padding(2);
            this.text_move_z.Name = "text_move_z";
            this.text_move_z.Size = new System.Drawing.Size(38, 20);
            this.text_move_z.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1210, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Z";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1209, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1163, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1123, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "X";
            // 
            // text_rotate_z
            // 
            this.text_rotate_z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_rotate_z.Location = new System.Drawing.Point(1198, 201);
            this.text_rotate_z.Margin = new System.Windows.Forms.Padding(2);
            this.text_rotate_z.Name = "text_rotate_z";
            this.text_rotate_z.Size = new System.Drawing.Size(38, 20);
            this.text_rotate_z.TabIndex = 37;
            // 
            // text_rotate_y
            // 
            this.text_rotate_y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_rotate_y.Location = new System.Drawing.Point(1156, 201);
            this.text_rotate_y.Margin = new System.Windows.Forms.Padding(2);
            this.text_rotate_y.Name = "text_rotate_y";
            this.text_rotate_y.Size = new System.Drawing.Size(38, 20);
            this.text_rotate_y.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1209, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Z";
            // 
            // text_scale_z
            // 
            this.text_scale_z.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_scale_z.Location = new System.Drawing.Point(1202, 242);
            this.text_scale_z.Margin = new System.Windows.Forms.Padding(2);
            this.text_scale_z.Name = "text_scale_z";
            this.text_scale_z.Size = new System.Drawing.Size(38, 20);
            this.text_scale_z.TabIndex = 40;
            // 
            // text_xyz
            // 
            this.text_xyz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_xyz.Location = new System.Drawing.Point(1122, 67);
            this.text_xyz.Margin = new System.Windows.Forms.Padding(2);
            this.text_xyz.Name = "text_xyz";
            this.text_xyz.ReadOnly = true;
            this.text_xyz.Size = new System.Drawing.Size(137, 20);
            this.text_xyz.TabIndex = 42;
            this.text_xyz.TextChanged += new System.EventHandler(this.text_xyz_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1057, 74);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "X1:Y1:Z1";
            // 
            // text_xyz_2
            // 
            this.text_xyz_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_xyz_2.Location = new System.Drawing.Point(1122, 91);
            this.text_xyz_2.Margin = new System.Windows.Forms.Padding(2);
            this.text_xyz_2.Name = "text_xyz_2";
            this.text_xyz_2.ReadOnly = true;
            this.text_xyz_2.Size = new System.Drawing.Size(137, 20);
            this.text_xyz_2.TabIndex = 44;
            this.text_xyz_2.TextChanged += new System.EventHandler(this.text_xyz_2_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1057, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "X2:Y2:Z2";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1063, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Line";
            // 
            // group_button
            // 
            this.group_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_button.Location = new System.Drawing.Point(1057, 337);
            this.group_button.Margin = new System.Windows.Forms.Padding(2);
            this.group_button.MaximumSize = new System.Drawing.Size(49, 25);
            this.group_button.MinimumSize = new System.Drawing.Size(49, 25);
            this.group_button.Name = "group_button";
            this.group_button.Size = new System.Drawing.Size(49, 25);
            this.group_button.TabIndex = 46;
            this.group_button.Text = "Group";
            this.group_button.UseVisualStyleBackColor = true;
            this.group_button.Click += new System.EventHandler(this.group_button_Click);
            // 
            // combo_group
            // 
            this.combo_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combo_group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combo_group.FormattingEnabled = true;
            this.combo_group.Location = new System.Drawing.Point(1115, 370);
            this.combo_group.Name = "combo_group";
            this.combo_group.Size = new System.Drawing.Size(121, 21);
            this.combo_group.TabIndex = 47;
            this.combo_group.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_group_view
            // 
            this.button_group_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_group_view.Location = new System.Drawing.Point(1057, 366);
            this.button_group_view.Margin = new System.Windows.Forms.Padding(2);
            this.button_group_view.MaximumSize = new System.Drawing.Size(49, 25);
            this.button_group_view.MinimumSize = new System.Drawing.Size(49, 25);
            this.button_group_view.Name = "button_group_view";
            this.button_group_view.Size = new System.Drawing.Size(49, 25);
            this.button_group_view.TabIndex = 48;
            this.button_group_view.Text = "View";
            this.button_group_view.UseVisualStyleBackColor = true;
            this.button_group_view.Click += new System.EventHandler(this.button_group_view_Click);
            // 
            // Hide_group
            // 
            this.Hide_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hide_group.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Hide_group.Location = new System.Drawing.Point(1122, 338);
            this.Hide_group.MaximumSize = new System.Drawing.Size(83, 23);
            this.Hide_group.MinimumSize = new System.Drawing.Size(83, 23);
            this.Hide_group.Name = "Hide_group";
            this.Hide_group.Size = new System.Drawing.Size(83, 23);
            this.Hide_group.TabIndex = 49;
            this.Hide_group.Text = "Hide_group";
            this.Hide_group.UseVisualStyleBackColor = false;
            this.Hide_group.Click += new System.EventHandler(this.Hide_group_Click);
            // 
            // drawarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 641);
            this.Controls.Add(this.Hide_group);
            this.Controls.Add(this.button_group_view);
            this.Controls.Add(this.combo_group);
            this.Controls.Add(this.group_button);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.text_xyz_2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.text_xyz);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.text_scale_z);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_rotate_y);
            this.Controls.Add(this.text_rotate_z);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text_move_z);
            this.Controls.Add(this.local);
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
            this.Controls.Add(this.text_rotate_x);
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
            this.MinimumSize = new System.Drawing.Size(1280, 677);
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
        private System.Windows.Forms.TextBox text_rotate_x;
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
        private System.Windows.Forms.CheckBox local;
        private System.Windows.Forms.TextBox text_move_z;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox text_rotate_z;
        private System.Windows.Forms.TextBox text_rotate_y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_scale_z;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        protected internal System.Windows.Forms.TextBox text_xyz;
        protected internal System.Windows.Forms.TextBox text_xyz_2;
        private System.Windows.Forms.Button group_button;
        private System.Windows.Forms.ComboBox combo_group;
        private System.Windows.Forms.Button button_group_view;
        private System.Windows.Forms.Button Hide_group;
    }
}

