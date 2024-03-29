namespace last_semester_labs;

public class ShoppingList
{
    private static readonly Dictionary<string, ShoppingList> instances = new Dictionary<string, ShoppingList>();
    private static readonly int maxLists = 3; // Ограничение на количество списков покупок
    private static int currentLists = 0;

    public string Name { get; }

    private List<string> items = new List<string>();
    public IReadOnlyList<string> Items => items;

    // Приватный конструктор -- Singleton
    private ShoppingList(string name)
    {
        Name = name;
    }

    // Словарь чтобы хранить экземпляры
    private static readonly Dictionary<string, ShoppingList> ShoppingLists = new Dictionary<string, ShoppingList>();


    // Получение экземпляра списка покупок по имени
    public static ShoppingList GetInstance(string name)
    {
        if (!instances.ContainsKey(name))
        {
            if (currentLists < maxLists)
            {
                instances[name] = new ShoppingList(name);
                currentLists++;
            }
            else
            {
                throw new InvalidOperationException("Достигнуто максимальное количество списков.");
            }
        }

        return instances[name];
    }

    // Метод для добавления 
    public void AddItem(string item)
    {
        items.Add(item);
    }

    // Метод для удаления позиций 
    public void RemoveItem(string item)
    {
        items.Remove(item);
    }

    // Метод для очистки списка покупок
    public void ClearList()
    {
        items.Clear();
    }

    // Метод для печати списка покупок
    public void PrintList()
    {
        Console.WriteLine($"Список покупок: {Name}");
        bool isEmpty = true;
        foreach (var item in Items)
        {
            isEmpty = false;
            Console.WriteLine($"- {item}");
        }

        if (isEmpty)
            Console.WriteLine("<пусто>");
        Console.WriteLine();
    }

    // Метод для удаления списка покупок
    public static void RemoveList(string name)
    {
        if (instances.ContainsKey(name))
        {
            instances.Remove(name);
            currentLists--;
        }
    }

    // Метод для вывода всех существующих списков
    public static void PrintAllLists()
    {
        Console.WriteLine("Существующие списки:");
        foreach (var shoppingList in instances.Values)
        {
            Console.WriteLine($"- {shoppingList.Name}");
        }

        Console.WriteLine();
    }
}