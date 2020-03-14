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
    /// Interaction logic for FacebookGiriş.xaml
    /// </summary>
    public partial class FacebookGiriş : Page
    {
        public FacebookGiriş()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GirişYap gi = new GirişYap();
            this.NavigationService.Navigate(gi);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            string kullanıcı1 = "dilanyilmaz@gmail.com";
            string kullanıcıpass1 = "1601010";
            string kullanıcı2 = "esraozdogan@gmail.com";
            string kullanıcıpass2 = "1601011";


            //string m1r = "111";
            if (txtbox1.Text == kullanıcı1 & Passbox2.Password.ToString() == kullanıcıpass1)
            {
                MessageBox.Show(client.Hosgeldiniz("Dilan Yılmaz"));
                DR dr = new DR();
                this.NavigationService.Navigate(dr);


            }
            else if (txtbox1.Text == kullanıcı2 & Passbox2.Password.ToString()== kullanıcıpass2)
            {
                MessageBox.Show(client.Hosgeldiniz("Esra Ozdoğan"));
                DR dr = new DR();
                this.NavigationService.Navigate(dr);



            }
            else
            {
                MessageBox.Show(client.GeçersizKullanıcı());
            }
        }
    }
}
