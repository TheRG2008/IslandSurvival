using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BonusChest : Entity
{
    private Random _rand;
    private Resource[] _resources;
    private int _resourcesCount;

    public BonusChest(int resoursesCount, Resource[] resources, GridObjectSetting setting) : base(setting)
    {
        _rand = new Random();
        _resources = resources;
        _resourcesCount = resoursesCount;
        
    }

    public Resource[] GetRandomBonus()
    {
        Resource[] result = new Resource[_resourcesCount];
        for (int i = 0; i < _resourcesCount; i++)
        {
            result[i] = _resources[_rand.Next(0, _resourcesCount - 1)];
        }
        Die();
        return result;
       
    }

    public override uint GetUniqueID()
    {
        return (uint)GridObjectID.Chest;
    }

    protected override void OnDie()
    {
        
    }

    protected override void OnUpdate()
    {
        
    }
}

