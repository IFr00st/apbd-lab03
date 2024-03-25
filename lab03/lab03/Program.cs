using lab03;
using lab03.Containers;

ColdContainer cold = new ColdContainer(14, "Bananas", 10, 10, 10, 10, 0);
Console.Write(cold.CargoWeight +"\n");
cold.Load(5);
Console.Write(cold.CargoWeight + "\n");
cold.Unload();
Console.Write(cold.CargoWeight + "\n");

Ship ship = new Ship(new List<Container>(), 10, 10, 300);
ship.load(cold);
List<Container> list = new List<Container>();
list.Add(new GasContainer(1,1,2,0,40,20));
ship.load(list);

Console.Write(ship);
Console.Write("---------------------------------------\n");
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

LiquidContainer lq = new LiquidContainer(false, 1, 1, 20, 20, 10);
ship.replaceCont("CON-G-1", lq);
Console.Write("---------------------------------------\n");
foreach (var cont in ship.Containers1)
{
    Console.Write(cont + "\n");
}
Ship ship2 = new Ship(new List<Container>(), 30, 20, 50);

ship.moveContBetweenships("CON-L-2", ship2);
Console.Write("---------------------------------------\n");
foreach (var cont in ship2.Containers1)
{
    Console.Write(cont + "\n");
}

