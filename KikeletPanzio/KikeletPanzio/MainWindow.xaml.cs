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

namespace KikeletPanzio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<UjVendegFelvetele> vendegekList = new List<UjVendegFelvetele>();
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void UjvendegFelvetele_Click(object sender, RoutedEventArgs e)
        {
            StackPanel ujpanel = new StackPanel();
            //Azonosító
            Label azonxlbl = new Label();
            azonxlbl.Content = "Azonosító:";
            TextBox azonxtbx = new TextBox();
            azonxtbx.Text = " ";
            //emailcim
            Label emailxlbl = new Label();
            emailxlbl.Content = "Email cím:";
            TextBox emailxtbx = new TextBox();
            //nev
            Label nevxlbl = new Label();
            nevxlbl.Content = "Név:";
            TextBox nevxtbx = new TextBox();
            //Anyja neve
            Label anyjaNevexlbl = new Label();
            anyjaNevexlbl.Content = "Anyja neve:";
            TextBox anyjaNevextbx = new TextBox();
            //születési hely
            Label szuletesiHelyxlbl = new Label();
            szuletesiHelyxlbl.Content = "Születési hely:";
            TextBox szuletesiHelyxtbx = new TextBox();
            //Születési idő
            Label szuletesiIdoxlbl = new Label();
            szuletesiIdoxlbl.Content = "Születési idő";
            TextBox szuletesiIdoxtbx = new TextBox();
            //ország
            Label orszagxlbl = new Label();
            orszagxlbl.Content = "Ország:";
            TextBox orszagxtbx = new TextBox();
            //irányítószám
            Label iranyitoszamxlbl = new Label();
            iranyitoszamxlbl.Content = "Irányítószám:";
            TextBox iranyitoszamxtbx = new TextBox();
            //város
            Label varosxlbl = new Label();
            varosxlbl.Content = "Város:";
            TextBox varosxtbx = new TextBox();
            //utca házszám
            Label utcaHazszamxlbl = new Label();
            utcaHazszamxlbl.Content = "Utca, Házszám:";
            TextBox utcaHazszamxtbx = new TextBox();
            //Vipe
            CheckBox vipExchbx = new CheckBox();
            vipExchbx.Content = "Vip-e?";
            //Mentés
            Button ujVendegFelveteleMentesxbtn = new Button() {
                Content = "Mentés"
            };
            ujVendegFelveteleMentesxbtn.Click += ujVendegFelvetele_Click;
            //ujVendegFelveteleMentesxbtn.Content = "Mentés";

            mainPanel.Children.Add(ujpanel);
            //Azonosito
            ujpanel.Children.Add(azonxlbl);
            ujpanel.Children.Add(azonxtbx);
            //Emailcim
            ujpanel.Children.Add(emailxlbl);
            ujpanel.Children.Add(emailxtbx);
            //nev
            ujpanel.Children.Add(nevxlbl);
            ujpanel.Children.Add(nevxtbx);
            //anyja neve
            ujpanel.Children.Add(anyjaNevexlbl);
            ujpanel.Children.Add(anyjaNevextbx);
            //szüleesi hely
            ujpanel.Children.Add(szuletesiHelyxlbl);
            ujpanel.Children.Add(szuletesiHelyxtbx);
            //szuletesi ido
            ujpanel.Children.Add(szuletesiIdoxlbl);
            ujpanel.Children.Add(szuletesiIdoxtbx);
            //orszag   
            ujpanel.Children.Add(orszagxlbl);
            ujpanel.Children.Add(orszagxtbx);
            //iranyitoszam
            ujpanel.Children.Add(iranyitoszamxlbl);
            ujpanel.Children.Add(iranyitoszamxtbx);
            // varos
            ujpanel.Children.Add(varosxlbl);
            ujpanel.Children.Add(varosxtbx);
            //utca hazszam
            ujpanel.Children.Add(utcaHazszamxlbl);
            ujpanel.Children.Add(utcaHazszamxtbx);
            //vip e
            ujpanel.Children.Add(vipExchbx);
            // mentés
            ujpanel.Children.Add(ujVendegFelveteleMentesxbtn);
        }

        private void ujVendegFelvetele_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}