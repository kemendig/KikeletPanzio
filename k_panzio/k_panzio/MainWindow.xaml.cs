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

namespace k_panzio
{
    public partial class MainWindow : Window
    {
        private Panzio panzio;
        public BindingList<Szoba> Szobak { get; set; }
        public BindingList<Vendeg> VendegLista { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            panzio = new Panzio();
            Szobak = new BindingList<Szoba>();
            VendegLista = new BindingList<Vendeg>();

            InitializeSzobak();
            dataGridSzobak.ItemsSource = Szobak;
            dataGridVendeg.ItemsSource = VendegLista;
        }

        private void InitializeSzobak()
        {
            for (int i = 1; i <= 6; i++)
            {
                Szobak.Add(new Szoba
                {
                    SzobaSzam = i,
                    FerohelyekSzama = i + 1,
                    Ar = 6000 + (i * 1000)
                });
            }
        }

        private void FoglalasButton_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridSzobak.SelectedItem != null && dataGridVendeg.SelectedItem != null)
            {
                Szoba selectedSzoba = (Szoba)dataGridSzobak.SelectedItem;
                Vendeg selectedVendeg = (Vendeg)dataGridVendeg.SelectedItem;

                DateTime erkezesDatum = datePickerErkezes.SelectedDate ?? DateTime.MinValue;
                DateTime tavozasDatum = datePickerTavozas.SelectedDate ?? DateTime.MinValue;

                if (erkezesDatum != DateTime.MinValue && tavozasDatum != DateTime.MinValue)
                {
                    if (panzio.Foglalas(selectedSzoba.SzobaSzam, selectedVendeg, erkezesDatum, tavozasDatum))
                    {
                        MessageBox.Show($"A {selectedVendeg.Nev} nevű vendég foglalta a(z) {selectedSzoba.SzobaSzam}. szobát.");
                    }
                    else
                    {
                        MessageBox.Show("A szoba már foglalt ebben az időpontban.");
                    }
                }
                else
                {
                    MessageBox.Show("Kérlek, válassz érkezési és távozási dátumot!");
                }
            }
            else
            {
                MessageBox.Show("Kérlek, válassz szobát és vendéget!");
            }
        }

        private void RegisztracioButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNev.Text) && datePickerSzuletes.SelectedDate != null && !string.IsNullOrEmpty(textBoxEmail.Text))
            {
                string azonosito = $"{textBoxNev.Text}_{DateTime.Now:yyyyMMddHHmmss}";
                bool isVIP = checkBoxVIP.IsChecked ?? false;

                Vendeg ujVendeg = new Vendeg
                {
                    Azonosito = azonosito,
                    Nev = textBoxNev.Text,
                    SzuletesiDatum = datePickerSzuletes.SelectedDate.Value,
                    Email = textBoxEmail.Text,
                    VIP = isVIP
                };

                VendegLista.Add(ujVendeg);
                MessageBox.Show("Vendég regisztrálva.");
            }
            else
            {
                MessageBox.Show("Minden mezőt tölts ki a regisztrációhoz!");
            }
        }
    }

    public class Szoba
    {
        public int SzobaSzam { get; set; }
        public int FerohelyekSzama { get; set; }
        public decimal Ar { get; set; }
    }

    public class Vendeg
    {
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public string Email { get; set; }
        public bool VIP { get; set; }
    }

    public class Panzio
    {
        private Dictionary<int, (Vendeg, DateTime, DateTime)> foglalasok;

        public Panzio()
        {
            foglalasok = new Dictionary<int, (Vendeg, DateTime, DateTime)>();
        }

        public bool Foglalas(int szobaSzam, Vendeg vendeg, DateTime erkezesDatum, DateTime tavozasDatum)
        {
            if (!foglalasok.ContainsKey(szobaSzam))
            {
                var foglalas = (vendeg, erkezesDatum, tavozasDatum);
                foglalasok.Add(szobaSzam, foglalas);
                return true;
            }

            // Ellenőrzés, hogy a szoba szabad-e az adott időpontban
            var foglalasIdopontok = foglalasok[szobaSzam];
            foreach (var item in foglalasok.Values)
            {
                if (erkezesDatum < item.Item3 && tavozasDatum > item.Item2)
                {
                    return false;
                }
            }

            foglalasok[szobaSzam] = (vendeg, erkezesDatum, tavozasDatum);
            return true;
        }
    }
}
