using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class JarvisAlgorithm_Fencing_WrappingGift
    {
        public class Point
        {
            public int x;
            public int y;
            public Point() { x = 0; y = 0; }
            public Point(int a, int b) { x = a; y = b; }
        }
        public IList<Point> OuterTrees()
        {
            Point p1 = new Point(1,2);
            Point p2 = new Point(2,2);
            //Point p3 = new Point(2,0);
            //Point p4 = new Point(2,4);
            //Point p5 = new Point(3,3);
            Point p6 = new Point(4,2);
            //Point p = new Point();
            Point[] points = new Point[3] {p1,p2,p6 };

            IList<Point> result = new List<Point>();

            // Find the leftmost point
            Point first = points[0];
            int firstIndex = 0;
            for (int i = 1; i < points.Count(); i++)
            {
                if (points[i].x < first.x)
                {
                    first = points[i];
                    firstIndex = i;
                }
            }

            Point endPoint = null;
            do
            {
                if (!result.Contains(first)) result.Add(first);
                endPoint = points[0];

                for (int i = 1; i < points.Count(); i++)
                {
                    if (first == endPoint || Orientation(first, endPoint, points[i]) == -1) endPoint = points[i];
                    //else if (Orientation(first, endPoint, points[i]) == 0 && !result.Contains(points[i])) result.Add(points[i]);
                }
                first = endPoint;
            } while (result[0] != endPoint);

            return result;
        }

        private int Orientation(Point p1, Point p2, Point p)
        {
            int Orin = (p2.x - p1.x) * (p.y - p1.y) - (p.x - p1.x) * (p2.y - p1.y);
            if (Orin > 0)return -1; 
            if (Orin < 0)return 1;
            return 0;
        }

    }
}
