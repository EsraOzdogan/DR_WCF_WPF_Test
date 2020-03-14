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
using WcfServiceClient.WcfServiceReference1;

namespace Deneme1
{
    /// <summary>
    /// Interaction logic for GirişYap.xaml
    /// </summary>
    public partial class GirişYap : Page
    {
        public GirişYap()
        {
            InitializeComponent();
        }
        Service1Client client = new Service1Client("BasicHttpBinding_IService1");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           DR d = new DR();
            this.NavigationService.Navigate(d);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Arama a = new Arama();
            this.NavigationService.Navigate(a);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Barkod b = new Barkod();
            this.NavigationService.Navigate(b);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GirişYap g = new GirişYap();
            this.NavigationService.Navigate(g);
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            FacebookGiriş fg = new FacebookGiriş();
            this.NavigationService.Navigate(fg);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
           
            string kullanıcı1 = "dilanyilmaz@gmail.com";
            string kullanıcıpass1 = "1601010";
            string kullanıcı2 = "esraozdogan@gmail.com";
            string kullanıcıpass2 = "1601011";


            //string m1r = "111";
            if (txtbox1.Text == kullanıcı1 & PasswordBox1.Password.ToString() == kullanıcıpass1)
            {
                MessageBox.Show(client.Hosgeldiniz("Dilan Yılmaz"));
                DR dr = new DR();
                this.NavigationService.Navigate(dr);


            }
            else if (txtbox1.Text == kullanıcı2 & PasswordBox1.Password.ToString() == kullanıcıpass2)
            {
                MessageBox.Show(client.Hosgeldiniz("Esra Ozdoğan"));
                DR dr = new DR();
                this.NavigationService.Navigate(dr);



            }
            else
            {
                Label1.Foreground = Brushes.Red;
                Label1.Content = client.GeçersizKullanıcı();
            }

        }
    }
}
