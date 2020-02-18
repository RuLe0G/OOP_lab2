using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_lab2
{
    class Point2D
    {

        private double x;
        private double y;

        public Point2D(double _x, double _y){
            x = _x;
            y = _y;
        }

        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }

        public void ShiftX(double value)
        {
            x = value;
        }

        public void ShiftY(double value)
        {
            y = value;
        }

        public double GetDistance(Point2D other_point2D)
        {
            return (Math.Sqrt( Math.Pow((x-other_point2D.x),2) + Math.Pow((y-other_point2D.y),2)));
        }
    }


}
