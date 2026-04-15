using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ariuka
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void movieListToolStripMenuItem_Click(object sender, EventArgs e)

        {
            var openForm = Application.OpenForms["movieForm"];

            if (openForm == null)
            {
                movieForm mf = new movieForm();
                mf.MdiParent = this;
                mf.Show();
            }
            else
            {
                openForm.Focus();
            }
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void favouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForm = Application.OpenForms["FavouriteMovieForm"];
            if (openForm == null)
            {
                FavouriteMovieForm mf = new FavouriteMovieForm();
                mf.MdiParent = this;
                mf.Show();
            }
            else
            {
                openForm.Focus();
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void watchlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForm = Application.OpenForms["WatchlistForm"];
            if (openForm == null)
            {
                WatchlistForm mf = new WatchlistForm();
                mf.MdiParent = this;
                mf.Show();
            }
            else
            {
                openForm.Focus();
            }
        }

        private void favouriteActorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForm = Application.OpenForms["FavouriteMovieForm"];
            if (openForm == null)
            {
                FavouriteActorForm mf = new FavouriteActorForm();
                mf.MdiParent = this;
                mf.Show();
            }
            else
            {
                openForm.Focus();
            }
        }
    }
}


