using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        static List<UjVendegFelvetele> vendegekLista = new List<UjVendegFelvetele>();
        // Ellenőrzi, hogy van e már hozzáadva panel
        private bool isUjpanelAdded = false;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        #region ujvendegfelvetele
        internal TextBox azonxtbx;
        internal TextBox emailxtbx;
        internal TextBox nevxtbx;
        internal TextBox anyjaNevextbx;
        internal TextBox szuletesiHelyxtbx;
        internal TextBox szuletesiIdoxtbx;
        internal TextBox orszagxtbx;
        internal TextBox iranyitoszamxtbx;
        internal TextBox varosxtbx;
        internal TextBox utcaHazszamxtbx;
        internal CheckBox vipExchbx;
        internal Button ujVendegFelveteleMentesxbtn;
        #endregion
        #region szobafoglalas
        internal ComboBox azonositasxcbx;
        internal TextBox hanyforextbx;
        internal DatePicker mikortolxdp;
        internal DatePicker meddigxdp;
        #endregion
        internal void UjvendegFelvetele_Click(object sender, RoutedEventArgs e)
        {
            // ha a panel már létezik, ne csináljon semmit

            ujpanel.Children.Clear();
            //Azonosító
            Label azonxlbl = new Label();
            azonxlbl.Content = "Azonosító:";
            azonxtbx = new TextBox();
            azonxtbx.IsEnabled = false;
            azonxtbx.Text = " ";
            //emailcim
            Label emailxlbl = new Label();
            emailxlbl.Content = "Email cím:";
            emailxtbx = new TextBox();
            //nev
            Label nevxlbl = new Label();
            nevxlbl.Content = "Név:";
            nevxtbx = new TextBox();
            //Anyja neve
            Label anyjaNevexlbl = new Label();
            anyjaNevexlbl.Content = "Anyja neve:";
            anyjaNevextbx = new TextBox();
            //születési hely
            Label szuletesiHelyxlbl = new Label();
            szuletesiHelyxlbl.Content = "Születési hely:";
            szuletesiHelyxtbx = new TextBox();
            //Születési idő
            Label szuletesiIdoxlbl = new Label();
            szuletesiIdoxlbl.Content = "Születési idő";
            szuletesiIdoxtbx = new TextBox();
            //ország
            Label orszagxlbl = new Label();
            orszagxlbl.Content = "Ország:";
            orszagxtbx = new TextBox();
            //irányítószám
            Label iranyitoszamxlbl = new Label();
            iranyitoszamxlbl.Content = "Irányítószám:";
            iranyitoszamxtbx = new TextBox();
            //város
            Label varosxlbl = new Label();
            varosxlbl.Content = "Város:";
            varosxtbx = new TextBox();
            //utca házszám
            Label utcaHazszamxlbl = new Label();
            utcaHazszamxlbl.Content = "Utca, Házszám:";
            utcaHazszamxtbx = new TextBox();
            //Vipe
            vipExchbx = new CheckBox();
            vipExchbx.Content = "Vip-e?";
            //Mentés
            ujVendegFelveteleMentesxbtn = new Button() {
                Content = "Mentés"
            };
            ujVendegFelveteleMentesxbtn.Click += ujVendegFelveteleMentes_Click;
            //ujVendegFelveteleMentesxbtn.Content = "Mentés";
            //Azonosito
                //ujpanel.Children.Add(azonxlbl);
                //ujpanel.Children.Add(azonxtbx);
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

            // Panel hozzáadva
            isUjpanelAdded = true; 
        }

        private void ujVendegFelveteleMentes_Click(object sender, RoutedEventArgs e)
        { 

            UjVendegFelvetele ujVendegFelvetele = new UjVendegFelvetele(emailxtbx.Text, nevxtbx.Text, DateTime.Now, anyjaNevextbx.Text, szuletesiHelyxtbx.Text, DateTime.Parse(szuletesiIdoxtbx.Text), orszagxtbx.Text, int.Parse(iranyitoszamxtbx.Text), varosxtbx.Text, utcaHazszamxtbx.Text, (bool)vipExchbx.IsChecked);

            // Add the new guest to the list
            vendegekLista.Add(ujVendegFelvetele);

            // Optionally, clear the input fields or provide feedback to the user
            MessageBox.Show("A vendég adatai sikeresen mentve.");
        }

        private void Szobafoglalas_Click(object sender, RoutedEventArgs e)
        {
            ujpanel.Children.Clear();
            //Combobox
            Label azonositasCbxxlbl = new Label()
            {
                Content = "Vendég neve:",
            };
            azonositasxcbx = new ComboBox();
            //textbox
            Label hanyforexlbl = new Label()
            {
                Content = "Hány fő:",
            };
            hanyforextbx = new TextBox();
            //mikoritol datepicker
            Label mikortolxlbl = new Label()
            {
                Content = "Érkezés időpontja: "
            };
            mikortolxdp = new DatePicker();
            //meddig datepicker
            Label meddigxlbl = new Label()
            {
                Content = "Távozás időpontja: "
            };
            meddigxdp = new DatePicker();

            Button foglalas = new Button()
            {
                Content = "Foglalás"
            };
            foglalas.Click += Foglalas_Click();

            ujpanel.Children.Add(azonositasCbxxlbl);
            ujpanel.Children.Add(azonositasxcbx);

            ujpanel.Children.Add(hanyforexlbl);
            ujpanel.Children.Add(hanyforextbx);

            ujpanel.Children.Add(mikortolxlbl);
            ujpanel.Children.Add(mikortolxdp);

            ujpanel.Children.Add(meddigxlbl);
            ujpanel.Children.Add(meddigxdp);

            ujpanel.Children.Add(foglalas);

            isUjpanelAdded = true;
        }

        private void Foglalas_Click()
        {
            
        }
    }
}