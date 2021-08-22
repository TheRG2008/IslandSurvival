using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public readonly struct GridCell
{
    public readonly bool IsPassable;   
    public readonly TypeCell TypeCell;

    public GridCell(bool isPassable, TypeCell typeCell)
    {
        IsPassable = isPassable;        
        TypeCell = typeCell;
    }
}

