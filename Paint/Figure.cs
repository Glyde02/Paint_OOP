using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public abstract class Figure
    {
        public Color penColor;
        protected Color brushColor;
        protected int penWidth;

        abstract public void Init(Point point);

        abstract public void Draw(Graphics obj);

        abstract public void PreDraw(Graphics obj, int Horz, int Vert);

        abstract public void SetSize(Point point);

        abstract public int LeftClick(Point point);

        abstract public string GetName();

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

        abstract public Figure Clone();

        public Color GetPenColor()
        {
            return penColor;
        }
        public int GetPenWidth()
        {
            return penWidth;
        }
        public Color GetBrushColor()
        {
            return brushColor;
        }

       
    }
}
