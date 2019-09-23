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
            this.Canvas.Size = new System.Drawing.Size(1090, 641);
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
            this.button1.Location = new System.Drawing.Point(1135, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
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
            this.Del_Line.Location = new System.Drawing.Point(1135, 79);
            this.Del_Line.MaximumSize = new System.Drawing.Size(102, 23);
            this.Del_Line.MinimumSize = new System.Drawing.Size(102, 23);
            this.Del_Line.Name = "Del_Line";
            this.Del_Line.Size = new System.Drawing.Size(102, 23);
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
            this.LineofEq.Location = new System.Drawing.Point(1117, 125);
            this.LineofEq.Name = "LineofEq";
            this.LineofEq.ReadOnly = true;
            this.LineofEq.Size = new System.Drawing.Size(137, 20);
            this.LineofEq.TabIndex = 3;
            this.LineofEq.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // drawarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 641);
            this.Controls.Add(this.LineofEq);
            this.Controls.Add(this.Del_Line);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Canvas);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1282, 680);
            this.Name = "drawarea";
            this.Text = "Form1";
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
    }
}

