namespace line
{
    partial class Menu
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
            this.Add_Line = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_Line
            // 
            this.Add_Line.Location = new System.Drawing.Point(12, 12);
            this.Add_Line.Name = "Add_Line";
            this.Add_Line.Size = new System.Drawing.Size(75, 23);
            this.Add_Line.TabIndex = 0;
            this.Add_Line.Text = "Add_Line";
            this.Add_Line.UseVisualStyleBackColor = true;
            this.Add_Line.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 239);
            this.Controls.Add(this.Add_Line);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_Line;
    }
}