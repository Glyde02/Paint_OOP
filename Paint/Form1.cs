using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

namespace Paint
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private bool click_Clear = false;

        public Bitmap bitmap;
        public Graphics pic;

        private FigureList figureList = new FigureList();
        public List<Type> allTypesOfFigures = new List<Type>();
        private Figure currFigure;
        private Figure lastFigure;

        private int NumOfPlugins = 0;


        public Form1()
        {
            InitializeComponent();

            allTypesOfFigures.Add(typeof(Rect));
            allTypesOfFigures.Add(typeof(Line));
            allTypesOfFigures.Add(typeof(Circle));
            allTypesOfFigures.Add(typeof(Polyline));
            allTypesOfFigures.Add(typeof(Polygon));

            lastFigure = new Rect();

            bitmap = new Bitmap(picBox1.Width, picBox1.Height);
            pic = Graphics.FromImage(bitmap);
            saveFileDialog1.DefaultExt = ".xml";
            saveFileDialog1.Filter = "All files(*.*)|*.*";
            openFileDialog1.Filter = "All files(*.*)|*.*|XML-files(*.xml)|*.xml";
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
            //figure.SetPenColor(clrDlgPen.Color);
            figure.SetPenColor(Color.FromArgb(clrDlgPen.Color.A, clrDlgPen.Color.R, clrDlgPen.Color.G, clrDlgPen.Color.B));
            //figure.SetBrushColor(clrDlgBrush.Color);
            figure.SetBrushColor(Color.FromArgb(clrDlgBrush.Color.A, clrDlgBrush.Color.R, clrDlgBrush.Color.G, clrDlgBrush.Color.B));
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

                figureList.Clearbuff();
                btnRedo.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                    

            }
            else
            {
                if (this.currFigure != null)
                {
                    this.currFigure.Draw(pic);

                    figureList.list.Add(currFigure);
                    btnUndo.Enabled = true;
                    undoToolStripMenuItem.Enabled = true;

                    currFigure = null;
                    picBox1.Image = bitmap;
                }
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
                    figure.Draw(pic);
                }   
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (!click_Clear)
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
            else
            {
                click_Clear = false;

                pic.Clear(Color.White);
                figureList.MoveToList();
                DrawAllList();
                picBox1.Image = bitmap;
            }

            
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрыть программу?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                this.Close();
            }     
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {   
                var path = saveFileDialog1.FileName;
                figureList.Serialize(path, allTypesOfFigures.ToArray());
            }            

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                click_Clear = false;

                figureList.list.Clear();
                figureList.Clearbuff();

                btnUndo.Enabled = true;
                btnRedo.Enabled = false;

                var path = openFileDialog1.FileName;
                figureList.Deserialize(path, allTypesOfFigures.ToArray());


                pic.Clear(Color.White);
                DrawAllList();
                picBox1.Image = bitmap;
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            click_Clear = true;

            figureList.Clearbuff();
            figureList.MoveToBuff();

            btnRedo.Enabled = false;
            pic.Clear(Color.White);
            picBox1.Image = bitmap;
            
        }

        private void addFigureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string path = "";


            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                path = openFileDialog.FileName;
            }
            else 
            {
                return; 
            }


            Assembly assembly = Assembly.LoadFrom(path);            
            Type[] pluginType = assembly.GetTypes();


            int imgIndex = 0;
            foreach (Type plugType in pluginType)
            {
                allTypesOfFigures.Add(plugType);

                Button btn = new Button();
                btn.Name = "btn" + plugType.ToString();
                //btn.Text = "Trapeze";
                btn.Parent = panel1;
                btn.Size = new Size(70, 40);
                btn.Location = new Point(4, 300 + (40+6)*NumOfPlugins);

                
                string[] arrNames = assembly.GetManifestResourceNames();
                //int index = 0;
                //foreach(string name in arrNames)
                //{
                //    if (name.Contains(".png"))
                //    {
                //        break;
                //    }
                //    else
                //    {
                //        index++;
                //    }
                //}
                Image img;
                img = Image.FromStream(assembly.GetManifestResourceStream(arrNames[imgIndex]));
                btn.Image = img;
                imgIndex++;

                
                

                btn.Click += delegate(object sender_, EventArgs e_)
                {
                    this.currFigure = (Figure)Activator.CreateInstance(plugType);
                    this.lastFigure = this.currFigure;
                };

                this.panel1.Controls.Add(btn);
                this.NumOfPlugins++;
            }


        }
    }
}
