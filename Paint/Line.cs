using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    [Serializable]
    public class Line : SimpleFigure
    {
        public override void Draw(Graphics obj)
        {
            Point point1 = this.leftUp;
            Point point2 = this.rightDown;


            Pen pen = new Pen(this.penColor, this.penWidth);
            if (pen.Width == 0)
                pen.Width = 1;
            obj.DrawLine(pen, point1, point2);

        }

        public override Figure Clone()
        {
            return new Line { };
        }

        public override void PreDraw(Graphics obj, int Horz, int Vert)
        {
            this.rightDown.X = Horz;
            this.rightDown.Y = Vert;

            Draw(obj);
        }

        public override string GetName()
        {
            return "Line";
        }
    }
}
