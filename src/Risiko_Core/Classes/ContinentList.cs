using System.Collections.Generic;

namespace Risiko_Core.Classes
{
    public class ContinentList
    {
        private readonly List<string> _contintentList;

        public ContinentList()
        {
            _contintentList = new List<string> { "North America", "South America", "Africa", "Europe", "Asia", "Oceania" };
        }

        public int Count
        {
            get { return _contintentList.Count; }
        }

        public string GetContinent(int id)
        {
            return _contintentList[id];
        }
    }
}
