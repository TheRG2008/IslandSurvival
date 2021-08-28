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
        //проверка на колличество ресурсов
        //удалить ресурсы - проверка
        _lvl += 1;

    }
    public void Destroy() 
    {
        _gridCurrent.DestroyGridObject(this); 
    }

}

