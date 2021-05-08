using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Paint
{
    [Serializable]
    public class Polyline : DynamicFigure
    {

        public override void Draw(Graphics obj)
        {
            if (this.points.Count > 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);

                if (this.points[this.points.Count-1] != lastDot)
                    this.points.Add(lastDot);
                Point[] pt = this.points.ToArray();

                obj.DrawLines(pen, pt);
            }  
        }

        public override void PreDraw(Graphics obj, int Horz, int Vert)
        {
            this.lastDot.X = Horz;
            this.lastDot.Y = Vert;

            if (this.points.Count > 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);

                Point lastDot = this.points[this.points.Count-1];
                lastDot.X = Horz;
                lastDot.Y = Vert;
                this.points.Add(lastDot);

                Point[] pt = this.points.ToArray();

                obj.DrawLines(pen, pt);

                this.points.RemoveAt(this.points.Count - 1);
            }
        }

        public override Figure Clone()
        {
            return new Polyline { };
        }

        public override string GetName()
        {
            return "Polyline";
        }
    }
}
