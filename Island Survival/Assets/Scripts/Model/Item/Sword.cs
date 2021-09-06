using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Sword : Item
{
    public Sword(TargetType targetType) : base(targetType)
    {
        targetType = TargetType.Enemy;
    }
}

