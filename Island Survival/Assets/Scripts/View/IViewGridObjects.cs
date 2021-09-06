using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IViewGridObjects
{
    void RequestGridObject(GridObjectNameID[] gridObjects);
    void RequestCallBackGridObjectChange(int[] x, int[] y, GridObject[] gridObjects);
}

