using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BookStoreLIB;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStoreGUI
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

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            string usernm = this.nameTextBox.Text;
            string passwd = this.passwordTextBox.Password;
            int asciival;
            int loopcounter;

            
            char[] chars = passwd.ToCharArray();

            if (String.IsNullOrEmpty(usernm) || String.IsNullOrEmpty(passwd))

            {
                MessageBox.Show("Please fill in all slots");
                return;
            }


            else
            {
                var userData = new UserData();
                if (userData.LogIn(usernm, passwd) == true)
                {
                    MessageBox.Show("You are logged in as user #" + userData.UserID);
                    return;
                } if (passwd.Length != 6) { 
                MessageBox.Show("Password requires 6 characters.");
                return;
            } if (userData.LogIn(usernm, passwd) == false)
                {
                    MessageBox.Show("Invalid Username or Password.");
                    return;
                }
            }
            MessageBox.Show("Thank you for providing the input");
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
