using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;

namespace Personnelmanagement.View
{
    /// <summary>
    /// Логика взаимодействия для EmployeeEditPage.xaml
    /// </summary>
    public partial class EmployeeEditPage : Page
    {

        private Employee employee;
        private EmployeeListPage EmployeeListPage;


        public EmployeeEditPage(Employee emp, EmployeeListPage EmployeeList)
        {
            InitializeComponent();

            employee = emp;
            EmployeeListPage = EmployeeList;


            Name.Text = employee.Name;
            Position.Text = employee.Position;
        }



        private void Save_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = Name.Text;
            employee.Position = Position.Text;
            EmployeeListPage.EmployeeGrid.Items.Refresh();
            NavigationService.GoBack();
        }
    }
}
