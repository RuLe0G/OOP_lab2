using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_lab2
{
    class Triangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;


        public Triangle(Point2D _p1, Point2D _p2, Point2D _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }

        public Point2D GetPoint1()
        {
            return p1;
        }
        public Point2D GetPoint2()
        {
            return p2;
        }
        public Point2D GetPoint3()
        {
            return p3;
        }

        public void ShiftX(double value)
        {
            p1.ShiftX(p1.GetX() + value);
            p2.ShiftX(p2.GetX() + value);
            p3.ShiftX(p3.GetX() + value);
        }

        public void ShiftY(double value)
        {
            p1.ShiftY(p1.GetY() + value);
            p2.ShiftY(p2.GetY() + value);
            p3.ShiftY(p3.GetY() + value);
        }

        public double GetPerimeter()
        {
            return (
               p1.GetDistance(p2) +
               p2.GetDistance(p3) +
               p3.GetDistance(p1)
               );
        }

        public double GetArea()
        {
            return (Math.Sqrt((GetPerimeter()/2 *(GetPerimeter() / 2 - p1.GetDistance(p2))) +
                        (GetPerimeter() / 2 * (GetPerimeter() / 2 - p2.GetDistance(p3))) +
                        (GetPerimeter() / 2 * (GetPerimeter() / 2 - p3.GetDistance(p1)))
                       ));
        }
    }
}
