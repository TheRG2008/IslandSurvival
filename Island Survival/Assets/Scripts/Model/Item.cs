using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Item
{
    protected int _lvl;
    protected int _maxLvl;

    public int Lvl
    {
        get => _lvl;
        set => _lvl = value;
    }
    public int MaxLvl => _maxLvl;
   
    
}
