using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Shovel : Item
{
    public Shovel(TargetType targetType) : base(targetType)
    {
        targetType = TargetType.Bush;
    }
}

