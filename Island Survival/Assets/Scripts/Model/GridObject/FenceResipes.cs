using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public readonly struct FenceResipes
{
    public readonly Resource[] Cost;        
    public readonly int ResipesLvl;


    public FenceResipes(Resource[] cost, int resipesLvl)
    {
        Cost = cost;               
        ResipesLvl = resipesLvl;

    }
}

