using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public readonly struct GridObjectNameID
{
    public readonly string Name;
    public readonly uint ID;

    public GridObjectNameID(string name, uint iD)
    {
        Name = name;
        ID = iD;
    }
}

