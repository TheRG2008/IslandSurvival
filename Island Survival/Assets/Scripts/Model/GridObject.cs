using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class GridObject
{
    protected int _x;
    protected int _y;
    protected Grid _gridCurrent;
    
    public int X
        => _x;
    public int Y
        => _y;
    
    protected GridObject(GridObjectSetting setting)
    {        
        _x = setting.X;
        _y = setting.Y;
        _gridCurrent = setting.Grid;
        
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
    protected abstract void OnUpdate(); //Реализация Update в GridObject

    public void Update()
    {
        OnUpdate();
        
    }


}
public struct GridObjectSetting
{
    public int X;
    public int Y;
    public Grid Grid;
    

    public GridObjectSetting(int x, int y, Grid grid)
    {
        X = x;
        Y = y;
        Grid = grid;
       
    }

    
}

