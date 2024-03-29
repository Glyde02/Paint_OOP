﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Drawing;

namespace Paint
{
    [Serializable]
    public class Rect : SimpleFigure
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

            Rectangle rect = new Rectangle(point, size);
            obj.FillRectangle(brush, rect);

            if (this.penWidth != 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);
                obj.DrawRectangle(pen, rect);
            }

        }

        public override Figure Clone()
        {
            return new Rect { };
        }

        public override void PreDraw(Graphics obj, int Horz, int Vert)
        {
            this.width = Horz - this.leftUp.X;
            this.height = Vert - this.leftUp.Y;

            Draw(obj);
        }

        public override string GetName()
        {
            return "Rect";
        }
    }
}
