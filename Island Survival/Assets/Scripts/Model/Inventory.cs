using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Inventory
{
    private Resource[] _resources;
    private List<Item> _items;

    public Inventory ()
    {
        _items = new List<Item>();       
        _resources = new Resource[Enum.GetNames(typeof(TypeOfResources)).Length];
        Array array = Enum.GetValues(typeof(TypeOfResources));
        for (int i = 0; i < _resources.Length; i++)
        {
            _resources[i] = new Resource(0, (int)array.GetValue(i), (TypeOfResources)array.GetValue(i));
        }
    }


    // Методы добавления и удаление ресурса
}

