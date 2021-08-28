using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Enemy : Entity
{
    private int _enemyHP;
    private List<Resource> _resourse = new List<Resource>();
    private List<GridObject> _gridObjects;
     
    public int LifesEnemy
    {
        get => _enemyHP;
        set => _enemyHP = value;
    }

    public Enemy(GridObjectSetting setting) : base(setting)
    {
    }

    public void FindResourse()
    {
       
    }
    public void CollectResourse()
    {

    }
    public void EnterHome()
    {
        _gridCurrent.DestroyGridObject(this);
    }
    public void FindingWay()
    {

    }

    protected override void OnDie()
    {        
    }


    protected override void OnUpdate()
    {
    }

    public void Atack ()
    {
        if (SearchEnemy(out Entity entity))
        {
            if (entity is Player player)
                player.GetDamage(_atackPower, this);

        }
    }
    
    
}

