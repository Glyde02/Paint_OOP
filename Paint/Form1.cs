using System;
using System.Drawing;


namespace Paint
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            Graphics pic = picBox1.CreateGraphics();

            Pen recPen = new Pen(Color.Red, 2);
            Rectangle rec = new Rectangle(10, 10, 80, 50);
            pic.DrawRectangle(recPen, rec);

            Pen EllipsePen = new Pen(Color.Blue, 8);
            Rectangle EllipseRect = new Rectangle(150, 10, 80, 60);
            pic.DrawEllipse(EllipsePen, EllipseRect);

            Pen CirclePen = new Pen(Color.Blue, 8);
            CirclePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Rectangle CircleRect = new Rectangle(150, 100, 80, 60);
            pic.DrawEllipse(CirclePen, CircleRect);


            Point LinePT1 = new Point(300, 10);
            Point LinePT2 = new Point(350, 150);
            Pen LinePen = new Pen(Color.Green, 2);
            pic.DrawLine(LinePen, LinePT1, LinePT2);

            SolidBrush brushDots = new SolidBrush(Color.Magenta);
            Point[] dots = {new Point(100,150), new Point(200, 250),
                            new Point(100,350), new Point(150, 250) };
            pic.FillPolygon(brushDots, dots);

            Pen curve = new Pen(Color.Coral, 4);
            Pen lines = new Pen(Color.DeepPink, 4);
            Point[] points = {new Point(500, 10), new Point(550, 110),
                              new Point(680, 100), new Point(700, 400),
                              new Point(500, 350)};
            pic.DrawCurve(curve, points);
            pic.DrawLines(lines, points);


        }
    }
}
