using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public abstract class DynamicFigure : Figure
    {
        protected List<Point> points = new List<Point>();

        protected Point leftUp;
        protected Point lastDot;

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
    }
}
