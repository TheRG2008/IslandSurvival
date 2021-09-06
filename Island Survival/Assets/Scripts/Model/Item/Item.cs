using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TargetType
{
    Tree,
    StoneMine,
    Bush,
    Enemy
}
public abstract class Item
{
    protected int _lvl;
    protected int _maxLvl;
    protected int _atackPower;
    protected TargetType _targetType;

    public int AtackPower
    {
        get => _atackPower;
        set => _atackPower = value;
    }

    public int Lvl
    {
        get => _lvl;
        set => _lvl = value;
    }
    public int MaxLvl => _maxLvl;

    protected Item(TargetType targetType)
    {
        _targetType = targetType;
    }
}
