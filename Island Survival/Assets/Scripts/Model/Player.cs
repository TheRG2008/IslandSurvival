using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Player : GridObject
{
    private int _lifes;
    private int _coin;
    private int _atackPower;

    public int Lifes
    {
        get => _lifes;
        set => _lifes = value;
    }
    public int Coin
    {
        get => _coin;
        set => _coin = value;
    }
    public int AtackPower
    {
        get => _atackPower;
        set => _atackPower = value;
    }
    
    public Player(GridObjectSetting setting) : base(setting)
    {
    }

    public void Move (Direction direction)
    {
        switch (direction)
        {
            case Direction.Left:
                _Move(_x -1, _y);
                break;
            case Direction.Right:
                _Move(_x + 1, _y);
                break;
            case Direction.Up:
                _Move(_x, _y - 1);
                break;
            case Direction.Down:
                _Move(_x, _y + 1);
                break;            
        }
    }
    public void Atack()
    {
        if (SearchEnemy())
        {
            GetDamage();
        }
    }
    public void Die()
    {
        if (_lifes <= 0)
        {
            
        }
    }
    public void Respawn()
    {

    }
    public void EnterHome ()
    {
        //
    }

    public void FindingWay()
    {

    }
    public void GetDamage(Enemy enemy)
    {
        enemy.LifesEnemy -= _atackPower;
    }

    public bool SearchEnemy() // Поменял void на bool для того что бы вернуть, есть враг или нет
    {
        return true;

    }

    public void CollectResurce()
    {

    }

}

