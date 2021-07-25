namespace MovieGuide
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.Poster_pic = new System.Windows.Forms.PictureBox();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.Search_cmbo = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Home_btn = new System.Windows.Forms.Button();
            this.MovieFound_grid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Poster_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieFound_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Poster_pic
            // 
            this.Poster_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Poster_pic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Poster_pic.Location = new System.Drawing.Point(430, 83);
            this.Poster_pic.Name = "Poster_pic";
            this.Poster_pic.Size = new System.Drawing.Size(240, 251);
            this.Poster_pic.TabIndex = 20;
            this.Poster_pic.TabStop = false;
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Location = new System.Drawing.Point(13, 45);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(55, 13);
            this.Search_lbl.TabIndex = 21;
            this.Search_lbl.Text = "Search by";
            // 
            // Search_cmbo
            // 
            this.Search_cmbo.FormattingEnabled = true;
            this.Search_cmbo.Items.AddRange(new object[] {
            "Title",
            "Year",
            "Above Rating",
            "Below Rating"});
            this.Search_cmbo.Location = new System.Drawing.Point(83, 42);
            this.Search_cmbo.Name = "Search_cmbo";
            this.Search_cmbo.Size = new System.Drawing.Size(121, 21);
            this.Search_cmbo.TabIndex = 22;
            this.Search_cmbo.SelectedIndexChanged += new System.EventHandler(this.Search_cmbo_SelectedIndexChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(508, 41);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 23;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Search_txt
            // 
            this.Search_txt.Location = new System.Drawing.Point(357, 43);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(145, 20);
            this.Search_txt.TabIndex = 25;
            // 
            // Home_btn
            // 
            this.Home_btn.Location = new System.Drawing.Point(595, 40);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(75, 23);
            this.Home_btn.TabIndex = 26;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.Home_btn_Click);
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
            this.MovieFound_grid.Location = new System.Drawing.Point(12, 83);
            this.MovieFound_grid.Name = "MovieFound_grid";
            this.MovieFound_grid.Size = new System.Drawing.Size(412, 251);
            this.MovieFound_grid.TabIndex = 27;
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
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 346);
            this.Controls.Add(this.MovieFound_grid);
            this.Controls.Add(this.Home_btn);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Search_cmbo);
            this.Controls.Add(this.Search_lbl);
            this.Controls.Add(this.Poster_pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.Poster_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieFound_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Poster_pic;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.ComboBox Search_cmbo;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.DataGridView MovieFound_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewButtonColumn Poster;
    }
}