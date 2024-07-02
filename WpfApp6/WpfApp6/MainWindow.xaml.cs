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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bb3.Visibility = Visibility.Hidden;
            bal2.Visibility = Visibility.Hidden;
            bb4.Visibility = Visibility.Hidden;
            bal3.Visibility = Visibility.Hidden;
            lb1.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            bb5.Visibility = Visibility.Hidden;
            lb5.Visibility = Visibility.Hidden;
            bb7.Visibility = Visibility.Hidden;

        }
        int k = 10000;
        private void bb1_Click(object sender, RoutedEventArgs e)
        {
            bb3.Visibility = Visibility.Visible;
            bal2.Visibility = Visibility.Visible;
            lb1.Visibility = Visibility.Visible;
            bal2.Text = "";
        }

        private void bb2_Click(object sender, RoutedEventArgs e)
        {
            bb4.Visibility = Visibility.Visible;
            bal3.Visibility = Visibility.Visible;
            lb2.Visibility = Visibility.Visible;
            bal3.Text = "";
        }

        private void bal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bal2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bb3_Click(object sender, RoutedEventArgs e)
        {
           
           
            var h = bal.Text;
            int x= Convert.ToInt32(h);
            var h1 = bal2.Text;
            int y= Convert.ToInt32(h1);
           
            if (y > x)
            {
                bal.Text = "Недостаточно средств на счету";
                bb5.Visibility = Visibility.Visible;
            }
           


            if (x>=y) {
                if (y >= 1)
                {
                    bal.Text = Convert.ToString(x - y);
                    bb3.Visibility = Visibility.Hidden;
                    bal2.Visibility = Visibility.Hidden;
                    lb1.Visibility = Visibility.Hidden;
                    k = x - y;
                }
                else
                {
                    
                    bal.Text = "Некоректный ввод";
                    bb5.Visibility = Visibility.Visible;

                }
            }
           
            
           
        }

        private void bal3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bb4_Click(object sender, RoutedEventArgs e)
        {
            var h = bal.Text;
            int x = Convert.ToInt32(h);
            var h1 = bal3.Text;
            int y = Convert.ToInt32(h1);
            
            if (y < 1)
            {
                bal.Text = "Некоректный ввод";
                bb5.Visibility = Visibility.Visible;
            }


            else
            {
                bal.Text = Convert.ToString(x + y);
                bb4.Visibility = Visibility.Hidden;
                bal3.Visibility = Visibility.Hidden;
                lb2.Visibility = Visibility.Hidden;
                k=x+ y;
                
            }
           
        }

        private void bb5_Click(object sender, RoutedEventArgs e)
        {
            bal.Text=Convert.ToString(k);
            bal2.Text = "";
            bal3.Text = "";
            bb5.Visibility = Visibility.Hidden;
        }

        private void bb6_Click(object sender, RoutedEventArgs e)
        {
            lb5.Visibility = Visibility.Visible;
            bb7.Visibility = Visibility.Visible;
            bb1.Visibility = Visibility.Hidden;
            bb2.Visibility = Visibility.Hidden;
            bb3.Visibility = Visibility.Hidden;
            bal2.Visibility = Visibility.Hidden;
            bb4.Visibility = Visibility.Hidden;
            bal3.Visibility = Visibility.Hidden;
            lb1.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            bb5.Visibility = Visibility.Hidden;
            bb6.Visibility = Visibility.Hidden;
            lb4.Visibility = Visibility.Hidden;
            bal.Visibility = Visibility.Hidden;

        }

        private void bb7_Click(object sender, RoutedEventArgs e)
        {
            win.Close();
           
        }
    }


}
