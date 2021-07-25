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

namespace MovieGuide
{
    public partial class Remove : Form
    {
        Main refToMain { get; set; }
        public Remove()
        {
            InitializeComponent();
            if (Main.theme == "Dark")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.Title_lbl.ForeColor = Color.White;
                this.label1.ForeColor = Color.White;

            }
            else if (Main.theme == "Default")
            {
                this.BackColor = Color.White;
                this.DMovieTitle_txt.ForeColor = Color.Black;
                this.label1.ForeColor = Color.Black;
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            string toRemove = DMovieTitle_txt.Text;
            string filename = Filename_txt.Text;
            movie.Remove(filename, toRemove);
            MessageBox.Show("Deleted Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.None);
        }
    }

}