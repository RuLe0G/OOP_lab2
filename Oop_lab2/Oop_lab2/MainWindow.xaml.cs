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

namespace Oop_lab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Point2D begin = new Point2D(10, 50);
            Point2D end = new Point2D(10, 10);

            drawLine(begin, end);
            
        }

        private void drawLine(Point2D begin, Point2D end)
        {
            Line line = new Line();
            line.Stroke = Brushes.Red;
            line.StrokeThickness = 5;
            line.X1 = begin.GetX();
            line.Y1 = begin.GetY();
            line.X2 = end.GetX();
            line.Y2 = end.GetY();
            canvas.Children.Add(line);
        }

        private void drawTriangle(Triandle triandle)
        {

        }

        private void drawRectangle(Rectangle rectangle)
        {

        }
    }
}
