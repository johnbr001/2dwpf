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
using System.Collections;
using System.Collections.ObjectModel;

namespace AcsPlusGl
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void mainButton_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Rectangle> myData = new ObservableCollection<Rectangle>();

            // initialize
            for (int i =0; i<10; i++)
            {
                // initialize
                Rectangle tmpElement = new Rectangle();
                tmpElement.Height = 10;
                tmpElement.Width = 10;

                if (i == 3)
                {
                    tmpElement.Fill = Brushes.Red;
                }
                else
                {
                    tmpElement.Fill = Brushes.Black;
                }
                
                // setting location (X, Y)
                Canvas.SetTop(tmpElement, 10 + i*10);
                Canvas.SetLeft(tmpElement, 10 + i * 10);

                // finally add it to CANVAS (Drawing area)
                myCanvas.Children.Add(tmpElement);

                // save it into an array
                myData.Add(tmpElement);

            }


            // for iteration..changing location of drawings..
            // just change using "CANVAS" (X,Y)
            Canvas.SetTop(myData[1], 200);
            Canvas.SetLeft(myData[1], 200);


        }
    }
}
