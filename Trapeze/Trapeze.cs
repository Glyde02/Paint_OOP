using Paint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Trapeze
{
    public class Trapeze : SimpleFigure
    {
        public override void Draw(Graphics obj)
        {
            SolidBrush brush = new SolidBrush(this.brushColor);
            Point point = this.leftUp;
            Size size = new Size(this.width, this.height);

            if (this.width < 0)
            {
                point.X += size.Width;
                size.Width = Math.Abs(size.Width);
            }
            if (this.height < 0)
            {
                point.Y += size.Height;
                size.Height = Math.Abs(size.Height);
            }

            Point[] pointArr = {new Point(point.X+size.Width/4, point.Y),
                                new Point(point.X + 3 * size.Width / 4, point.Y),                                
                                new Point(point.X+size.Width, point.Y+size.Height),
                                new Point(point.X, point.Y+size.Height)};

            obj.FillPolygon(brush, pointArr);

            if (this.penWidth != 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);
                obj.DrawPolygon(pen, pointArr);
            }

        }

        public override Figure Clone()
        {
            return new Trapeze { };
        }

        public override void PreDraw(Graphics obj, int Horz, int Vert)
        {
            this.width = Horz - this.leftUp.X;
            this.height = Vert - this.leftUp.Y;

            Draw(obj);
        }

        public override string GetName()
        {
            return "Trapeze";
        }
    }

}
