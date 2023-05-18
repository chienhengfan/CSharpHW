using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Character
    {
        protected float _hp;
        public float HP { set { _hp = value; } get { return _hp; } }
        protected float _attack;
        public float Attack { set { value = _attack; } get { return _attack; } }
        private float _agile;
        public float Agile { set { value = _attack; } get { return _attack; } }
        public enum statchacter { Health, Dying, Dead }
        public statchacter inintialStat;

        public void ShowStatTable()
        {
            Console.WriteLine($"STAT: {inintialStat}\nHP: {HP}\nATTACK: {Attack}\n AGILE: {Agile}");
        }
        
    }
}
