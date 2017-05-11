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
    public partial class AllProducers : Form
    {

        public AllProducers(int x)
        {

        }
        public AllProducers()
        {
            InitializeComponent();
            producersTableAdapter.Fill(popcorniaDataSet1.Producers);
        }
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.producersTableAdapter.FillBy(this.popcorniaDataSet1.Producers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
