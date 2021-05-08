using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    [Serializable]
    public abstract class DynamicFigure : Figure
    {
        public List<Point> points = new List<Point>();
        public Point leftUp;
        public Point lastDot;

        public override int LeftClick(Point point)
        {
            this.points.Add(point);
            return 1;
        }

        public override void Init(Point point)
        {
            this.leftUp = point;
        }

        public override void SetSize(Point point)
        {
            points.Add(point);
            points.Add(point);
        }

        public List<Point> GetList()
        {
            return points;
        }
        public Point GetLeftUp()
        {
            return leftUp;
        }
        public Point GetLastDot()
        {
            return lastDot;
        }

        public void SetLeftUp(Point pt)
        {
            this.leftUp = pt;
        }
        public void SetLastDot(Point pt)
        {
            this.lastDot = pt;
        }
        public void SetPoints(List<Point> points)
        {
            this.points = points;
        }
    }
}
