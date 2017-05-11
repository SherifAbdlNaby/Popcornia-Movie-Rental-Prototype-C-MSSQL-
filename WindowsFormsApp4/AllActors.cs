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
    public partial class AllActors : Form
    {
        public AllActors(int x)
        {

        }
        public AllActors()
        {
            InitializeComponent();
            actorsTableAdapter.Fill(popcorniaDataSet1.Actors);
        }
       
    }
}
