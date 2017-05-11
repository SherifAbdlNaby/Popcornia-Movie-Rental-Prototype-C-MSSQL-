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
    public partial class AllRoles : Form
    {
        public AllRoles(int x)
        {

        }
        public AllRoles()
        {
            InitializeComponent();
            rolesTableAdapter.Fill(popcorniaDataSet1.Roles);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolesTableAdapter.FillBy(this.popcorniaDataSet1.Roles);
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
                this.rolesTableAdapter.FillBy1(this.popcorniaDataSet1.Roles);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
