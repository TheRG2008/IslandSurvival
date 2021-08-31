using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Fence : Entity
{
    private int _lvl;
    
    private Resource[] _resourseForUpgrade;
    public int Lvl => _lvl;
    public Fence(GridObjectSetting setting) : base(setting)
    {
        
    }

    protected override void OnDie()
    {

    }

    protected override void OnUpdate()
    {
    }

    public void Upgrade(Inventory inventory)
    {

        
        switch (_lvl)
        {
            case 0:
                if (inventory.CheckResource(new Resource(20, TypeOfResources.Wood), new Resource(5, TypeOfResources.Rock)))
                {
                    inventory.RemoveResource(new Resource(20, TypeOfResources.Wood), new Resource(5, TypeOfResources.Rock));
                    _lvl++;
                }
                break;
            case 1:
                // Добавить еще одно условие
                break;

        }
    
    }
    public void Destroy() 
    {
        _gridCurrent.DestroyGridObject(this); 
    }

}

