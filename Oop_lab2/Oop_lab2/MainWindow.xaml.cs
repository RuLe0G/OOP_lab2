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

            

            //Triangle triangle = new Triangle(p1, p2, p3);
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

        private void drawTriangle(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            Point2D p1 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);
            Point2D p2 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);
            Point2D p3 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);

            Triangle triangle = new Triangle(p1, p2, p3);

            drawLine(triangle.GetPoint1(), triangle.GetPoint2());
            drawLine(triangle.GetPoint2(), triangle.GetPoint3());
            drawLine(triangle.GetPoint3(), triangle.GetPoint1());

            Stat.Content = ("Координаты вершин: \n" + "p1 - " + triangle.GetPoint1().GetX().ToString("0.00") + ", " + triangle.GetPoint1().GetY().ToString("0.00") + "\n"
                + "p2 - " + triangle.GetPoint2().GetX().ToString("0.00") + ", " + triangle.GetPoint2().GetY().ToString("0.00") + "\n"
                + "p3 - " + triangle.GetPoint3().GetX().ToString("0.00") + ", " + triangle.GetPoint3().GetY().ToString("0.00") + "\n"
                + "Периметр - " + triangle.GetPerimeter().ToString("0.00") + "\n"
                + "Площадь - " + triangle.GetArea().ToString("0.00"));
        }

        private void drawRectangle(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double disX = random.NextDouble() * 774;
            double disY = random.NextDouble() * 276;
            Point2D p1 = new Point2D(random.NextDouble() * (774 - disX), random.NextDouble() * (276 - disY));
            Point2D p2 = new Point2D(p1.GetX() + disX, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + disY);
            Point2D p3 = new Point2D(p1.GetX() + disX, p1.GetY() + disY);

            Rectangle rectangle = new Rectangle(p1, p2, p3, p4);


            drawLine(rectangle.GetPoint1(), rectangle.GetPoint2());
            drawLine(rectangle.GetPoint2(), rectangle.GetPoint3());
            drawLine(rectangle.GetPoint3(), rectangle.GetPoint4());
            drawLine(rectangle.GetPoint4(), rectangle.GetPoint1());

            Stat.Content = ("Координаты вершин: \n" + "p1 - " + rectangle.GetPoint1().GetX().ToString("0.00") + ", " + rectangle.GetPoint1().GetY().ToString("0.00") + "\n"
                 + "p2 - " + rectangle.GetPoint2().GetX().ToString("0.00") + ", " + rectangle.GetPoint2().GetY().ToString("0.00") + "\n"
                 + "p3 - " + rectangle.GetPoint3().GetX().ToString("0.00") + ", " + rectangle.GetPoint3().GetY().ToString("0.00") + "\n"
                 + "p4 - " + rectangle.GetPoint4().GetX().ToString("0.00") + ", " + rectangle.GetPoint4().GetY().ToString("0.00") + "\n"
                 + "Периметр - " + rectangle.GetPerimeter().ToString("0.00") + "\n"
                 + "Площадь - " + rectangle.GetArea().ToString("0.00"));
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Stat.Content = ("Координаты вершин: \n");
            SliderX.Value = 0;
            SliderY.Value = 0;

        }

        private void Sq_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            double dis = random.NextDouble() * 276;
            Point2D p1 = new Point2D(random.NextDouble() * (774-dis), random.NextDouble() * (276- dis));
            Point2D p2 = new Point2D(p1.GetX() + dis, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + dis);
            Point2D p3 = new Point2D(p1.GetX() + dis, p1.GetY() + dis);

            Rectangle rectangle = new Rectangle(p1, p2, p3, p4);




            drawLine(rectangle.GetPoint1(), rectangle.GetPoint2());
            drawLine(rectangle.GetPoint2(), rectangle.GetPoint3());
            drawLine(rectangle.GetPoint3(), rectangle.GetPoint4());
            drawLine(rectangle.GetPoint4(), rectangle.GetPoint1());

            Stat.Content = ("Координаты вершин: \n" + "p1 - " + rectangle.GetPoint1().GetX().ToString("0.00") + ", " + rectangle.GetPoint1().GetY().ToString("0.00") + "\n"
                 + "p2 - " + rectangle.GetPoint2().GetX().ToString("0.00") + ", " + rectangle.GetPoint2().GetY().ToString("0.00") + "\n"
                 + "p3 - " + rectangle.GetPoint3().GetX().ToString("0.00") + ", " + rectangle.GetPoint3().GetY().ToString("0.00") + "\n"
                 + "p4 - " + rectangle.GetPoint4().GetX().ToString("0.00") + ", " + rectangle.GetPoint4().GetY().ToString("0.00") + "\n"
                 + "Периметр - " + rectangle.GetPerimeter().ToString("0.00") + "\n"
                 + "Площадь - " + rectangle.GetArea().ToString("0.00"));
        }
    }
}
