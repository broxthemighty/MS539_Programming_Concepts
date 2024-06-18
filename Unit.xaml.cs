using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace WH40K_GUI_UAT_MS539_ML
{
    /// <summary>
    /// Interaction logic for Unit.xaml
    /// </summary>
    public partial class Unit : Window
    {


        public string unitName = "";

        public Unit()
        {
            InitializeComponent();
            List<string> dummyData = new List<string>();
            dummyData.Add("StringArrayList");
            dummyData.Add("Captain");
            dummyData.Add("Apothecary");
            dummyData.Add("Intercessors");
            dummyData.Add("Bladeguard");
            dummyData.Add("Gladiator Lancer");

            if (dummyData.Count > 0)
            {
                UnitList.ItemsSource = dummyData;
            }
            
        }

        private void updateUnitWargear(string unitName)
        {
            switch (unitName)
            {
                case "StringArrayList":
                    unitMeleeWeapons.Text = "Melee Weapons Here";
                    unitRangedWeapons.Text = "Ranged Weapons Here";
                    unitAbilities.Text = "Abilities Here";
                    break;
                case "Captain":
                    unitMeleeWeapons.Text = "Power Sword";
                    unitRangedWeapons.Text = "Master Crafted Bolter";
                    unitAbilities.Text = "Rites of Battle";
                    break;
                case "Apothecary":
                    unitMeleeWeapons.Text = "Melee Weapon";
                    unitRangedWeapons.Text = "Reductor Pistol";
                    unitAbilities.Text = "Narthecium";
                    break;
                case "Intercessors":
                    unitMeleeWeapons.Text = "Chainsword and Melee Weapons";
                    unitRangedWeapons.Text = "Bolt Rifles";
                    unitAbilities.Text = "Objective Secured";
                    break;
                case "Bladeguard":
                    unitMeleeWeapons.Text = "Master Crafted Power Swords";
                    unitRangedWeapons.Text = "Heavy Bolt Pistols";
                    unitAbilities.Text = "Bladeguard";
                    break;
                case "Gladiator Lancer":
                    unitMeleeWeapons.Text = "Armored hull";
                    unitRangedWeapons.Text = "Lancer laser destroyer";
                    unitAbilities.Text = "Aquilon Optics";
                    break;
            }
            unitDisplayName.Text = unitName;
            unitDisplayName.Refresh();
            unitMeleeWeapons.Refresh();
            unitRangedWeapons.Refresh();
            unitAbilities.Refresh();
        }

        private void updateUnitStats(string unitName)
        {
            switch(unitName)
            {
                case "StringArrayList":
                    unitMovement.Content = "1";
                    unitToughness.Content = "1";
                    unitWounds.Content = "1";
                    unitSave.Content = "1";
                    unitLeadership.Content = "1";
                    unitObjectiveControl.Content = "1";
                    unitInvulnerableSave.Content = "1";
                    unitFeelNoPain.Content = "1";
                    break;
                case "Captain":
                    unitMovement.Content = "6";
                    unitToughness.Content = "4";
                    unitWounds.Content = "5";
                    unitSave.Content = "3";
                    unitLeadership.Content = "6";
                    unitObjectiveControl.Content = "1";
                    unitInvulnerableSave.Content = "4";
                    unitFeelNoPain.Content = "-";
                    break;
                case "Apothecary":
                    unitMovement.Content = "6";
                    unitToughness.Content = "4";
                    unitWounds.Content = "4";
                    unitSave.Content = "3";
                    unitLeadership.Content = "6";
                    unitObjectiveControl.Content = "1";
                    unitInvulnerableSave.Content = "-";
                    unitFeelNoPain.Content = "-";
                    break;
                case "Intercessors":
                    unitMovement.Content = "6";
                    unitToughness.Content = "4";
                    unitWounds.Content = "2";
                    unitSave.Content = "3";
                    unitLeadership.Content = "6";
                    unitObjectiveControl.Content = "2";
                    unitInvulnerableSave.Content = "-";
                    unitFeelNoPain.Content = "-";
                    break;
                case "Bladeguard":
                    unitMovement.Content = "6";
                    unitToughness.Content = "4";
                    unitWounds.Content = "3";
                    unitSave.Content = "3";
                    unitLeadership.Content = "6";
                    unitObjectiveControl.Content = "1";
                    unitInvulnerableSave.Content = "4";
                    unitFeelNoPain.Content = "-";
                    break;
                case "Gladiator Lancer":
                    unitMovement.Content = "10";
                    unitToughness.Content = "10";
                    unitWounds.Content = "12";
                    unitSave.Content = "3";
                    unitLeadership.Content = "6";
                    unitObjectiveControl.Content = "3";
                    unitInvulnerableSave.Content = "-";
                    unitFeelNoPain.Content = "-";
                    break;
            }
            unitMovement.Refresh();
            unitToughness.Refresh();
            unitWounds.Refresh();
            unitSave.Refresh();
            unitLeadership.Refresh();
            unitObjectiveControl.Refresh();
            unitInvulnerableSave.Refresh();
            unitFeelNoPain.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Include error checking
            //See if there are already 3 such units already in the roster
        }

        private void randomizerBtn_Click(object sender, RoutedEventArgs e)
        {
            RandomNumber rn = new RandomNumber(1, 150);
            randomizerLbl.Content = rn.getRandomNumber().ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private void UnitList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateUnitWargear(UnitList.SelectedItem.ToString());
            updateUnitStats(UnitList.SelectedItem.ToString());
        }
    }
}
