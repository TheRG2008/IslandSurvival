using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enemy : Entity
{
    
    private List<Resource> _resourse = new List<Resource>();
    private List<GridObject> _gridObjects;
     
    public Enemy(GridObjectSetting setting) : base(setting)
    {
    }

    public void FindResourse()
    {
       
    }
    public void CollectResourse()
    {

    }
    public void EnterHome(GridObject gridObject) //
    {
        if (gridObject is EnemyHome enemyHome )
        {
            if (_gridCurrent.FindObject(X, Y - 1, out gridObject))
                _gridCurrent.DestroyGridObject(this);
        }
            
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

