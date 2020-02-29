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


        Rectangle rectangle = null;
        Triangle triangle = null;

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


        private void clickTriangle(object sender, RoutedEventArgs e)
        {
            drawTriangle(Generation.GenTriangle());
        }

        private void drawTriangle(Triangle trian)
        {
            
            drawLine(trian.GetPoint1(), trian.GetPoint2());
            drawLine(trian.GetPoint2(), trian.GetPoint3());
            drawLine(trian.GetPoint3(), trian.GetPoint1());

            Stat.Content = ("Координаты вершин: \n" + "p1 - " + trian.GetPoint1().GetX().ToString("0.00") + ", " + trian.GetPoint1().GetY().ToString("0.00") + "\n"
                + "p2 - " + trian.GetPoint2().GetX().ToString("0.00") + ", " + trian.GetPoint2().GetY().ToString("0.00") + "\n"
                + "p3 - " + trian.GetPoint3().GetX().ToString("0.00") + ", " + trian.GetPoint3().GetY().ToString("0.00") + "\n"
                + "Периметр - " + trian.GetPerimeter().ToString("0.00") + "\n"
                + "Площадь - " + trian.GetArea().ToString("0.00"));
        }

        private void clickRectangle(object sender, RoutedEventArgs e)
        {
            triangle = null;
            Random random = new Random();
            double disX = random.NextDouble() * 774;
            double disY = random.NextDouble() * 276;
            Point2D p1 = new Point2D(random.NextDouble() * (774 - disX), random.NextDouble() * (276 - disY));
            Point2D p2 = new Point2D(p1.GetX() + disX, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + disY);
            Point2D p3 = new Point2D(p1.GetX() + disX, p1.GetY() + disY);

            rectangle = new Rectangle(p1, p2, p3, p4);

            drawRectangle(rectangle);

        }

        private void drawRectangle(Rectangle rect)
        {

            drawLine(rect.GetPoint1(), rect.GetPoint2());
            drawLine(rect.GetPoint2(), rect.GetPoint3());
            drawLine(rect.GetPoint3(), rect.GetPoint4());
            drawLine(rect.GetPoint4(), rect.GetPoint1());

            Stat.Content = ("Координаты вершин: \n" + "p1 - " + rect.GetPoint1().GetX().ToString("0.00") + ", " + rect.GetPoint1().GetY().ToString("0.00") + "\n"
                 + "p2 - " + rect.GetPoint2().GetX().ToString("0.00") + ", " + rect.GetPoint2().GetY().ToString("0.00") + "\n"
                 + "p3 - " + rect.GetPoint3().GetX().ToString("0.00") + ", " + rect.GetPoint3().GetY().ToString("0.00") + "\n"
                 + "p4 - " + rect.GetPoint4().GetX().ToString("0.00") + ", " + rect.GetPoint4().GetY().ToString("0.00") + "\n"
                 + "Периметр - " + rect.GetPerimeter().ToString("0.00") + "\n"
                 + "Площадь - " + rect.GetArea().ToString("0.00"));

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            Stat.Content = ("Координаты вершин: \n");
            SliderX.Value = 0;
            SliderY.Value = 0;
            rectangle = null;
            triangle = null;
        }

        private void Sq_Click(object sender, RoutedEventArgs e)
        {

            Random random = new Random();
            double dis = random.NextDouble() * 276;
            Point2D p1 = new Point2D(random.NextDouble() * (774 - dis), random.NextDouble() * (276 - dis));
            Point2D p2 = new Point2D(p1.GetX() + dis, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + dis);
            Point2D p3 = new Point2D(p1.GetX() + dis, p1.GetY() + dis);

            rectangle = new Rectangle(p1, p2, p3, p4);

            drawRectangle(rectangle);

        }

        private void SliderX_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (rectangle != null)
            {
                rectangle.GetPoint1().ShiftX(rectangle.GetPoint1().GetX() - double.Parse(SliderX.Value.ToString()));
                rectangle.GetPoint2().ShiftX(rectangle.GetPoint2().GetX() - double.Parse(SliderX.Value.ToString()));
                rectangle.GetPoint3().ShiftX(rectangle.GetPoint3().GetX() - double.Parse(SliderX.Value.ToString()));
                rectangle.GetPoint4().ShiftX(rectangle.GetPoint4().GetX() - double.Parse(SliderX.Value.ToString()));
                canvas.Children.Clear();
                drawRectangle(rectangle);
            }

            if (triangle != null)
            {
                triangle.GetPoint1().ShiftX(triangle.GetPoint1().GetX() - double.Parse(SliderX.Value.ToString()));
                triangle.GetPoint2().ShiftX(triangle.GetPoint2().GetX() - double.Parse(SliderX.Value.ToString()));
                triangle.GetPoint3().ShiftX(triangle.GetPoint3().GetX() - double.Parse(SliderX.Value.ToString()));

                canvas.Children.Clear();
                drawTriangle(triangle);


            }

            SliderX.Value = 0;
        }

        private void SliderY_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (rectangle != null)
            {
                rectangle.GetPoint1().ShiftY(rectangle.GetPoint1().GetY() - double.Parse(SliderY.Value.ToString()));
                rectangle.GetPoint2().ShiftY(rectangle.GetPoint2().GetY() - double.Parse(SliderY.Value.ToString()));
                rectangle.GetPoint3().ShiftY(rectangle.GetPoint3().GetY() - double.Parse(SliderY.Value.ToString()));
                rectangle.GetPoint4().ShiftY(rectangle.GetPoint4().GetY() - double.Parse(SliderY.Value.ToString()));
                canvas.Children.Clear();
                drawRectangle(rectangle);
            }

            if (triangle != null)
            {
                triangle.GetPoint1().ShiftY(triangle.GetPoint1().GetY() - double.Parse(SliderY.Value.ToString()));
                triangle.GetPoint2().ShiftY(triangle.GetPoint2().GetY() - double.Parse(SliderY.Value.ToString()));
                triangle.GetPoint3().ShiftY(triangle.GetPoint3().GetY() - double.Parse(SliderY.Value.ToString()));

                canvas.Children.Clear();
                drawTriangle(triangle);


            }

            SliderY.Value = 0;
        }
    }
}
