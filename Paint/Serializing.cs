using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Paint
{
    public struct myColor { public int R; public int G; public int B; };
    public struct Pt { public int X; public int Y; }
    public struct data
    {
        public struct LeftUp { public int X; public int Y; };
        public struct LastDot { public int X; public int Y; };
        public struct RightDown { public int X; public int Y; };
        public struct Size { public int width; public int height; };

        //All
        public string name;
        public string type;
        //public Color penColor;
        //public Color brushColor;
        public myColor penColor;
        public myColor brushColor;
        public int penWidth;
        public LeftUp leftUp;


        //Simple        
        public RightDown rightDown;
        public Size size;


        //Dynamic
        public List<Pt> dots;
        public LastDot lastDot;

    }

    [Serializable()]
    public class Serializing
    {
        

        public List<data> allFigures = new List<data>();
       
        public void Save(List<Figure> figureList)
        {
            foreach (Figure figure in figureList)
            {
                data dt = new data();
                dt.name = figure.GetName();

                Color penColor = figure.GetPenColor();
                dt.penColor.R = penColor.R;
                dt.penColor.G = penColor.G;
                dt.penColor.B = penColor.B;

                dt.penWidth = figure.GetPenWidth();
                Color brushColor = figure.GetBrushColor();
                dt.brushColor.R = brushColor.R;
                dt.brushColor.G = brushColor.G;
                dt.brushColor.B = brushColor.B;
                

                if (figure is SimpleFigure)
                {
                    dt.type = "simple";
                    dt.rightDown.X = ((figure as SimpleFigure).GetRightDown()).X;
                    dt.rightDown.Y = ((figure as SimpleFigure).GetRightDown()).Y;

                    dt.leftUp.X = ((figure as SimpleFigure).GetLeftUp()).X;
                    dt.leftUp.Y = ((figure as SimpleFigure).GetLeftUp()).Y;

                    dt.size.width = (figure as SimpleFigure).GetWidth();
                    dt.size.height = (figure as SimpleFigure).GetHeight();


                    //int x = (figure as SimpleFigure).
                }
                else
                {
                    dt.type = "dynamic";

                    dt.leftUp.X = ((figure as DynamicFigure).GetLeftUp()).X;
                    dt.leftUp.Y = ((figure as DynamicFigure).GetLeftUp()).Y;

                    dt.dots = new List<Pt>();
                    foreach (Point pt in (figure as DynamicFigure).GetList())
                    {
                        Pt point;
                        point.X = pt.X;
                        point.Y = pt.Y;

                        dt.dots.Add(point);
                    }
                    dt.lastDot.X = ((figure as DynamicFigure).GetLastDot()).X;
                    dt.lastDot.Y = ((figure as DynamicFigure).GetLastDot()).Y;

                }


                allFigures.Add(dt);

            }
         

        }

        public void Load(List<Figure> figureList)
        {            

            foreach (data figure in allFigures)
            {
                var fgr = Activator.CreateInstance(Type.GetType("Paint." + figure.name));

                Color penColor = Color.FromArgb(figure.penColor.R, figure.penColor.G, figure.penColor.B);
                (fgr as Figure).SetPenColor(penColor);
                (fgr as Figure).SetPenWidth(figure.penWidth);
                Color brushColor = Color.FromArgb(figure.brushColor.R, figure.brushColor.G, figure.brushColor.B);
                (fgr as Figure).SetBrushColor(brushColor);




                if (figure.type == "simple")
                {
                    //LeftUp
                    Point leftUp = new Point(figure.leftUp.X, figure.leftUp.Y);
                    (fgr as SimpleFigure).SetLeftUp(leftUp);

                    //RightDown
                    Point rightDown = new Point(figure.rightDown.X, figure.rightDown.Y);
                    (fgr as SimpleFigure).SetRightDown(rightDown);

                    //Size
                    (fgr as SimpleFigure).SetWidthHeight(figure.size.width, figure.size.height);

                }
                else
                {
                    //LeftUp
                    Point leftUp = new Point(figure.leftUp.X, figure.leftUp.Y);
                    (fgr as DynamicFigure).SetLeftUp(leftUp);

                    //LastDot
                    Point lastDot = new Point(figure.lastDot.X, figure.lastDot.Y);
                    (fgr as DynamicFigure).SetLastDot(lastDot);

                    //ListPoints
                    List<Point> points = new List<Point>();
                    foreach (Pt pt in figure.dots)
                    {                        
                        points.Add(new Point(pt.X, pt.Y));
                    }
                    (fgr as DynamicFigure).SetPoints(points);

                }

                figureList.Add((Figure)fgr);
            }


        }

    }
}
