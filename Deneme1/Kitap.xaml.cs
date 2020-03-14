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
    /// Interaction logic for Kitap.xaml
    /// </summary>
    public partial class Kitap : Page
    {
        public Kitap()
        {
            InitializeComponent();
        }
        static int birekleme;
        static int ikiekleme;
        static int üçekleme;
        static int dörtrekleme;

        static double hesap=0;
       
        Service1Client client = new Service1Client("BasicHttpBinding_IService1");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DR d = new DR();
            this.NavigationService.Navigate(d);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Barkod b = new Barkod();
            this.NavigationService.Navigate(b);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Arama a = new Arama();
            this.NavigationService.Navigate(a);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Label1.Content = "Çok Satanlar";
            //Button1.Background.ImageBrush ImageSource= "C:/Users/hp/Desktop/9786053113959.png";
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Label1.Content = "Çok Satanlar";
            KitapKategoriler k = new KitapKategoriler();
            this.NavigationService.Navigate(k);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(client.FavorilereEklendi());
        }

      

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(client.FavorilereEklendi());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Sepet spt = new Sepet();
            this.NavigationService.Navigate(spt);

            spt.spt1.Content = hesap.ToString();
           
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(client.FavorilereEklendi());
        }

      

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            GirişYap gi = new GirişYap();
            this.NavigationService.Navigate(gi);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            GirişYap gi = new GirişYap();
            this.NavigationService.Navigate(gi);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Sepet s = new Sepet();
            this.NavigationService.Navigate(s);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(client.FavorilereEklendi());
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //**********************1.hesap ekleme butonu********************
            birekleme++;
            hesap = +client.ekleme(hesap, Convert.ToDouble(lbl1.Content));
           // MessageBox.Show(hesap.ToString());

        }
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            //*********************2.hesap ekleme butonu************************
            ikiekleme++;
            hesap = +client.ekleme(hesap, Convert.ToDouble(txtbox1.Text));
            //MessageBox.Show(hesap.ToString());
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //********************************3.hesap ekleme butonu******************
            üçekleme++;
            hesap = +client.ekleme(hesap, Convert.ToDouble(lbl2.Content.ToString()));
            //MessageBox.Show(hesap.ToString());
        }
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            //*********************************4.hesap ekleme butonu*********************
            dörtrekleme++;
            hesap = +client.ekleme(hesap, Convert.ToDouble(lbl3.Content));
            //MessageBox.Show(hesap.ToString());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //*************************1.kitap cıkatma **************************
            if (birekleme != 0 & birekleme > 0)
            {
                hesap = +client.silme(hesap, Convert.ToDouble(lbl1.Content));
                //MessageBox.Show(hesap.ToString());
                if (birekleme==0)
                {
                    

                }
                birekleme--;
            }

            
            
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            //*************************2.kitap cıkatma **************************


            if (ikiekleme != 0 & ikiekleme > 0)
            {

                hesap = +client.silme(hesap, Convert.ToDouble(txtbox1.Text));
                //MessageBox.Show(hesap.ToString());
                if (ikiekleme== 0)
                {
                   // MessageBox.Show("silme yapamazsınız");

                }
                ikiekleme--;
            }

           
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            //*************************3.kitap cıkatma **************************
            if (üçekleme != 0 & üçekleme>0)
            {
                hesap = +client.silme(hesap, Convert.ToDouble(lbl2.Content.ToString()));
                //MessageBox.Show(hesap.ToString());
                if (üçekleme == 0)
                {
                   // MessageBox.Show("silme yapamazsınız");

                }
                üçekleme--;
            }

            
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            //*************************4.kitap cıkatma **************************
            if (dörtrekleme != 0 & dörtrekleme > 0)
            {
                hesap = +client.silme(hesap, Convert.ToDouble(lbl3.Content));
               // MessageBox.Show(hesap.ToString());
                if (dörtrekleme == 0)
                {
                   // MessageBox.Show("silme yapamazsınız");

                }
                dörtrekleme--;
            }

            
        }
    }

}