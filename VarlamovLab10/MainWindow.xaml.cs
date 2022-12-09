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

namespace VarlamovLab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        List<int> mas = new List<int>();
        private void Create(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Lenght.Text, out int a))
            {
                Random random = new Random();
                for (int i = 0; i < a; i++)
                {
                    mas.Add(random.Next(0, 10));
                }
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            masList.ItemsSource = null;
            masList.ItemsSource = mas;
        }

        private void Rez(object sender, RoutedEventArgs e)
        {
            int newMas = mas.Count(x => x == 5 || x == 7);
            MessageBox.Show(newMas.ToString());
        }

        private void AboutProgramm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дан массив в диапазоне [0;10]найти количество значений равных 5 и 7.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
