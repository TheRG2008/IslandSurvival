using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ObjectWithResourse : GridObject
{
    private int _lvl;
    private List<Resource> _resourse;
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
        _resourse = new List<Resource>();
    }

    

    protected override void OnUpdate()
    {        
    }

    public override uint GetUniqueID()
    {
        return (uint)GridObjectID.ObjectWithResurce;
    }
}

