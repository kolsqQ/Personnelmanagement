using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
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

namespace Personnelmanagement.View
{
    /// <summary>
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();
            EmployeeGrid.ItemsSource = employees;



        }

        public ObservableCollection<Employee> employees = new ObservableCollection<Employee>
        {
                new Employee { id = 1 , Name="Боб", Position="Босс", Phone=7777 },
                new Employee { id = 2 , Name="Илья", Position="Работяга", Phone=2321 },
                new Employee { id = 3 , Name="Темон", Position="Работяга", Phone=6364 },

        };




        public void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeGrid.SelectedItem != null)
            {
                var selectedEmployee = (Employee)EmployeeGrid.SelectedItem;

                EmployeeEditPage editPage = new EmployeeEditPage(selectedEmployee);
                this.NavigationService.Navigate(editPage);
            }
        }
    }
}
