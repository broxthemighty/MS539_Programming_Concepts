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
        //List<UnitData> rUD = new List<UnitData>();
        Dictionary<string, UnitData> ros = new Dictionary<string, UnitData>();

        public Roster()
        {
            InitializeComponent();
        }

        private void addUnitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Unit un = new Unit(ros);
            un.ShowDialog();
        }

        //public void SetRosterUnitData(List<UnitData> lUD)
        //{
        //    rUD = lUD;
        //    UpdateUnitDataText();
        //}

        public void SetRosterUnitData(Dictionary<string, UnitData> rDict)
        {
            ros = rDict;
        }

        public void UpdateUnitDataText()
        {//maybe split the dictionary data into a series of lists, sorted alphabetically, not sure how to do enhancements yet
            rosterTxtBx.Text = rosterTxtBx.Text.ToString() + "Characters" + "\n" + "-----------------------------------------" + "\n";
            foreach (KeyValuePair<string, UnitData> y in ros) 
            {

                if (y.Value.GetUnitType().Contains("Leader"))
                {
                    rosterTxtBx.Text = rosterTxtBx.Text.ToString() + FormatUnitText(y.Value);
                }
            }

            rosterTxtBx.Text = rosterTxtBx.Text.ToString() + "Battle Line" + "\n" + "-----------------------------------------" + "\n";
            foreach (KeyValuePair<string, UnitData> y in ros) 
            {
                if (y.Value.GetUnitType().Contains("BattleLine"))
                {
                    rosterTxtBx.Text = rosterTxtBx.Text.ToString() + FormatUnitText(y.Value);
                }
            }

            rosterTxtBx.Text = rosterTxtBx.Text.ToString() + "Dedicated Transports" + "\n" + "-----------------------------------------" + "\n";
            foreach (KeyValuePair<string, UnitData> y in ros) 
            {
                if (y.Value.GetUnitType().Contains("Dedicated"))
                {
                    rosterTxtBx.Text = rosterTxtBx.Text.ToString() + FormatUnitText(y.Value);
                }
            }

            rosterTxtBx.Text = rosterTxtBx.Text.ToString() + "Other Units" + "\n" + "-----------------------------------------" + "\n";
            foreach (KeyValuePair<string, UnitData> y in ros)
            {
                if (y.Value.GetUnitType().Contains("Other"))
                {
                    rosterTxtBx.Text = rosterTxtBx.Text.ToString() + FormatUnitText(y.Value);
                }
            }

            rosterTxtBx.Text = rosterTxtBx.Text.ToString() + "Allied Units" + "\n" + "-----------------------------------------" + "\n";
            foreach (KeyValuePair<string, UnitData> y in ros) 
            {
                if (y.Value.GetUnitType().Contains("Allied"))
                {
                    rosterTxtBx.Text = rosterTxtBx.Text.ToString() + FormatUnitText(y.Value);
                }
            }
            rosterTxtBx.Refresh();
        }

        public string FormatUnitText(UnitData ud)
        {
            string textOutput = "";
            string statLine = " M  T  W  Sv LD OC INV FNP \n";

            string uName = ud.GetUnitName();
            string uType = ud.GetUnitType();
            string uMove = ud.GetUnitMovement();
            string uTough = ud.GetUnitToughness();
            string uWounds = ud.GetUnitWounds();
            string uSave = ud.GetUnitSave();
            string uLead = ud.GetUnitLeadership();
            string uOC = ud.GetUnitObjectiveControl();
            string uINV = ud.GetUnitInvulnerableSave();
            string uFNP = ud.GetUnitFeelNoPain();
            string uModelNum = ud.GetUnitModelCount();

            textOutput = AddSpaces(19) + statLine + KeepSameCharacterLength(uName, 20) + KeepSameCharacterLength(uMove, 2) + " " + KeepSameCharacterLength(uTough, 2)
                + " " + KeepSameCharacterLength(uWounds, 2) + " " + KeepSameCharacterLength(uSave, 2) + " " + KeepSameCharacterLength(uLead, 2) + " " + KeepSameCharacterLength(uOC, 2) 
                + " " + KeepSameCharacterLength(uINV, 3) + " " + KeepSameCharacterLength(uFNP, 3) + "\n" + "\n";

            return textOutput;
        }

        public string AddSpaces(int amount)
        {
            string spaces = "";
            

            for (int i = 0; i < amount; i++) 
            {
                spaces += " ";
            }

            return spaces;
        }

        public string KeepSameCharacterLength(string uS, int len)
        {
            int finalLen = 0;
            if(uS.Length < len)
            {
                finalLen = len - uS.Length;
            }

            string returnS = uS + AddSpaces(finalLen);

            return returnS;
        }
    }
}
