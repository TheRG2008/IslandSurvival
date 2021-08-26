using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class СraftingTable : Entity
{
    private List<Resipes> _resipes = new List<Resipes>();

    public СraftingTable(GridObjectSetting setting) : base(setting)
    {
    }
    protected override void OnDie()
    {
    }
    protected override void OnUpdate()
    {
    }
    public void ChekLvlItem()
    {
    }
    public void CreateItem()
    {
    }
    public void ChangeLvl()
    {
    }
}

