using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class EnemyHome : Entity
{
    private float _spawnTimer; 
    private Random rand;
    public float SpawnTime 
    { 
        get => _spawnTimer; 
        set => _spawnTimer = value; 
    }
    


    public EnemyHome(GridObjectSetting setting) : base(setting)
    {        
        rand = new Random();
    }

    protected override void OnDie()
    {   
    }

    protected override void OnUpdate()
    {        
    }

    public void SpawnEnemy ()
    {
        EnemyType enemyRandom = (EnemyType)rand.Next(0, Enum.GetNames(typeof(EnemyType)).Length-1);
        switch (enemyRandom)
        {
            case EnemyType.Skeleton:
                _gridCurrent.CreateGridObject(new Skeleton(new GridObjectSetting(X, Y+1, _gridCurrent)));
                break;
            case EnemyType.Orc:
                _gridCurrent.CreateGridObject(new Ork(new GridObjectSetting(X, Y + 1, _gridCurrent)));
                break;
            
        }

    }
   
}

