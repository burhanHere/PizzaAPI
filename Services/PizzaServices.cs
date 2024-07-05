using WetherForcast.Models;

namespace WetherForcast.Services;

public static class PizzaService
{
    static List<Pizza> MyPizzas { get; }
    static int NextId = 3;
    static PizzaService()
    {
        MyPizzas =
        [
            new Pizza{ Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza{ Id = 2, Name = "Veggie", IsGlutenFree = true }
        ];
    }
    public static List<Pizza> GetAll() => MyPizzas;
    public static Pizza Get(int id)
    {
        return MyPizzas.FirstOrDefault(p => p.Id == id) ?? new Pizza();
    }
    public static void Add(Pizza newPizza)
    {
        newPizza.Id = NextId++;
        MyPizzas.Add(newPizza);
    }
    public static void Delete(int id)
    {
        var ItemToDelete = Get(id);
        if (ItemToDelete.Id == 0)
        {
            return;
        }
        MyPizzas.Remove(ItemToDelete);
    }
    public static void Update(Pizza updatedPizza)
    {
        var index = MyPizzas.FindIndex(p => p.Id == updatedPizza.Id);
        if (index == -1)
        {
            return;
        }
        MyPizzas[index] = updatedPizza;
    }
}