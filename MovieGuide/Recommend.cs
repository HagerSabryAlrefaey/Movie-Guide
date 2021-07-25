using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieGuide
{
    public partial class Recommend : Form
    {
        public Main refToMain { get; set; }

        List<string> Files = new List<string>();
        List<Bitmap> images;
        public Recommend()
        {
            InitializeComponent();
            images = new List<Bitmap>();
            MovieFound_grid.Hide();
            Poster_pic.Hide();
            if (File.Exists("Files.txt"))
            {
                FileStream fs = new FileStream("Files.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    Files.Add(sr.ReadLine());
                }
                sr.Close();
                fs.Close();
            }

            if ((Main.theme == "Dark"))
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.label1.ForeColor = Color.White;
            }
            else if (Main.theme == "Default")
            {
                this.BackColor = Color.White;
                this.label1.ForeColor = Color.Black;
            }
        }

        private void Rec_Click(object sender, EventArgs e)
        {
            MovieFound_grid.Rows.Clear();
            List<Movie> Movies = new List<Movie>();
            List<Genree> List = new List<Genree>();
            for (int k = 0; k < Genre_lst.CheckedItems.Count; k++)
            {
                Genree list = new Genree(Genre_lst.CheckedItems[k].ToString());
                List.Add(list);
            }
            Movie M = new Movie();
            M.Join(Files);
            Movies = M.Recommend(List);
            List<Movie> Sorted = Movies.OrderByDescending(o => o.Rating).ToList();
            for (int i = 0; i < Sorted.Count; i++)
            {
                Bitmap image = new Bitmap(Sorted.ElementAt(i).Poster);
                images.Add(image);

                string genresList = "";
                for (int j = 0; j < Sorted.ElementAt(i).Genres.Count; j++)
                {
                    genresList = genresList + Sorted.ElementAt(i).Genres.ElementAt(j).nameofgenre + "/";
                }
                MovieFound_grid.Rows.Add(new string[] { Sorted.ElementAt(i).ID, Sorted.ElementAt(i).Title, Sorted.ElementAt(i).Director, Sorted.ElementAt(i).Year, Sorted.ElementAt(i).Rating, genresList });
                MovieFound_grid.Show();
            }
            if(Sorted.Count == 0)
            {
                MessageBox.Show("No movies with selected genres", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void MovieFound_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MovieFound_grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                try
                {
                    Poster_pic.Image = (Image)images.ElementAt(e.RowIndex);
                    Poster_pic.SizeMode = PictureBoxSizeMode.Zoom;
                    Poster_pic.Show();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("nothing to show", "Error");
                }
            }
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.refToMain.Show();
            this.Hide();
        }
    }
}
