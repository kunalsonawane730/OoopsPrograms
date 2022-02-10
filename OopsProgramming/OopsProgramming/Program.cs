// See https://aka.ms/new-console-template for more information
using OopsProgramming;

Console.WriteLine("Hello, World!");

InventoryManagement inventoryManagement = new InventoryManagement();
inventoryManagement.ReadData(@"C:\Users\Kunal\OopsPrograms\OopsProgramming\OopsProgramming\Inventory.json");
Console.ReadKey();

