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
    public class Polygon : DynamicFigure
    {

        public override void Draw(Graphics obj)
        {
            if (this.points.Count > 0)
            {
                if (this.points[this.points.Count-1] != lastDot)
                    this.points.Add(lastDot);
                Point[] pt = this.points.ToArray();                

                SolidBrush brush = new SolidBrush(this.brushColor);
                obj.FillPolygon(brush, pt);


                if (this.penWidth > 0)
                {
                    Pen pen = new Pen(this.penColor, this.penWidth);
                    obj.DrawPolygon(pen, pt);
                }
                else
                {
                    Pen pen = new Pen(this.brushColor, 1);
                    obj.DrawPolygon(pen, pt);
                }
                
            }            
        }

        public override void PreDraw(Graphics obj, int Horz, int Vert)
        {
            this.lastDot.X = Horz;
            this.lastDot.Y = Vert;

            if (this.points.Count > 0)
            {     
                Point lastDot = this.points[this.points.Count - 1];
                lastDot.X = Horz;
                lastDot.Y = Vert;
                this.points.Add(lastDot);

                Point[] pt = this.points.ToArray();


                SolidBrush brush = new SolidBrush(this.brushColor);
                obj.FillPolygon(brush, pt);

                if (this.penWidth > 0)
                {
                    Pen pen = new Pen(this.penColor, this.penWidth);
                    obj.DrawPolygon(pen, pt);
                } else
                {
                    Pen pen = new Pen(this.brushColor, 1);
                    obj.DrawPolygon(pen, pt);
                }

                this.points.RemoveAt(this.points.Count - 1);
            }
        }

        public override Figure Clone()
        {
            return new Polygon { };
        }

        public override string GetName()
        {
            return "Polygon";
        }
    }
}
