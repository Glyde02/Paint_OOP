using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    abstract class Figure
    {
        public Color penColor;
        protected Color brushColor;
        protected int penWidth;

        abstract public void Init(Point point);

        abstract public void Draw(PaintEventArgs obj);

        abstract public void SetSize(Point point);



        public void SetPenColor(Color color)
        {               
            this.penColor = color;            
        }

        public void SetBrushColor(Color color)
        {            
            this.brushColor = color;
        }

        public void SetPenWidth(int width)
        {
            this.penWidth = width;
        }
    }
}
