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

namespace shapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMoveEllipse_Click(object sender, RoutedEventArgs e)
        {
            double left = Canvas.GetLeft(blue);
            double top = Canvas.GetTop(blue);

            double left1 = Canvas.GetLeft(black);
            double top1 = Canvas.GetTop(black);

            double left2 = Canvas.GetLeft(red);
            double top2 = Canvas.GetTop(red);

            double left3 = Canvas.GetLeft(yellow);
            double top3 = Canvas.GetTop(yellow);

            double left4 = Canvas.GetLeft(green);
            double top4 = Canvas.GetTop(green);


            left += 10;
            left1 += 0;
            left2 -= 10;
            left3 += 10;
            left4 -= 10;

            top += 10;
            top1 -= 10;
            top2 += 10;
            top3 -= 10;
            top4 -= 10;



            Canvas.SetLeft(blue, left);
            Canvas.SetTop(blue, top);

            Canvas.SetLeft(black, left1);
            Canvas.SetTop(black, top1);

            Canvas.SetLeft(red, left2);
            Canvas.SetTop(red, top2);

            Canvas.SetLeft(yellow, left3);
            Canvas.SetTop(yellow, top3);

            Canvas.SetLeft(green, left4);
            Canvas.SetTop(green, top4);

        }



            
        }
    }

