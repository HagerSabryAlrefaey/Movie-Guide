using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace MovieGuide
{
    public partial class Search : Form
    {
        public Main refToMain { get; set; }
        bool isTitle = false;
        List<Bitmap> images;
        List<string> Files = new List<string>();

        public Search()
        {
            InitializeComponent();
            images = new List<Bitmap>();
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
            MovieFound_grid.Hide();
            Poster_pic.Hide();
            Search_txt.Hide();
            Search_btn.Hide();
            if(Main.theme == "Dark")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                Search_lbl.ForeColor = Color.White;
            }
            else if(Main.theme == "Default")
            {
                this.BackColor = Color.White;
                Search_lbl.ForeColor = Color.Black;

            }
        }
        private void Search_btn_Click(object sender, EventArgs e)
        {
            MovieFound_grid.Rows.Clear();
            Movie M = new Movie();
            M.Join(Files);
            try
            {
                Movie SearchMovie = new Movie();
                Movie foundMovie = new Movie();
                List<Movie> foundmovies = new List<Movie>();
                string s = Search_txt.Text;

                if (Search_cmbo.SelectedItem.ToString() == "Title")
                {
                    isTitle = true;
                    foundMovie = SearchMovie.TitleSearch(s); 
                }
                else if (Search_cmbo.SelectedItem.ToString() == "Year")
                {
                    isTitle = false;
                    foundmovies = SearchMovie.YearSearch(s);
                }
                else if (Search_cmbo.SelectedItem.ToString() == "Above Rating")
                {
                    isTitle = false;
                    int rate = int.Parse(s);
                    foundmovies = SearchMovie.AboveRatingSearch(rate);
                }
                else if (Search_cmbo.SelectedItem.ToString() == "Below Rating")
                {
                    isTitle = false;
                    int rate = int.Parse(s);
                    foundmovies = SearchMovie.BelowRatingSearch(rate);
                }
                if(isTitle)
                {
                    if (foundMovie == null)
                    {
                        MessageBox.Show("Movie Does Not Exist", "Error");
                    }
                    else
                    {
                        Bitmap image = new Bitmap(foundMovie.Poster);
                        images.Add(image);


                        string genresList = "";
                        for (int i = 0; i < foundMovie.Genres.Count; i++)
                        {
                            genresList = genresList + foundMovie.Genres.ElementAt(i).nameofgenre + "/";
                        }
                        MovieFound_grid.Rows.Add(new string[] { foundMovie.ID, foundMovie.Title, foundMovie.Director, foundMovie.Year, foundMovie.Rating, genresList });
                        MovieFound_grid.Show();
                    }
                }
                else if(!isTitle)
                {
                    if (foundmovies == null)
                    {
                        MessageBox.Show("Movie Does Not Exist", "Error");
                    }
                    else
                    {
                        for (int i = 0; i < foundmovies.Count; i++)
                        {

                            Bitmap image = new Bitmap(foundmovies.ElementAt(i).Poster);
                            images.Add(image);

                            string genresList = "";
                            for (int j = 0; j < foundmovies.ElementAt(i).Genres.Count; j++)
                            {
                                genresList = genresList + foundmovies.ElementAt(i).Genres.ElementAt(j).nameofgenre + "/";
                            }
                            MovieFound_grid.Rows.Add(new string[] { foundmovies.ElementAt(i).ID, foundmovies.ElementAt(i).Title, foundmovies.ElementAt(i).Director, foundmovies.ElementAt(i).Year, foundmovies.ElementAt(i).Rating, genresList });
                            MovieFound_grid.Show();
                        }
                    }
                }
                
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Sorry something went wrong with the file please try again later", "Error");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("please fill the text box with Valid Movie Title", "Error");
            }
        }

        private void Search_cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_txt.Show();
            Search_btn.Show();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            this.refToMain.Show();
            this.Hide();
            
        }

        private void MovieFound_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MovieFound_grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
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
    }
}
