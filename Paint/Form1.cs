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

        private FigureList figureList = new FigureList();
        private Figure currFigure;
        private Figure lastFigure;


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
            this.currFigure = new Rect();
            this.lastFigure = this.currFigure;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.currFigure = new Circle();
            this.lastFigure = this.currFigure;
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
                if (currFigure == null)
                    currFigure = lastFigure.Clone();
                SetAttribute(currFigure);
                Point point = new Point(e.X, e.Y);

                this.currFigure.LeftClick(point);

                figureList.ClearList();
                btnRedo.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                    

            }
            else
            {
                this.currFigure.Draw(pic);

                figureList.list.Add(currFigure);
                btnUndo.Enabled = true;
                undoToolStripMenuItem.Enabled = true;

                currFigure = null;               
                picBox1.Image = bitmap;
            }

        }

        private void picBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.currFigure != null)
            {
                pic.Clear(Color.White);
                DrawAllList();                
                currFigure.PreDraw(pic, e.X, e.Y);
                picBox1.Image = bitmap;
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.currFigure = new Line();
            this.lastFigure = this.currFigure;
        }

        private void btnPolyline_Click(object sender, EventArgs e)
        {
            this.currFigure = new Polyline();
            this.lastFigure = this.currFigure;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            this.currFigure = new Polygon();
            this.lastFigure = this.currFigure;
        }

        private void DrawAllList()
        {
            if (figureList.list != null)
            {
                foreach (Figure figure in figureList.list)
                {
                    PaintEventArgs b = new PaintEventArgs(pic, new Rectangle());
                    figure.Draw(pic);
                }   
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            pic.Clear(Color.White);

            if (figureList.Undo() == false)
            {
                btnUndo.Enabled = false;
                undoToolStripMenuItem.Enabled = false;
            }
            btnRedo.Enabled = true;
            redoToolStripMenuItem.Enabled = true;

            DrawAllList();
            picBox1.Image = bitmap;
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            pic.Clear(Color.White);

            if (figureList.Redo() == false)
            {
                btnRedo.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
            }
            btnUndo.Enabled = true;
            undoToolStripMenuItem.Enabled = true;

            DrawAllList();
            picBox1.Image = bitmap;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRedo_Click(sender, e);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnUndo_Click(sender, e);
        }

    }
}
