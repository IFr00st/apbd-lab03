using lab03.Interfaces;

namespace lab03.Containers;

public class GasContainer : Container, IHazardNotifier
{
    private double pressure;
    public GasContainer(double pressure,double cargoheight, double containerWeight, double containerDepth, double maxload, double cargoWeight) : base(cargoheight, containerWeight, containerDepth, maxload, cargoWeight)
    {
        this.pressure = pressure;
        serialNumber = "CON-G-" + _containerid;
    }

    public void sendtextnote()
    {
        Console.Out.Write("Dangerous operation !!! \n  " + serialNumber );
    }

    public double Pressure
    {
        get => pressure;
        set => pressure = value;
    }

    public override void Unload()
    {
        _cargoWeight *= 0.05;
    }

    public override string ToString()
    {
        return base.ToString() + " pressure: " + pressure;
    }
}