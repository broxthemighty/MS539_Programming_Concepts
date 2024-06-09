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
    /// Interaction logic for ExceptionHandling.xaml
    /// </summary>
 
    public partial class ExceptionHandling : Window
    {
        public ExceptionHandling()
        {
            InitializeComponent();
        }

        //Need to bind the label content to the output text

        private void checkNumberInputBtn_Click(object sender, RoutedEventArgs e)
        {
            int result;
            string textOutput = checkNumberInputTxt.Text;
            try
            {
                result = int.Parse(textOutput);
                numberOutputLbl.Content = "Correct";
                this.numberOutputLbl.Refresh();
            }
            catch
            {
                numberOutputLbl.Content = "Not a number";
                this.numberOutputLbl.Refresh();
            }
        }

        private void checkNotNumberInputBtn_Click(object sender, RoutedEventArgs e)
        {
            int outNum = 0;
            string textNotOutput = checkNotNumberInputTxt.Text;
            bool result = int.TryParse(textNotOutput, out outNum);
            if (result == false)
            {
                notNumberOutputLbl.Content = "Not a number";
                this.notNumberOutputLbl.Refresh();
            }
            else
            {
                notNumberOutputLbl.Content = "Is a number";
                this.notNumberOutputLbl.Refresh();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propName)
        {
            if(this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }

    public static class ExtensionMethods
    {
        private static readonly Action EmptyDelegate = delegate { };
        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }
    }
}
