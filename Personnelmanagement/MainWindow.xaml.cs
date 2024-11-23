using Personnelmanagement.View;
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

namespace Personnelmanagement
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            appframe.Navigate(new HomePage());

        }

        private void appframe_Navigated(object sender, NavigationEventArgs e)
        {

        }



        private void EmployeeList_Click(object sender, RoutedEventArgs e)
        {
            appframe.Navigate(new EmployeeListPage());
        }



        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            appframe.Navigate(new HomePage());

        }
    }
}
