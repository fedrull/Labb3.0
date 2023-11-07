using Labb3_NET22.DataModels;
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

namespace Labb3_NET22
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Window1 newWindow1 = new Window1();

            
            newWindow1.Show();
        }

        private void btnStupid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are You Dumb!?");
        }

        private void category_Click(object sender, RoutedEventArgs e)
        {
            editQuizWindow newEditQuizWindow = new editQuizWindow();

            newEditQuizWindow.Show();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
           await Database.ReadFiles();
        }
    }
}
