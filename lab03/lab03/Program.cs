using lab03;
using lab03.Containers;

ColdContainer cold = new ColdContainer(14, "Bananas", 10, 10, 10, 10, 0);
cold.Load(5);
Console.Write(cold.CargoWeight);
Ship ship = new Ship(new List<Container>(), 10, 10, 30);
ship.Containers1.Add(cold);
//ArrayList
List<int> numbers = new List<int>() { 1, 2, 3 };

//Set
HashSet<int> numberSet = new HashSet<int>() { 1, 2, 3 };
//Map


