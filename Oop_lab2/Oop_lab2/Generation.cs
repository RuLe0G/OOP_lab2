using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_lab2
{
    class Generation
    {
        public static Triangle GenTriangle() {
                        
            Random random = new Random();
            Point2D p1 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);
            Point2D p2 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);
            Point2D p3 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);

            return (new Triangle(p1, p2, p3));
        }

        public static Rectangle GenRectangle()
        {

            Random random = new Random();
            double disX = random.NextDouble() * 774;
            double disY = random.NextDouble() * 276;
            Point2D p1 = new Point2D(random.NextDouble() * (774 - disX), random.NextDouble() * (276 - disY));
            Point2D p2 = new Point2D(p1.GetX() + disX, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + disY);
            Point2D p3 = new Point2D(p1.GetX() + disX, p1.GetY() + disY);

            return (new Rectangle(p1, p2, p3, p4));
        }

        public static Rectangle GenSq()
        {
            Random random = new Random();
            double dis = random.NextDouble() * 276;
            Point2D p1 = new Point2D(random.NextDouble() * (774 - dis), random.NextDouble() * (276 - dis));
            Point2D p2 = new Point2D(p1.GetX() + dis, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + dis);
            Point2D p3 = new Point2D(p1.GetX() + dis, p1.GetY() + dis);

            return (new Rectangle(p1, p2, p3, p4));

        }


        public static Rectangle GenRectanglePar(double disX, double disY)
        {

            Random random = new Random();
            Point2D p1 = new Point2D(random.NextDouble() * (774 - disX), random.NextDouble() * (276 - disY));
            Point2D p2 = new Point2D(p1.GetX() + disX, p1.GetY());
            Point2D p4 = new Point2D(p1.GetX(), p1.GetY() + disY);
            Point2D p3 = new Point2D(p1.GetX() + disX, p1.GetY() + disY);

            return (new Rectangle(p1, p2, p3, p4));
        }
    }
}
