using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class СraftingTable : GridObject
{
    private List<Resipes> _createResipes;
    private List<Resipes> _upgrateResipes;

   
    public СraftingTable(List<Resipes> createResipes, List<Resipes> upgrateResipes, GridObjectSetting setting) : base(setting)
    {
        _createResipes = createResipes;
        _upgrateResipes = upgrateResipes;
    }

   
    protected override void OnUpdate()
    {
    }
    public void UpgrateItem(Item item, Inventory inventory)
    {
        Resipes? target = _upgrateResipes.Find(x => x.Result.GetType() == item.GetType() && x.ResipesLvl == item.Lvl + 1); 
        if (target.HasValue)
            if (inventory.CheckResource(target.Value.Cost))
            {
                inventory.RemoveResource(target.Value.Cost);
                item.Lvl++;
            }

        
    }
    
    public Item CreateItem(string resipeName, Inventory inventory)
    {
        Resipes? target = _createResipes.Find(x => x.Name == resipeName);
        if(target.HasValue)
        {
            if (inventory.CheckResource(target.Value.Cost))
            {
                inventory.RemoveResource(target.Value.Cost);
                return (Item)Activator.CreateInstance(target.Value.Result.GetType());
            } 
                
        }
        return null;
    }
   
    public Resipes[] GetResipes()
    {
        return _createResipes.ToArray();
    }
    
    
}

