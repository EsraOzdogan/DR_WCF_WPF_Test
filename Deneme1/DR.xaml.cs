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

namespace Deneme1
{
    /// <summary>
    /// Interaction logic for DR.xaml
    /// </summary>
    public partial class DR : Page
    {
        public DR()
        {
            InitializeComponent();
        }
        GirişYap g = new GirişYap();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EKitap ek = new EKitap();
            this.NavigationService.Navigate(ek);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Kitap k= new Kitap();
            this.NavigationService.Navigate(k);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Arama a=new Arama();
            this.NavigationService.Navigate(a);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            GirişYap g = new GirişYap();
            this.NavigationService.Navigate(g);
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SporOutdoor so = new SporOutdoor();
            this.NavigationService.Navigate(so);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Barkod b = new Barkod();
            this.NavigationService.Navigate(b);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        { 
            DRHakkında dr = new DRHakkında();
            this.NavigationService.Navigate(dr);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            GirişYap g = new GirişYap();
            this.NavigationService.Navigate(g);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
           Müzik m= new Müzik();
            this.NavigationService.Navigate(m);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        { 
            Kırtasiye k = new Kırtasiye();
            this.NavigationService.Navigate(k);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Elektronik el = new Elektronik();
            this.NavigationService.Navigate(el);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            OyunKonsol o = new OyunKonsol();
            this.NavigationService.Navigate(o);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            HobiOyuncak ho = new HobiOyuncak();
            this.NavigationService.Navigate(ho);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            KişiselÜrün kü = new KişiselÜrün();
            this.NavigationService.Navigate(kü);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Film f = new Film();
            this.NavigationService.Navigate(f);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            FacebookGiriş fg = new FacebookGiriş();
            this.NavigationService.Navigate(fg);
        }
    }
}
