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
    /// Interaction logic for DeleteForm.xaml
    /// </summary>
    public partial class DeleteForm : Window
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (idBox.Text == "")
            {
                MessageBox.Show("Enter Id");
                return;
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                var user = db.Users.Find(int.Parse(idBox.Text));
                db.Users.Remove(user);
                var login = db.Logins.Find(int.Parse(idBox.Text));
                db.Logins.Remove(login);
                db.SaveChanges();   
            }
            MessageBox.Show($"Customer with Id {idBox.Text} succesfully deleted");
            Hide();
        }
    }
}
