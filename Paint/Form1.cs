using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Paint
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Bitmap bitmap;
        public Graphics pic;

        private List<Figure> listFigures;
        private Figure currFigure;


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
            //Rect rectangle = new Rect();
            //SetAttribute(rectangle);

            ////rectangle.DrawRect(pic, 10, 10, 50, 50);            
            //rectangle.DrawRect(pic, (int)UpDownX.Value, (int)UpDownY.Value, (int)UpDownWidth.Value,(int) UpDownHeight.Value);

            //picBox1.Image = bitmap;

            this.currFigure = new Rect();

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            //Circle circle = new Circle();
            //SetAttribute(circle);
            ////circle.DrawCircle(pic, 100, 100, 50, 50);
            //circle.DrawCircle(pic, (int)UpDownX.Value, (int)UpDownY.Value, (int)UpDownWidth.Value, (int)UpDownHeight.Value);

            //picBox1.Image = bitmap;

            this.currFigure = new Circle();
        }

        private void SetAttribute(Figure figure)
        {
            figure.SetPenColor(clrDlgPen.Color);
            figure.SetBrushColor(clrDlgBrush.Color);
            figure.SetPenWidth((int)penWidth.Value);
        }



        //Изменение размера Bitmap при изменении размера окна
        //проблема, когда происходит увеличение окна
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //Bitmap buff;
            
            //buff = bitmap.Clone(new Rectangle(0, 0, picBox1.Width, picBox1.Height), bitmap.PixelFormat);
            //bitmap = (Bitmap)buff.Clone();
            //buff.Dispose();
            //picBox1.Image = bitmap;

        }

        private void picBox1_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                SetAttribute(currFigure);

                Point point = new Point(e.X, e.Y);
                this.currFigure.Init(point);
            }
            else
            {
                PaintEventArgs b = new PaintEventArgs(pic, new Rectangle());
                this.currFigure.Draw(b);
                picBox1.Image = bitmap;
            }

        }

        private void picBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.currFigure != null)
                this.currFigure.SetSize(e.Location);
            //picBox1_MouseUp(sender, e);
        }

        private void picBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //Рисование при отпускании кнопке

            //if (currFigure != null)
            //{
            //    PaintEventArgs b = new PaintEventArgs(pic, new Rectangle());

            //    this.currFigure.Draw(b);
            //    picBox1.Image = bitmap;
            //}

        }
    }
}
