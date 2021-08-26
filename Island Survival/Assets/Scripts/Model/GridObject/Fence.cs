using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Fence : Entity
{
    private int _lvl;
    private List<BaseResourse> _resourseForUpgrade = new List<BaseResourse>();
    public Fence(GridObjectSetting setting) : base(setting)
    {
    }

    protected override void OnDie()
    {
    }

    protected override void OnUpdate()
    {
    }

    public void Upgrade()
    {

    }
    public void Destroy()
    {

    }

}

