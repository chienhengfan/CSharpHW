using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Character
    {
        private float _hp;
        public float HP { private set { value = _hp; } get { return _hp; } }
        private float _attack;
        public float Attack { private set { value = _attack; } get { return _attack; } }
        private float _agile;
        public float Agile { private set { value = _attack; } get { return _attack; } }
        public enum statchacter { Health, Dying, Dead }
        public statchacter inintialStat;

        public void ShowStatTable()
        {
            Console.WriteLine($"STAT: {inintialStat}\nHP:{HP}");
        }
        
    }
}
