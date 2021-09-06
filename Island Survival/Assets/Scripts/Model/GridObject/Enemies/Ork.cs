using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Ork : Enemy
{
    
    public Ork(GridObjectSetting setting) : base(setting)
    {
        Lifes = 30;
        AtackPower = 1;
    }
}

