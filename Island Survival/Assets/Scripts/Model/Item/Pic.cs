using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pic : Item
{
    public Pic(TargetType targetType) : base(targetType)
    {
        targetType = TargetType.StoneMine;
    }
}

