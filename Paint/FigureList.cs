using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Paint
{
    [Serializable]
    public class FigureList
    {
        public List<Figure> list = new List<Figure>();
        
        [NonSerialized]
        private List<Figure> buffFigures = new List<Figure>();

        [NonSerialized]
        private Type[] allTypesOfFigures = new Type[] { typeof(Rect), typeof(Circle), typeof(Line), typeof(Polygon), typeof(Polyline) };


        public void Clearbuff()
        {
            this.buffFigures.Clear();
        }
        public void MoveToBuff()
        {
            list.Reverse();
            buffFigures.AddRange(list);
            list.Clear();
        }
        public void MoveToList()
        {
            buffFigures.Reverse();
            list.AddRange(buffFigures);
            buffFigures.Clear();
        }

        public bool Undo()
        {
            if (list.Count > 0)
            {
                buffFigures.Add(list.Last());
                list.RemoveAt(list.Count - 1);
            }

            if (list.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Redo()
        {
            if (buffFigures.Count > 0)
            {
                list.Add(buffFigures.Last());
                buffFigures.RemoveAt(buffFigures.Count - 1);
            }

            if (buffFigures.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }    
        }

        public void Serialize(string path)
        {
            XmlSerializer xml = new XmlSerializer(typeof(FigureList), allTypesOfFigures);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, this);
            }
        }

        public void Deserialize(string path)
        {
            FigureList res;            


            XmlSerializer xml = new XmlSerializer(typeof(FigureList), allTypesOfFigures);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                res = (FigureList)xml.Deserialize(fs);
            }
            list = res.list;

        }


    }
}
