using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class Circle : Figure
    {

        public void DrawCircle(Graphics obj, int dotX, int dotY, int width, int height)
        {

            

            SolidBrush brush = new SolidBrush(brushColor);
            Rectangle circleRect = new Rectangle(dotX, dotY, width, height);

            obj.FillEllipse(brush, circleRect);

            if (penWidth != 0)
            {
                Pen pen = new Pen(penColor, penWidth);
                obj.DrawEllipse(pen, circleRect);
            }
        }

    }
}
