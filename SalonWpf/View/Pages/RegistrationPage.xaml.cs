using SalonWpf.Controlers;
using SalonWpf.Model;
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

namespace SalonWpf.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

     
        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Users newUser = new Users
            {
                IdRole = 2,
                UserName = NameTextBox.Text,
                UserLastName = LastNameTextBox.Text,
                UserOtherName = OtherNamaTextBox.Text,
                UserLogin = LoginTextBox.Text,
                UserPassword = PasswordPasswordBox.Password
            };

            if (UsersController.AddUser(newUser))
            {
                MessageBox.Show("запись добавлена");
            }
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            String allowchar = " ";

            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

            allowchar += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            String[] ar = allowchar.Split(a);

            String pwd = " ";

            string temp = " ";

            Random r = new Random();



            for (int i = 0; i < 6; i++)

            {

                temp = ar[(r.Next(0, ar.Length))];



                pwd += temp;

            }



            textBox1.Text = pwd;

        }
    }
    
}
