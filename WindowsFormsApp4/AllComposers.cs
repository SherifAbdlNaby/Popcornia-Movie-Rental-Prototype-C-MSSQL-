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
    public partial class AllComposers : Form
    {
        public AllComposers(int x)
        {

        }
        public AllComposers()
        {
            InitializeComponent();
            composersTableAdapter.Fill(popcorniaDataSet1.Composers);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.composersTableAdapter.FillBy(this.popcorniaDataSet1.Composers);
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
                this.composersTableAdapter.FillBy1(this.popcorniaDataSet1.Composers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
