using System;

namespace HelloWorld
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point point)
        {
            if (point == null)
            {
                throw new ArgumentNullException(nameof(point));
            }
            Move(point.X, point.Y);
        }
    }
}