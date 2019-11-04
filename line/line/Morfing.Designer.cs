namespace line
{
    partial class Morfing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_t1 = new System.Windows.Forms.ComboBox();
            this.comboBox_t0 = new System.Windows.Forms.ComboBox();
            this.View_button = new System.Windows.Forms.Button();
            this.Canvas_new = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_t1
            // 
            this.comboBox_t1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_t1.FormattingEnabled = true;
            this.comboBox_t1.Location = new System.Drawing.Point(1410, 12);
            this.comboBox_t1.MaximumSize = new System.Drawing.Size(121, 0);
            this.comboBox_t1.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBox_t1.Name = "comboBox_t1";
            this.comboBox_t1.Size = new System.Drawing.Size(121, 21);
            this.comboBox_t1.TabIndex = 0;
            // 
            // comboBox_t0
            // 
            this.comboBox_t0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_t0.FormattingEnabled = true;
            this.comboBox_t0.Location = new System.Drawing.Point(1283, 12);
            this.comboBox_t0.MaximumSize = new System.Drawing.Size(121, 0);
            this.comboBox_t0.MinimumSize = new System.Drawing.Size(121, 0);
            this.comboBox_t0.Name = "comboBox_t0";
            this.comboBox_t0.Size = new System.Drawing.Size(121, 21);
            this.comboBox_t0.TabIndex = 1;
            // 
            // View_button
            // 
            this.View_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View_button.Location = new System.Drawing.Point(1202, 12);
            this.View_button.MaximumSize = new System.Drawing.Size(75, 23);
            this.View_button.MinimumSize = new System.Drawing.Size(75, 23);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(75, 23);
            this.View_button.TabIndex = 2;
            this.View_button.Text = "View";
            this.View_button.UseVisualStyleBackColor = true;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // Canvas_new
            // 
            this.Canvas_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas_new.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Canvas_new.Location = new System.Drawing.Point(13, 3);
            this.Canvas_new.Name = "Canvas_new";
            this.Canvas_new.Size = new System.Drawing.Size(1183, 673);
            this.Canvas_new.TabIndex = 3;
            this.Canvas_new.TabStop = false;
            this.Canvas_new.Click += new System.EventHandler(this.Canvas_Click);
            this.Canvas_new.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_new_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(1352, 54);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1312, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "t";
            // 
            // Morfing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Canvas_new);
            this.Controls.Add(this.View_button);
            this.Controls.Add(this.comboBox_t0);
            this.Controls.Add(this.comboBox_t1);
            this.Name = "Morfing";
            this.Text = "Morfing";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_t1;
        private System.Windows.Forms.ComboBox comboBox_t0;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.PictureBox Canvas_new;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}