using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Battle
    {
        public void AttackEnemy(Character Offender,Character Defender)
        {
            Defender.HP -= Offender.Attack; 
        }
    }
}
