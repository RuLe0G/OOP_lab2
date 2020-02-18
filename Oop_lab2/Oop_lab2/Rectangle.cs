using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_lab2
{
    class Rectangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        private Point2D p4;


        public Rectangle(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
        {

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
        public Point2D GetPoint4()
        {
            return p4;
        }
        public void ShiftX(double value)
        {
            //foreach (Point2D point in collection)
            //{

            //}
            p1.ShiftX(p1.GetX() + value);
            p2.ShiftX(p2.GetX() + value);
            p3.ShiftX(p3.GetX() + value); 
            p4.ShiftX(p4.GetX() + value);
        }

        public void ShiftY(double value)
        {
            p1.ShiftY(p1.GetY() + value);
            p2.ShiftY(p2.GetY() + value);
            p3.ShiftY(p3.GetY() + value);
            p4.ShiftY(p4.GetY() + value);
        }

        public double GetPerimeter()
        {
            return (
                p1.GetDistance(p2) +
                p2.GetDistance(p3) +
                p3.GetDistance(p4) +
                p4.GetDistance(p1)
                );

        }

        public double GetArea()
        {

            return (Math.Sqrt((GetPerimeter()/2 - p1.GetDistance(p2)) +
                    (GetPerimeter()/2 - p2.GetDistance(p3)) +
                    (GetPerimeter()/2 - p3.GetDistance(p4)) +
                    (GetPerimeter()/2 - p4.GetDistance(p1))
                   ));
        }
    }
}
