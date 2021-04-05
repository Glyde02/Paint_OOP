using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    class Polygon : DynamicFigure
    {

        public override void Draw(PaintEventArgs obj)
        {
            if (this.points.Count > 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);

                this.points.Add(lastDot);
                Point[] pt = this.points.ToArray();

                obj.Graphics.DrawPolygon(pen, pt);

                //this.points.RemoveAt(this.points.Count-1);
            }
            //SolidBrush Brush = new SolidBrush(this.brushColor);

            //Point point1 = this.leftUp;
            //Point point2 = this.rightDown;


            //Rectangle rect = new Rectangle(point, size);


            //obj.Graphics.FillRectangle(Brush, rect);



            //if (pen.Width == 0)
            //   pen.Width = 1;
            //obj.Graphics.DrawLine(pen, point1, point2);
            //obj.Graphics.DrawRectangle(pen, rect);


        }

        public override void PreDraw(PaintEventArgs obj, int Horz, int Vert)
        {
            lastDot.X = Horz;
            lastDot.Y = Vert;

            if (this.points.Count > 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);

                Point lastDot = this.points[this.points.Count - 1];
                lastDot.X = Horz;
                lastDot.Y = Vert;
                this.points.Add(lastDot);

                Point[] pt = this.points.ToArray();

                obj.Graphics.DrawPolygon(pen, pt);

                this.points.RemoveAt(this.points.Count - 1);
            }
        }

        public override Figure Clone()
        {
            return new Polygon { };
        }
    }
}
