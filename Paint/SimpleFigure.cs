using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    public abstract class SimpleFigure : Figure
    {
        protected Point leftUp;
        protected Point rightDown;
        protected int width;
        protected int height;

        public override void Init(Point point)
        {
            this.leftUp = point;
        }

        public override void SetSize(Point point)
        {
            this.rightDown = point;
            this.width = point.X - this.leftUp.X;
            this.height = point.Y - this.leftUp.Y;
        }
       
        public override int LeftClick(Point point)
        {
            this.leftUp = point;
            return 0;
        }
    }
}
