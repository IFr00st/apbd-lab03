using System.Collections;
using lab03.Containers;
namespace lab03;

public class Ship
{
    private List<Container> Containers;
    private double velocity;
    private int maxContainers;
    private double maxWeight;

    public Ship(List<Container> containers, double velocity, int maxContainers, double maxWeight)
    {
        Containers = containers;
        this.velocity = velocity;
        this.maxContainers = maxContainers;
        this.maxWeight = maxWeight;
    }

    public List<Container> Containers1
    {
        get => Containers;
        set => Containers = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Velocity
    {
        get => velocity;
        set => velocity = value;
    }

    public int MaxContainers
    {
        get => maxContainers;
        set => maxContainers = value;
    }

    public double MaxWeight
    {
        get => maxWeight;
        set => maxWeight = value;
    }
}