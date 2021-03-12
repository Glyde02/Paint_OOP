using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Bitmap bitmap;
        public Graphics pic;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(picBox1.Width, picBox1.Height);
            pic = Graphics.FromImage(bitmap);
        }



        private void btnPenColor_Click(object sender, EventArgs e)
        {
            if (clrDlgPen.ShowDialog() == DialogResult.OK)
            {
                btnPenColor.BackColor = clrDlgPen.Color;
            }
        }

        private void btnBrushColor_Click(object sender, EventArgs e)
        {
            if (clrDlgBrush.ShowDialog() == DialogResult.OK)
            {
                btnBrushColor.BackColor = clrDlgBrush.Color;
            }
        }

        private void btcRect_Click(object sender, EventArgs e)
        {
            Rect rectangle = new Rect();
            SetAttribute(rectangle);

            //rectangle.DrawRect(pic, 10, 10, 50, 50);            
            rectangle.DrawRect(pic, (int)UpDownX.Value, (int)UpDownY.Value, (int)UpDownWidth.Value,(int) UpDownHeight.Value);

            picBox1.Image = bitmap;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            SetAttribute(circle);
            //circle.DrawCircle(pic, 100, 100, 50, 50);
            circle.DrawCircle(pic, (int)UpDownX.Value, (int)UpDownY.Value, (int)UpDownWidth.Value, (int)UpDownHeight.Value);

            picBox1.Image = bitmap;
        }

        private void SetAttribute(Figure figure)
        {
            figure.SetPenColor(clrDlgPen.Color);
            figure.SetBrushColor(clrDlgBrush.Color);
            figure.SetPenWidth((int)penWidth.Value);
        }



        //Изменение размера Bitmap при изменении размера окна
        //проблема, когда происходит увеличение окна
        private void Form1_SizeChanged(object sender, EventArgs e)       {



            //Bitmap buff = new Bitmap(picBox1.Width, picBox1.Height);
            
            //buff = bitmap.Clone(new Rectangle(0, 0, picBox1.Width, picBox1.Height), bitmap.PixelFormat);
            //bitmap = (Bitmap)buff.Clone();
            //buff.Dispose();
            //bitmap.Dispose();
            //bitmap = buff;
            //picBox1.Image = bitmap;
            //pic = Graphics.FromImage(bitmap);

        }
    }
}
