using System.Collections;
using System.Collections.Generic;
using System;
public class Grid 
{
    
    private GridCell[,] _gridCell;
    private int _width;
    private int _height;
    private List<GridObject> _gridObjects = new List<GridObject>();

    private IViewGrid _viewGrid;
    private IViewGridObjects _viewGridObjects;
    private uint _curentID;

    public uint NextID
        => _curentID++; 
    
    public int Width
        => _width;
    public int Height
        => _height;

    public IViewGrid ViewGrid 
    { 
        get => _viewGrid; 
        set
        {
            _viewGrid = value;
            _viewGrid.RequestUniqueCells(new TypeCell[] {TypeCell.Ground,TypeCell.Road,TypeCell.Water});
            TypeCell[,] typeCells = new TypeCell[Width, Height];
            for (int x = 0; x < _gridCell.GetLength(0); x++)
                for (int y = 0; y < _gridCell.GetLength(1); y++)
                {
                    typeCells[x, y] = _gridCell[x, y].TypeCell;                    
                }
            _viewGrid.RequestGridCell(typeCells);

        }
    }
    public IViewGridObjects ViewGridObjects 
    { 
        get => _viewGridObjects; 
        set
        {
            _viewGridObjects = value;
            string[] names = Enum.GetNames(typeof(GridObjectID));
            uint[] ids = (uint[])Enum.GetValues(typeof(GridObjectID));
            GridObjectNameID[] gridObjectNameIDs = new GridObjectNameID[names.Length];
            for (int i = 0; i < gridObjectNameIDs.Length; i++)
            {
                gridObjectNameIDs[i] = new GridObjectNameID(names[i], ids[i]);
            }
            _viewGridObjects.RequestGridObject(gridObjectNameIDs);
        } 
    }

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
    public bool CreateGridObject(GridObject gridObject)
    {
        if (FindObject(gridObject.X, gridObject.Y, out GridObject Object))
            return false;

        _gridObjects.Add(gridObject);
        return true;
    }

    public void Update ()
    {
        for (int i = 0; i < _gridObjects.Count; i++)
        {
            _gridObjects[i].Update();
        }
    }
    public void SetCell (int x, int y, GridCell cell)
    {
        _gridCell[x, y] = cell;
        _viewGrid.RequestCallBackCellChange(new int[] {x}, new int[] {y}, new TypeCell[] {cell.TypeCell});
    }
}
