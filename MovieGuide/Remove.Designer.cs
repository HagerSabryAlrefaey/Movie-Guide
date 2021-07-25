namespace MovieGuide
{
    partial class Remove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove));
            this.DMovieTitle_txt = new System.Windows.Forms.TextBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.Filename_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DMovieTitle_txt
            // 
            this.DMovieTitle_txt.Location = new System.Drawing.Point(180, 54);
            this.DMovieTitle_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DMovieTitle_txt.Name = "DMovieTitle_txt";
            this.DMovieTitle_txt.Size = new System.Drawing.Size(132, 22);
            this.DMovieTitle_txt.TabIndex = 0;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(138, 105);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(100, 28);
            this.Delete_btn.TabIndex = 1;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Location = new System.Drawing.Point(89, 58);
            this.Title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(76, 17);
            this.Title_lbl.TabIndex = 2;
            this.Title_lbl.Text = "Movie Title";
            // 
            // Filename_txt
            // 
            this.Filename_txt.Location = new System.Drawing.Point(180, 12);
            this.Filename_txt.Name = "Filename_txt";
            this.Filename_txt.Size = new System.Drawing.Size(132, 22);
            this.Filename_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "File name";
            // 
            // Remove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 146);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filename_txt);
            this.Controls.Add(this.Title_lbl);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.DMovieTitle_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Remove";
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DMovieTitle_txt;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.TextBox Filename_txt;
        private System.Windows.Forms.Label label1;
    }
}