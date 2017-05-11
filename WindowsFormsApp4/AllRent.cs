using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popcornia
{
    public partial class AllRent : Form
    {
        public AllRent(int x)
        {

        }
        public AllRent()
        {
            InitializeComponent();
            rentsTableAdapter.Fill(popcorniaDataSet1.Rents);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentsTableAdapter.FillBy(this.popcorniaDataSet1.Rents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentsTableAdapter.FillBy1(this.popcorniaDataSet1.Rents);
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
                this.rentsTableAdapter.FillBy2(this.popcorniaDataSet1.Rents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentsTableAdapter.FillBy3(this.popcorniaDataSet1.Rents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentsTableAdapter.FillBy4(this.popcorniaDataSet1.Rents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.rentsTableAdapter.FillBy4(this.popcorniaDataSet1.Rents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentsTableAdapter.FillBy5(this.popcorniaDataSet1.Rents);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void AllRent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'popcorniaDataSet11.Rents' table. You can move, or remove it, as needed.
            this.rentsTableAdapter.Fill(this.popcorniaDataSet11.Rents);

        }
    }
}
