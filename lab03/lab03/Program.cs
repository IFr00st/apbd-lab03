using System.Collections.Specialized;
using System.Security.AccessControl;
using lab03;
using lab03.Containers;

ColdContainer cold = new ColdContainer(14, "Bananas", 10, 10, 10, 10, 0);
Console.Write(cold.CargoWeight +"\n");
cold.Load(5);
Console.Write(cold.CargoWeight + "\n");
cold.Unload();
Console.Write(cold.CargoWeight + "\n");

Ship ship = new Ship(new List<Container>(), 10, 10, 30);
ship.load(cold);
List<Container> list = new List<Container>();
list.Add(new GasContainer(1,1,2,0,40,20));
ship.load(list);
foreach (var cont in ship.Containers1)
{
    Console.Write(cont +"\n");
}
ship.remove("CON-C-0");
Console.Write("---------------------------------------\n");
foreach (var cont in ship.Containers1)
{
    Console.Write(cont + "\n");
}

