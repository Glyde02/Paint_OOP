using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    class Rect : SimpleFigure
    {
        public override void Draw(PaintEventArgs obj)
        {

            SolidBrush Brush = new SolidBrush(this.brushColor);

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

            obj.Graphics.FillRectangle(Brush, rect);

            if (this.penWidth != 0)
            {
                Pen pen = new Pen(this.penColor, this.penWidth);
                obj.Graphics.DrawRectangle(pen, rect);
            }

        }

        public override Figure Clone()
        {
            return new Rect { };
        }

        public override void PreDraw(PaintEventArgs obj, int Horz, int Vert)
        {

            this.width = Horz - this.leftUp.X;
            this.height = Vert - this.leftUp.Y;


            Draw(obj);
            //SolidBrush Brush = new SolidBrush(this.brushColor);          


            //Point point = this.leftUp;
            //Size size = new Size(this.width, this.height);

            //if (this.width < 0)
            //{
            //    point.X += size.Width;
            //    size.Width = Math.Abs(size.Width);
            //}
            //if (this.height < 0)
            //{
            //    point.Y += size.Height;
            //    size.Height = Math.Abs(size.Height);
            //}

            //Rectangle rect = new Rectangle(point, size);

            //obj.Graphics.FillRectangle(Brush, rect);

            //if (this.penWidth != 0)
            //{
            //    Pen pen = new Pen(this.penColor, this.penWidth);
            //    obj.Graphics.DrawRectangle(pen, rect);
            //}
        }
        //public void DrawRect(Graphics obj, int dotX, int dotY, int width, int height)
        //{           


        //    SolidBrush Brush = new SolidBrush(brushColor);
        //    Rectangle rect = new Rectangle(dotX, dotY, width, height);

        //    obj.FillRectangle(Brush, rect);
        //    if (penWidth != 0)
        //    {
        //        Pen Pen = new Pen(penColor, penWidth);
        //        obj.DrawRectangle(Pen, rect);
        //    }
        //}

    }

}
