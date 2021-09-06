using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Fence : GridObject
{
    //private int _lvl;   
    //public int Lvl => _lvl;
    public Fence(GridObjectSetting setting) : base(setting)
    {
        
    }



    protected override void OnUpdate()
    {
    }

    public void Bulding(Inventory inventory, FenceResipes fenceResipes) //Как тут обратиться к конкретному рецепту?
    {

        switch (fenceResipes.ResipesLvl)
        {
            case 0:
                if (inventory.CheckResource(new FenceResipes().Cost))
                {
                    inventory.RemoveResource(new FenceResipes().Cost);                    
                }
                break;
            case 1:
                if (inventory.CheckResource(new FenceResipes().Cost))
                {
                    inventory.RemoveResource(new FenceResipes().Cost);

                }
                break;

        }


        //switch (_lvl)
        //{
        //    case 0:
        //        if (inventory.CheckResource(new Resource(20, TypeOfResources.Wood), new Resource(5, TypeOfResources.Rock)))
        //        {
        //            inventory.RemoveResource(new Resource(20, TypeOfResources.Wood), new Resource(5, TypeOfResources.Rock));
        //            _lvl++;
        //        }
        //        break;
        //    case 1:
        //        if (inventory.CheckResource(new Resource(30, TypeOfResources.Wood), new Resource(10, TypeOfResources.Rock), new Resource(5, TypeOfResources.Iron)))
        //        {
        //            inventory.RemoveResource(new Resource(30, TypeOfResources.Wood), new Resource(10, TypeOfResources.Rock), new Resource(5, TypeOfResources.Iron));
        //            _lvl++;
        //        }
        //        break;

        //}
    
    }
    public void Destroy() 
    {
        _gridCurrent.DestroyGridObject(this); 
    }

    public override uint GetUniqueID()
    {
          return (uint)GridObjectID.Fence;
    }
}
