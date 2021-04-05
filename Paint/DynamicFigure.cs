using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    abstract class DynamicFigure : Figure
    {
        protected List<Point> points = new List<Point>();

        //
        //
        //

        protected Point leftUp;
        protected Point rightDown;
        protected int width;
        protected int height;

        public override int LeftClick(Point point)
        {
            this.points.Add(point);
            //Draw();

            return 1;
        }


        //
        //
        //

        public override void Init(Point point)
        {
            this.leftUp = point;
        }

        public override void SetSize(Point point)
        {
            points.Add(point);
            points.Add(point);

            //this.rightDown = point;

            //this.width = Math.Abs(this.leftUp.X - point.X);
            //this.height = Math.Abs(this.leftUp.Y - point.Y);
            //this.width = point.X - this.leftUp.X;
            //this.height = point.Y - this.leftUp.Y;
        }

    }
}
