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
using System.Text.RegularExpressions;

namespace Registration
{
    /// <summary>
    /// Interaction logic for RegistrationForm.xaml
    /// </summary>
    public partial class RegistrationForm : Window
    {
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void Register_Button(object sender, RoutedEventArgs e)
        {
            
        if (nameBox.Text == "" || surnameBox.Text=="" || ageBox.Text=="" || emailBox.Text=="" || passwordBox.Password =="")
        {
            MessageBox.Show("Fill all columns");
            return;
        }
        using (ApplicationContext db = new ApplicationContext())
        {
            var user = new UserData { Name = nameBox.Text, Surmame = surnameBox.Text, Age = int.Parse(ageBox.Text) };
            var userLogin = new LoginData { Email = emailBox.Text, Password = passwordBox.Password };
            db.Users.Add(user);
            db.Logins.Add(userLogin);
            db.SaveChanges();
        }
        MessageBox.Show("New customer added succesfully");
        Hide();
        }
    }
}
