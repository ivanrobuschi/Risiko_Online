using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risiko_Core
{
    public class Player
    {
        public readonly int ID;
        public readonly string name;
        public readonly int colorID;
        public readonly int targetID;

        public Player(int _ID, string _name, int _colorID, int _targetID)
        {
            ID = _ID;
            name = _name;
            colorID = _colorID;
            targetID = _targetID;
        }
    }
}
