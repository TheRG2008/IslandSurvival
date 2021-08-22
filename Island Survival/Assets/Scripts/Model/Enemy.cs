using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Enemy : Player
{
    private int _enemyHP;
    private Resurses[] _resurses;
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
}

