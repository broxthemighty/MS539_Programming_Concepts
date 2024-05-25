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
       
        

        public Unit()
        {
            InitializeComponent();
            List<string> dummyData = new List<string>();
            dummyData.Add("Captain");
            dummyData.Add("Apothecary");
            dummyData.Add("Intercessors");
            dummyData.Add("Bladeguard");
            dummyData.Add("Gladiator Lancer");
            UnitList.DataContext = dummyData;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
