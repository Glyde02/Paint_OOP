﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class Circle : SimpleFigure
    {
        public override void Draw(PaintEventArgs obj)
        {

            SolidBrush brush = new SolidBrush(this.brushColor);
            Rectangle circleRect = new Rectangle(this.leftUp, new Size(this.width, this.height));

            obj.Graphics.FillEllipse(brush, circleRect);

            if (this.penWidth != 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);
                obj.Graphics.DrawEllipse(pen, circleRect);
            }

        }


        public override Figure Clone()
        {
            return new Circle { };
        }
    }
}
