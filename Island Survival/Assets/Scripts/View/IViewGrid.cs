using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IViewGrid
{
    void RequestUniqueCells(TypeCell[] cells);
    void RequestGridCell(TypeCell[,] cells);
    void RequestCallBackCellChange(int[] x ,int[] y, TypeCell[] cells);

}

