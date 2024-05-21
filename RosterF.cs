using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WH40K_GUI_UAT_MS539_ML
{
    public partial class RosterF : Form
    {
        public RosterF()
        {
            InitializeComponent();
        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            UnitF un = new UnitF();
            un.ShowDialog();
        }
    }
}
