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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Calc.FV;

namespace Calculator
{

    
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string historyValue;
        dynamic densityValue;


        private void Material_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string material = ((ComboBoxItem)Material.SelectedItem).Content.ToString();
            Marka.ItemsSource = metal.Where(m => m.Metals == material).Select(p => p.Name).ToList();
            if (material == null) { return; }

            switch (material)
            {
                case "Цинк":
                    Density.Text = "7,1";
                    break;
                case "Сталь":
                    Density.Text = "7,85";
                    break;
                case "Нержавеющая сталь":
                    Density.Text = "7,8";
                    break;
                case "Алюминий":
                    Density.Text = "2,7";
                    break;
                case "Бронза":
                    Density.Text = "8,8";
                    break;
                case "Латунь":
                    Density.Text = "8,73";
                    break;
                case "Медь":
                    Density.Text = "8,96";
                    break;
                case "Титан":
                    Density.Text = "4,33";
                    break;
                case "Чугун":
                    Density.Text = "7,87";
                    break;
            }
        }

        private void Marka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string p = Marka.SelectedItem as string;

            if (p != null)
            {
                 densityValue = metal.Where(m => m.Name == p).Select(d => d.Density).FirstOrDefault();
                 historyValue = metal.Where(m => m.Name == p).Select(h => h.History).FirstOrDefault();

                Density.Text = Convert.ToString(densityValue);
                if (History.IsChecked == true)
                {
                    HistoryLabel.Content = Convert.ToString(historyValue);
                }
            }
            else
            {
                if (History.IsChecked == true)
                {
                    HistoryLabel.Content = "Выберите металл";
                }
                Density.Text = "Выберите металл";
                
            }
        }
        private void History_Click(object sender, RoutedEventArgs e)
        {
            if (History.IsChecked == true)
            {
                HistoryLabel.Content = Convert.ToString(historyValue);
            }
            else
            {
                HistoryLabel.Content = "";
            }
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            double a, b, t, l, d, v = 0;
            //a - сторона а, b - сторона b, t - толщина, l - длина, d - плотность


            // Используем try and catch для проверки. Если в блоке try встречается ошибка, будет выполнен блок catch

            try
            {
                d = Math.Abs(Convert.ToDouble(Density.Text));
                if (ygolok.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    b = Math.Abs(Convert.ToDouble(storona_b.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000; // Переводим из м в мм
                    }
                    v = (a * l - (a - t) * l + b * t * l) * d;
                }
                else if (list.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    b = Math.Abs(Convert.ToDouble(storona_b.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    v = a * b * t * d;
                }
                else if (truba.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = Math.PI * (a - t) * t * l * d;
                }
                else if (krug_pr.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = Math.PI * Math.Pow(a, 2) * l * d;
                }
                else if (kv_truba.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    b = Math.Abs(Convert.ToDouble(storona_b.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = l * (Math.Pow(a, 2) - Math.Pow(b, 2)) * d;
                }
                else if (kvadrat.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    v = Math.Pow(a, 2) * t * d;
                }
                else if (shveller.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    b = Math.Abs(Convert.ToDouble(storona_b.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = (b * t + (a - t) * (l - t)) * t * d;
                }
                else if (lenta.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = a * t * l * d;
                }
                else if (balka.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    b = Math.Abs(Convert.ToDouble(storona_b.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = a * b * l * d;
                }
                else if (sixgran.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = (3 * Math.Sqrt(3) / 2) * (Math.Pow(a, 2) * Math.Sqrt(3) / 3) * l * d;
                }
                else if (relci.IsChecked == true)
                {
                    a = Math.Abs(Convert.ToDouble(storona_a.Text));
                    b = Math.Abs(Convert.ToDouble(storona_b.Text));
                    t = Math.Abs(Convert.ToDouble(tolshina.Text));
                    l = Math.Abs(Convert.ToDouble(dlina.Text));
                    if (l != 0)
                    {
                        l /= 1000;
                    }
                    v = l * (a * t + b * t - (a - t) * (b - t)) * d;
                }
                v /= 1000000;
                result.Text = Convert.ToString(v);
            }
            catch
            {
                result.Text = "Ошибка при вводе данных";
            }
        }
    }
}
