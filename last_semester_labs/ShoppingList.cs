namespace last_semester_labs;

public class ShoppingList
{
    private string Name { get; }
    private List<string> Items { get; }

    // Приватный конструктор -- Singleton
    private ShoppingList(string name)
    {
        Name = name;
        Items = new List<string>();
    }

    // Словарь чтобы хранить экземпляры
    private static readonly Dictionary<string, ShoppingList> ShoppingLists = new Dictionary<string, ShoppingList>();

    public static ShoppingList GetInstance(string name)
    {
        if (!ShoppingLists.ContainsKey(name))
        {
            ShoppingLists[name] = new ShoppingList(name);
        }
        return ShoppingLists[name];
    }

    // Метод для добавления 
    public void AddItem(string item)
    {
        Items.Add(item);
    }

    // Метод для удаления позиций 
    public void RemoveItem(string item)
    {
        Items.Remove(item);
    }

    // Метод для соединения двух списков 
    public static ShoppingList MergeLists(string newListName, ShoppingList list1, ShoppingList list2)
    {
        ShoppingList mergedList = GetInstance(newListName);

        foreach (var item in list1.Items)
        {
            mergedList.AddItem(item);
        }

        foreach (var item in list2.Items)
        {
            mergedList.AddItem(item);
        }

        return mergedList;
    }

    // Метод для очистки списка покупок
    public void ClearList()
    {
        Items.Clear();
    }

    // Метод для печати списка покупок
    public void PrintList()
    {
        Console.WriteLine($"Список покупок: {Name}");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item}");
        }
        Console.WriteLine();
    }
}