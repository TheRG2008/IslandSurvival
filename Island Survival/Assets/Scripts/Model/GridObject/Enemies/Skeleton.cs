using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Skeleton : Enemy
{
    public Skeleton(GridObjectSetting setting) : base(setting)
    {
        Lifes = 20;
        AtackPower = 1;
    }
}

