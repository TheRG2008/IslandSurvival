using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public struct Resource
{
    public int Count;
    public readonly int Price;
    public readonly TypeOfResources Type;

    public Resource(int count, TypeOfResources type)
    {
        Count = count;      
        Type = type;
        Price = (int)type;
    }
}

