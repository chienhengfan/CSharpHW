using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04
{
    class Battle:Character
    {
        public void AttackEnemy(Character offender,Character defender)
        {
            defender.HP -= offender.Attack; 
        }
    }
}
