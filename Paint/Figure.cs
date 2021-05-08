using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Paint
{
    [Serializable]
    public abstract class Figure
    {
        [XmlIgnore]
        public Color penColor;
        [XmlIgnore]
        public Color brushColor;


        [XmlElement("penColor")]
        public int penAsArgb
        {
            get { return penColor.ToArgb(); }
            set { penColor = Color.FromArgb(value); }
        }

        [XmlElement("brushColor")]
        public int brushAsArgb
        {
            get { return brushColor.ToArgb(); }
            set { brushColor = Color.FromArgb(value); }
        }

        public int penWidth;

        abstract public void Init(Point point);

        abstract public void Draw(Graphics obj);

        abstract public void PreDraw(Graphics obj, int Horz, int Vert);

        abstract public void SetSize(Point point);

        abstract public int LeftClick(Point point);

        abstract public string GetName();

        public void SetPenColor(Color color)
        {
            this.penColor = color;
            //this.penColor = Color.Red;
        }

        public void SetBrushColor(Color color)
        {
            this.brushColor = color;
            //this.brushColor = Color.Black;
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
