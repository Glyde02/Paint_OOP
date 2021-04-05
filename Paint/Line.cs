using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public class Line : SimpleFigure
    {
        public override void Draw(PaintEventArgs obj)
        {

            //SolidBrush Brush = new SolidBrush(this.brushColor);

            Point point1 = this.leftUp;
            Point point2 = this.rightDown;



            //Rectangle rect = new Rectangle(point, size);


            //obj.Graphics.FillRectangle(Brush, rect);

            

            Pen pen = new Pen(this.penColor, this.penWidth);
            if (pen.Width == 0)
                pen.Width = 1;
            obj.Graphics.DrawLine(pen, point1, point2);
            //obj.Graphics.DrawRectangle(pen, rect);


        }

        public override Figure Clone()
        {
            return new Line { };
        }

        public override void PreDraw(PaintEventArgs obj, int Horz, int Vert)
        {

            this.rightDown.X = Horz;
            this.rightDown.Y = Vert;

            Draw(obj);

        }
    }
}
