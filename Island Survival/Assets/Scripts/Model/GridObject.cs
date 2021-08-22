using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum GridObjectType //GridObject это по факту и есть Objects with Resourse, как в этом случае поступить
                           //Реализовать через enum как тут, или создать наследников от GridObject с разными типами объектов?
{
    Tree,
    Stoun,
    Bush,
    IronMine,
    SilverMine
}
public abstract class GridObject
{
    protected int _x;
    protected int _y;
    protected Grid _gridCurrent;
    protected int _layer;


    public int X
        => _x;
    public int Y
        => _y;
    public int Layer
        => _layer;


    protected GridObject(GridObjectSetting setting)
    {        
        _x = setting.X;
        _y = setting.Y;
        _gridCurrent = setting.Grid;
        _layer = setting.Layer;
    }

    protected bool _Move (int x, int y)
    {
        if (x < 0 || y < 0 || x > _gridCurrent.Width || y > _gridCurrent.Height || !_gridCurrent.GetCell(x,y).IsPassable)
            return false;

        if (!_gridCurrent.FindObject(x,y, out GridObject gridObject))
        {
            _x = x;
            _y = y;
            return true;
        }
        return false;
    }
}
public struct GridObjectSetting
{
    public int X;
    public int Y;
    public Grid Grid;
    public int Layer;

    public GridObjectSetting(int x, int y, Grid grid, int layer)
    {
        X = x;
        Y = y;
        Grid = grid;
        Layer = layer;
    }
}

