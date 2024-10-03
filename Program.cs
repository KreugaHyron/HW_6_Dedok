using HW_6_Dedok;
//1-3
using (Play play = new Play("Hamlet", "William Shakespeare", "Tragedy", 1600))
{
    play.DisplayInfo();
}
Console.WriteLine("Program has ended.");
Console.WriteLine();
//2-3
using (Store store = new Store("SuperMart", "123 Main St", Store.StoreType.Grocery))
{
    store.DisplayInfo();
}
Store anotherStore = new Store("ClothHouse", "456 Fashion Ave", Store.StoreType.Clothing);
anotherStore.DisplayInfo();
anotherStore.Dispose();

Console.WriteLine("Program has ended.");