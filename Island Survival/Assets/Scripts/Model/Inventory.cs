using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Inventory
{
    private Resource[] _resources;
    private List<Item> _items;
    private int _maxResourseCount;


    public Inventory()
    {
        _maxResourseCount = 99;
        _items = new List<Item>();
        _resources = new Resource[Enum.GetNames(typeof(TypeOfResources)).Length];
        Array array = Enum.GetValues(typeof(TypeOfResources));
        for (int i = 0; i < _resources.Length; i++)
        {
            _resources[i] = new Resource((int)array.GetValue(i), (TypeOfResources)array.GetValue(i));
        }
    }

    public void AddResource(params Resource[] resources)
    {
        for (int i = 0; i < resources.Length; i++)
        {
            for (int j = 0; j < _resources.Length; j++)
            {
                if (resources[i].Type == _resources[j].Type)
                {
                    _resources[i].Count += resources[j].Count;

                    if (_resources[i].Count > _maxResourseCount)
                    {
                        _resources[i].Count = _maxResourseCount;
                        return;
                    }
                }
            }
        }
    }
    public bool CheckResource(params Resource[] resources)
    {
        for (int i = 0; i < resources.Length; i++)
        {
            for (int j = 0; j < _resources.Length; j++)
            {
                if (resources[i].Type == _resources[j].Type)
                {
                    if (!(_resources[i].Count >= resources[j].Count))
                    {
                        return false;
                    }
                }
            }

        }
        return true;

    }
    public void RemoveResource(params Resource[] resources)
    {
        for (int i = 0; i < resources.Length; i++)
        {
            for (int j = 0; i < _resources.Length; j++)
            {
                if (resources[i].Type == _resources[j].Type)
                {
                    _resources[i].Count -= resources[j].Count;
                    if (_resources[i].Count < 0)
                        _resources[i].Count = 0;
                }
            }
        }
    }
} 

