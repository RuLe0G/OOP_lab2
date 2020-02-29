using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_lab2
{
    class Generation
    {
        public Triangle GenTriangle() {
                        
            Random random = new Random();
            Point2D p1 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);
            Point2D p2 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);
            Point2D p3 = new Point2D(random.NextDouble() * (774), random.NextDouble() * 276);

           
            return (new Triangle(p1, p2, p3));
        }

    }
}
