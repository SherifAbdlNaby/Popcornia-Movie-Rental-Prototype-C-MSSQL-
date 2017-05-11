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
    public partial class AllDirectors : Form
    {
        public AllDirectors(int x)
        {
            
        }
        public AllDirectors()
        {
            InitializeComponent();
            directorsTableAdapter.Fill(popcorniaDataSet1.Directors);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.directorsTableAdapter.FillBy(this.popcorniaDataSet1.Directors);
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
                this.directorsTableAdapter.FillBy1(this.popcorniaDataSet1.Directors);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
