using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Npc : GridObject
{
    private Item _item;
    public Npc(GridObjectSetting setting, Item item) : base(setting)
    {
        _item = item;
        item = new Axe(TargetType.Tree);
        item.Lvl = 1;
        
    }

    protected override void OnUpdate()
    {
        
    }
}

