using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public abstract class Entity : GridObject
{
    protected int _lifes;
    protected int _atackPower;
    public int AtackPower
    {
        get => _atackPower;
        set => _atackPower = value;
    }
    public int Lifes
    {
        get => _lifes;
        set
        {
            if (value <= 0)
            {
                _lifes = 0;
                Die();
            }
            else
                _lifes = value;
        }

    }
    public Entity(GridObjectSetting setting) : base(setting)
    {
    }

    protected virtual void Move(Direction direction)
    {
        switch (direction)
        {
            case Direction.Left:
                _Move(_x - 1, _y);
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
    protected abstract void OnDie();

    public void Die()
    {
        OnDie();
        _gridCurrent.DestroyGridObject(this);
    }
    public virtual void GetDamage(int damage, GridObject source)
    {
        Lifes -= damage;
    }

    public virtual bool SearchEnemy(out Enemy enemy)
    {
        if (_gridCurrent.FindObject(_x - 1, _y, out GridObject result1))
        {
            if (result1 is Enemy target)
            {
                enemy = target;
                return true;
            }
        }
        if (_gridCurrent.FindObject(_x, _y - 1, out GridObject result2))
        {
            if (result2 is Enemy target)
            {
                enemy = target;
                return true;
            }
        }
        if (_gridCurrent.FindObject(_x + 1, _y, out GridObject result3))
        {
            if (result3 is Enemy target)
            {
                enemy = target;
                return true;
            }
        }
        if (_gridCurrent.FindObject(_x, _y + 1, out GridObject result4))
        {
            if (result4 is Enemy target)
            {
                enemy = target;
                return true;
            }
        }
        enemy = null;
        return false;


    }


}

