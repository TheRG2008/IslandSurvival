using System.Collections;
using System.Collections.Generic;
public class Grid 
{
    
    private GridCell[,] _gridCell;
    private int _width;
    private int _height;
    private List<GridObject> _gridObjects = new List<GridObject>();

    public int Width
        => _width;
    public int Height
        => _height;

    public Grid(int width, int height)
    {
        _width = width;
        _height = height;
    }

    public Grid(GridCell[,] gridCell)
    {
        _gridCell = gridCell;
    }

    public bool FindObject(int x, int y, out GridObject result)
    {
        result = _gridObjects.Find(o => o.X == x && o.Y == y);
        return result != null;
    }

    public GridCell GetCell(int x, int y)
    {
        return _gridCell[x, y];
    }

    public void DestroyGridObject(GridObject gridObject)
    {
        _gridObjects.Remove(gridObject);        
    }

    public void Update ()
    {
        for (int i = 0; i < _gridObjects.Count; i++)
        {
            _gridObjects[i].Update();
        }
    }
}
