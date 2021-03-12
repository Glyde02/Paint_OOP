using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    abstract class Figure
    {
        protected Color penColor;
        protected Color brushColor;
        protected int penWidth;

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
