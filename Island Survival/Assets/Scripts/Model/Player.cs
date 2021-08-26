using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : Entity
{    
    private int _coin;
    public int Coin
    {
        get => _coin;
        set => _coin = value;
    }
   
    
    public Player(GridObjectSetting setting) : base(setting)
    {
    }

   
    public void Atack()
    {
        if (SearchEnemy(out Enemy enemy))
        {
            enemy.GetDamage(_atackPower, this);
        }
    }
    public void Die()
    {
        
    }
    
    public void EnterHome ()
    {
        
    }

    public void FindingWay()
    {

    }
    

    public void CollectResurce()
    {

    }

    protected override void OnDie()
    {
        
    }

    protected override void OnUpdate()
    {
        
    }
}

