namespace MovieGuide
{
    partial class Recommend
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
            this.label1 = new System.Windows.Forms.Label();
            this.MovieFound_grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Rec = new System.Windows.Forms.Button();
            this.Genre_lst = new System.Windows.Forms.CheckedListBox();
            this.Poster_pic = new System.Windows.Forms.PictureBox();
            this.Home_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MovieFound_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Choose Categories:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MovieFound_grid
            // 
            this.MovieFound_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieFound_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Director,
            this.Year,
            this.Rating,
            this.Genre,
            this.Poster});
            this.MovieFound_grid.Location = new System.Drawing.Point(12, 82);
            this.MovieFound_grid.Name = "MovieFound_grid";
            this.MovieFound_grid.Size = new System.Drawing.Size(412, 251);
            this.MovieFound_grid.TabIndex = 37;
            this.MovieFound_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovieFound_grid_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Director
            // 
            this.Director.HeaderText = "Director";
            this.Director.Name = "Director";
            this.Director.ReadOnly = true;
            this.Director.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Director.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Year
            // 
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Rating.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Poster
            // 
            this.Poster.HeaderText = "Poster";
            this.Poster.Name = "Poster";
            // 
            // Rec
            // 
            this.Rec.Location = new System.Drawing.Point(349, 24);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(75, 23);
            this.Rec.TabIndex = 36;
            this.Rec.Text = "Recommend";
            this.Rec.UseVisualStyleBackColor = true;
            this.Rec.Click += new System.EventHandler(this.Rec_Click);
            // 
            // Genre_lst
            // 
            this.Genre_lst.FormattingEnabled = true;
            this.Genre_lst.Items.AddRange(new object[] {
            "Adventure",
            "Action",
            "Comedy",
            "Drama",
            "Romance",
            "SciFi"});
            this.Genre_lst.Location = new System.Drawing.Point(124, 13);
            this.Genre_lst.Name = "Genre_lst";
            this.Genre_lst.ScrollAlwaysVisible = true;
            this.Genre_lst.Size = new System.Drawing.Size(154, 49);
            this.Genre_lst.TabIndex = 35;
            // 
            // Poster_pic
            // 
            this.Poster_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Poster_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Poster_pic.Location = new System.Drawing.Point(430, 82);
            this.Poster_pic.Name = "Poster_pic";
            this.Poster_pic.Size = new System.Drawing.Size(240, 251);
            this.Poster_pic.TabIndex = 39;
            this.Poster_pic.TabStop = false;
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(595, 24);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 40;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
            // 
            // Recommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 345);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Poster_pic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieFound_grid);
            this.Controls.Add(this.Rec);
            this.Controls.Add(this.Genre_lst);
            this.Name = "Recommend";
            this.Text = "Recommend";
            ((System.ComponentModel.ISupportInitialize)(this.MovieFound_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Poster_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MovieFound_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewButtonColumn Poster;
        private System.Windows.Forms.Button Rec;
        private System.Windows.Forms.CheckedListBox Genre_lst;
        private System.Windows.Forms.Button Home_btn;
    }
}