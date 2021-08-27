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
    
    
    public void EnterHome (GridObject chosenObject, PlayerHome home) //
    {
        if (chosenObject == home)
        {
            home.RestoringLives();
        }
    }

    public bool FindingWay(GridCell gridCell) //
    {
        if (gridCell.IsPassable == true)
        {
            return true;
        }
        else
            return false;
    }
    

    public void CollectResurce()
    {

    }

    protected override void OnDie()
    {
        Die();
    }

    protected override void OnUpdate()
    {
        
    }
    //Move()
    //GetDamage
    //SearchEnemy
}

