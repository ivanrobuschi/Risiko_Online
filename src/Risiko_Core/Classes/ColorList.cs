using System.Collections.Generic;

namespace Risiko_Core.Classes
{


    public class ColorList
    {
        private readonly List<string> _colorList;

        public ColorList()
        {
            _colorList = new List<string> {"black", "green", "purple", "cyan", "yellow", "red"};
        }

        public int Count
        {
            get { return _colorList.Count; }
        }

        public string GetColor(int id)
        {
            return _colorList[id];
        }
    }  

}
