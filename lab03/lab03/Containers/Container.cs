using lab03.Exceptions;

namespace lab03.Containers;
using lab03.Interfaces;


public class Container : IContainer
{
    protected double _cargoWeight;
    protected double _cargoheight;
    protected double _containerWeight;
    protected double _containerDepth;
    protected static int id = 0;
    protected string serialNumber;
    protected int _containerid;
    protected double _maxload;


    public Container(double cargoheight, double containerWeight, double containerDepth, double maxload, double cargoWeight)
    {
        _cargoWeight = cargoWeight;
        _cargoheight = cargoheight;
        _containerWeight = containerWeight;
        _containerDepth = containerDepth;
        _maxload = maxload;
        CargoWeight = cargoWeight;
        _containerid = id++;
        serialNumber = "CON-C-" + _containerid;
    }


    public double CargoWeight { get; set; }

    public double Cargoheight
    {
        get => _cargoheight;
        set => _cargoheight = value;
    }

    public double ContainerDepth
    {
        get => _containerDepth;
        set => _containerDepth = value;
    }

    public static int Id
    {
        get => id;
        set => id = value;
    }

    public string SerialNumber
    {
        get => serialNumber;
        set => serialNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Containerid
    {
        get => _containerid;
        set => _containerid = value;
    }

    public double Maxload
    {
        get => _maxload;
        set => _maxload = value;
    }

    public virtual void Unload()
    {
        _cargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (_cargoWeight + cargoWeight > _maxload)
        {
            throw new OverfillException("Too big cargo");
        }
        else
        {
            _cargoWeight += cargoWeight;
        }
    }
}