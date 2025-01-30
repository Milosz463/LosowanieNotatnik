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

namespace WpfApp10
{
    /// <summary>
    /// Logika interakcji dla klasy WindowZakres.xaml
    /// </summary>
    public partial class WindowZakres : Window
    {
        public int Ilosc { get; set; } = 0;
        public WindowZakres windowZakres { get; set; }
        public WindowZakres()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ile = 0;
            if (int.TryParse(WpisanaLiczba.Text, out ile)) { 
            Ilosc=ile;
            }
            Close();
        }
    }
}
