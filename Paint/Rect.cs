using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    class Rect : Figure
    {

        public void DrawRect(Graphics obj, int dotX, int dotY, int width, int height)
        {           
            
            
            SolidBrush Brush = new SolidBrush(brushColor);
            Rectangle rect = new Rectangle(dotX, dotY, width, height);

            obj.FillRectangle(Brush, rect);
            if (penWidth != 0)
            {
                Pen Pen = new Pen(penColor, penWidth);
                obj.DrawRectangle(Pen, rect);
            }
        }

    }

}
