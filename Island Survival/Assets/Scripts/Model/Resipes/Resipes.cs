
public readonly struct Resipes
{
    public readonly Resource[] Cost;
    public readonly Item Result;
    public readonly string Name;
    public readonly int ResipesLvl;
    

    public Resipes(Resource[] cost, Item result, string name, int resipesLvl)
    {
        Cost = cost;
        Result = result;
        Name = name;
        ResipesLvl = resipesLvl;
        
    }
}