namespace last_semester_labs;

public abstract class Program
{
    static void Main(string[] args)
    {
        // Creating shopping lists
        ShoppingList weeklyGroceries = ShoppingList.GetInstance("Продукты на неделю");
        ShoppingList partySupplies = ShoppingList.GetInstance("Список для вечеринки");
        ShoppingList weeklyGroceriesAgain = ShoppingList.GetInstance("Продукты на неделю"); // Должен вернуть уже созданный экземпляр 'weeklyGroceries'

        // Заполняем списки покупок
        weeklyGroceries.AddItem("Яблоки");
        weeklyGroceries.AddItem("Хлеб");
        partySupplies.AddItem("Воздушные шары");
        partySupplies.AddItem("Чипсы");
        weeklyGroceriesAgain.AddItem("Молоко"); // Должно добавиться в тот же список, что и продукты в начале

        // Вывод
        weeklyGroceries.PrintList();
        partySupplies.PrintList();
        weeklyGroceriesAgain.PrintList(); // 1 и 3 списки одинаковые, тк обращаются к одному объекту

        // Слияние списков
        ShoppingList mergedList = ShoppingList.MergeLists("Соединенный список", weeklyGroceries, partySupplies);
        Console.WriteLine("Соединенный список:");
        mergedList.PrintList();

        // Удаление позиции в списке
        weeklyGroceries.RemoveItem("Яблоки");
        Console.WriteLine();
        weeklyGroceries.PrintList(); // нет яблок

        // Очистка списка покупок
        partySupplies.ClearList();
        Console.WriteLine();
        partySupplies.PrintList(); // пусто
    }
}