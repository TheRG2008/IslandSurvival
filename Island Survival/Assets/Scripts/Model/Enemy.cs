﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Enemy : Entity
{
    private int _enemyHP;
    private List<BaseResourse> _resourse = new List<BaseResourse>();
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

    protected override void OnDie()
    {
        
    }

    protected override void OnUpdate()
    {
        
    }
}

