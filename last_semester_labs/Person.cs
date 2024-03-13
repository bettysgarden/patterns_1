namespace last_semester_labs;

public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public void GoShopping(String listName)
    {
        ShoppingList groceries = ShoppingList.GetInstance(listName);
        groceries.ClearList();
    }
    public void GoShopping(ShoppingList groceries)
    {
        groceries.ClearList();
    }
    
    public void ShowList(ShoppingList groceries)
    {
        groceries.PrintList();
    }
    
    public void ShowList(String listName)
    {
        ShoppingList groceries = ShoppingList.GetInstance(listName);
        groceries.PrintList();
    }
    
    public void AddItemToList(String listName, String item)
    {
        ShoppingList groceries = ShoppingList.GetInstance(listName);
        groceries.AddItem(item);
    }     
    
    public void AddItemToList(ShoppingList groceries, String item)
    {
        groceries.AddItem(item);
    }   
    
    public void RemoveItemToList(String listName, String item)
    {
        ShoppingList groceries = ShoppingList.GetInstance(listName);
        groceries.RemoveItem(item);
    }
        
    public void RemoveItemToList(ShoppingList groceries, String item)
    {
        groceries.RemoveItem(item);
    }
    public void CreateList(String listName)
    {
        ShoppingList.GetInstance(listName);
    }
}