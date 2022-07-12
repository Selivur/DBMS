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
using System.Collections.ObjectModel;
namespace Registration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext dataEntities = new ApplicationContext();
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = from u in db.Users
                             join l in db.Logins on u.Id equals l.Id
                             select new { Id =u.Id, Name= u.Name, Surname = u.Surmame, Age = u.Age, Email = l.Email, Password = l.Password };
                dataGrid.ItemsSource = users.ToList();
            }
            
        }
        
        private void Refresh_Button(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = from u in db.Users
                            join l in db.Logins on u.Id equals l.Id
                            select new { Id = u.Id, Name = u.Name, Surname = u.Surmame, Age = u.Age, Email = l.Email, Password = l.Password };
                dataGrid.ItemsSource = users.ToList();
            }
        }
        private void Registration_Button(object sender, RoutedEventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Owner = this;
            registrationForm.Show();
        }
        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            var deleteForm = new DeleteForm();
            deleteForm.Owner = this;
            deleteForm.Show();
        }
    }
}
