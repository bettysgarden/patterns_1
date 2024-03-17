namespace last_semester_labs;

public abstract class Program
{
    static void Main(string[] args)
    {
        try
        {
            const string weeklyGroceriesStr = "Продукты на неделю";
            const string partyShoppingListStr = "Список для вечеринки";

            Person wife = new Person("Маша");
            Person husband = new Person("Джон");

            ShoppingList weeklyGroceries = ShoppingList.GetInstance(weeklyGroceriesStr);
            ShoppingList weeklyGroceriesAgain = ShoppingList.GetInstance(weeklyGroceriesStr); // Должен вернуть уже созданный экземпляр 'weeklyGroceries'

            // Заполняем списки покупок
            wife.AddItemToList(weeklyGroceries, "Яблоки");
            wife.AddItemToList(weeklyGroceriesStr, "Хлеб");
            weeklyGroceries.PrintList();
            
            husband.AddItemToList(weeklyGroceriesStr, "Лимоны");
            husband.AddItemToList(partyShoppingListStr, "Воздушные шары");
            husband.AddItemToList(partyShoppingListStr, "Чипсы");

            husband.ShowList(weeklyGroceriesAgain);
            husband.ShowList(partyShoppingListStr);
            
            wife.GoShopping(weeklyGroceriesStr);
            husband.GoShopping(partyShoppingListStr);
            
            weeklyGroceries.PrintList();
            ShoppingList.GetInstance(partyShoppingListStr).PrintList();
            
            weeklyGroceriesAgain.AddItem("Молоко"); // Должно добавиться в тот же список, что и продукты в начале

            ShoppingList.PrintAllLists();
            ShoppingList.RemoveList(partyShoppingListStr);
            ShoppingList.PrintAllLists();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}