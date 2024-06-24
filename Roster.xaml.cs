using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WH40K_GUI_UAT_MS539_ML
{
    /// <summary>
    /// Interaction logic for Roster.xaml
    /// </summary>
    
    //Need to have an X to remove a unit from the roster, with a popup stating the unit name and verifying the user wants to delete it
    public partial class Roster : Window
    {
        List<UnitData> rUD = new List<UnitData>();

        public Roster()
        {
            InitializeComponent();
        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Unit un = new Unit(rUD);
            un.ShowDialog();
        }

        public void SetRosterUnitData(List<UnitData> lUD)
        {
            rUD = lUD;
            UpdateUnitDataText();
        }

        public void UpdateUnitDataText()
        {
            foreach (UnitData x in rUD)
            {
                if(x.GetUnitType().Contains("Leader"))
                {
                    characterTxtBx.Text = characterTxtBx.Text.ToString() +
                        x.GetUnitName() + " M T W Sv LD OC INV FNP /n";  
                    characterTxtBx.Refresh();
                }
                else if (x.GetUnitType().Contains("BattleLine"))
                {
                    battleLineTxtBx.Text = battleLineTxtBx.Text.ToString() +
                        x.GetUnitName() + " M T W Sv LD OC INV FNP /n";
                    battleLineTxtBx.Refresh();
                }
                else if (x.GetUnitType().Contains("Dedicated"))
                {
                    dedicatedTransportTxtBx.Text = dedicatedTransportTxtBx.Text.ToString() +
                        x.GetUnitName() + " M T W Sv LD OC INV FNP /n";
                    dedicatedTransportTxtBx.Refresh();
                }
                else if (x.GetUnitType().Contains("Other"))
                {
                    otherDatasheetsTxtBx.Text = otherDatasheetsTxtBx.Text.ToString() +
                        x.GetUnitName() + " M T W Sv LD OC INV FNP /n";
                    otherDatasheetsTxtBx.Refresh();
                }
                else if (x.GetUnitType().Contains("Allied"))
                {
                    alliedUnitsTxtBx.Text = alliedUnitsTxtBx.Text.ToString() +
                        x.GetUnitName() + " M T W Sv LD OC INV FNP /n";
                    alliedUnitsTxtBx.Refresh();
                }
            }
        }
    }
}
