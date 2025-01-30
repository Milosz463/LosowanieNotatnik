using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string NazwaPliku { get; set; } = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowZakres windowZakres = new WindowZakres();
            windowZakres.ShowDialog();
            
                int ileLiczb = windowZakres.Ilosc;
                Random random = new Random();
                for (int i = 0; i < ileLiczb; i++)
                {
                    int liczba = random.Next(1, 101);
                    WpisaneLiczby.Text += liczba.ToString() + "\n";
                }
            
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
           SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string[] tablicaLiczb=WpisaneLiczby.Text.Split('\n');
                File.WriteAllLines(saveFileDialog.FileName, tablicaLiczb);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "plik tekstowy | *.txt";
            if (ofd.ShowDialog() == true)
            {
                NazwaPliku = ofd.FileName;
                Title = NazwaPliku;
                WpisaneLiczby.Text = File.ReadAllText(NazwaPliku);
            }
        }

    }
}
