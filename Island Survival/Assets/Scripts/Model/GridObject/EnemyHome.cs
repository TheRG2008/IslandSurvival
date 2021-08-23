using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EnemyHome : Entity
{
    private List<Enemy> _enemies;

    public EnemyHome(GridObjectSetting setting) : base(setting)
    {
    }

    protected override void OnDie()
    {   
    }

    protected override void OnUpdate()
    {        
    }

    public void SpawnEnemy ()
    {

    }
    public void DestroyEnemy()
    {

    }
}

