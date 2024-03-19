namespace lab03.Containers;
using lab03.Interfaces;


public class Container : IContainer
{
    private double _cargoWeight;


    public Container(double cargoWeight)
    {
        _cargoWeight = cargoWeight;
    }


    public double CargoWeight { get; set; }
    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        throw new NotImplementedException();
    }
}