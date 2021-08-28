using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : Entity
{    
    private int _coin;
    private int _maxLife;
    public Direction direction;
    public int Coin
    {
        get => _coin;
        set => _coin = value;
    }
    public int MaxLife 
    {   
        get => _maxLife; 
        set => _maxLife = value;
    }

    public Player(GridObjectSetting setting) : base(setting)
    {
    }
   

   
    public void Atack()
    {
        if (SearchEnemy(out Entity entity))
        {
            if(entity is Enemy enemy)
            enemy.GetDamage(_atackPower, this);
            
        }
    }
    
    
    public void EnterHome (GridObject chosenObject, PlayerHome home) //
    {
        if (chosenObject == home)
        {
            home.RestoringLives(this); //
        }
    }
    public void Click(int x, int y)
    {

    }

    public bool FindingWay(GridCell gridCell) 
        => gridCell.IsPassable;




    public void CollectResurce()
    {

    }

    protected override void OnDie()
    {
        Die();
    }

    protected override void OnUpdate() 
    {
        
        Move(direction);
        direction = Direction.None;
        SearchEnemy(out Entity entity);

    }
    
    
}

