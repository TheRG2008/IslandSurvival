using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;


class ViewGrid : MonoBehaviour, IViewGrid
{
    [SerializeField] private Tilemap _tilemap;
    
    public void RequestCallBackCellChange(int[] x, int[] y, TypeCell[] cells)
    {
        throw new NotImplementedException();
    }

    public void RequestGridCell(TypeCell[,] cells)
    {
        throw new NotImplementedException();
    }

    public void RequestUniqueCells(TypeCell[] cells)
    {
        
    }
}

