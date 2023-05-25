using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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

        public bool IsHit(Character offender, Character defender)
        {
            float effectHit = 1.2f;
            bool isHit = ((offender.Agile - defender.Attack) >= effectHit) ;
            if(isHit) 
            {
                return true;
            }
            return false;
        }
    }
}
