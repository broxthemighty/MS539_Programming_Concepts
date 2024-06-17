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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //delete this later
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            //put in error checking for unit selection

            //put in switch statement, changing the data in the gui properties based on the selection
            //this is only for filler dummy data, but will be used later with the api
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
    }
}
