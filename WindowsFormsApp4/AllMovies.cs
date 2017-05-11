using System;
using System.Data;
using System.Windows.Forms;
namespace Popcornia
{
    public partial class AllMovies : Form
    {

        public AllMovies(int x)
        {
            
        }
        public AllMovies()
        {
            InitializeComponent();
            this.moviesTableAdapter.Fill(this.popcorniaDataSet1.Movies);
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.moviesTableAdapter.FillBy1(this.popcorniaDataSet1.Movies);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.moviesTableAdapter.FillBy2(this.popcorniaDataSet1.Movies);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
