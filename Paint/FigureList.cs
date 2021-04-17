using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class FigureList
    {
        public List<Figure> list = new List<Figure>();
        private List<Figure> buffFigures = new List<Figure>();


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


    }
}
