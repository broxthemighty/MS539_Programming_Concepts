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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WH40K_GUI_UAT_MS539_ML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void newRoster_Click(object sender, RoutedEventArgs e)
        {
            Roster newRoster = new Roster();
            newRoster.ShowDialog();
        }

        private void exceptionHandlingBtn_Click(object sender, RoutedEventArgs e)
        {
            ExceptionHandling eh = new ExceptionHandling();
            eh.ShowDialog();
        }
    }
}
