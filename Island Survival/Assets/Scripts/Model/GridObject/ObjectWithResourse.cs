using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ObjectWithResourse : Entity
{
    private int _lvl;
    private List<BaseResourse> _resourse = new List<BaseResourse>();
    private float _recoveryTime;
    private bool _isActive;

    public int Lvl => _lvl;
    public float RecoveryTime => _recoveryTime;
    public bool IsActive
    {
        get => _isActive;
        set => _isActive = value;
    }

    

    public ObjectWithResourse(GridObjectSetting setting) : base(setting)
    {
    }

    protected override void OnDie()
    {       
    }

    protected override void OnUpdate()
    {        
    }
}

