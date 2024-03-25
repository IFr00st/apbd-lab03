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

    public void load(List<Container> list)
    {
        foreach (var VARIABLE in list)
        {
            if (Containers.Count == maxContainers)
            {
                throw new Exception(" Too many containers on one ship!!");
            }
            Containers.Add(VARIABLE);
        }
    }
    
    public void load(Container c)
    {
        if (Containers.Count == maxContainers)
        {
            throw new Exception(" Too many containers on one ship!!");
        }
        Containers.Add(c);
    }

    public void remove(String x)
    {
        int index = -1;
        foreach (var cont in Containers)
        {
            if (cont.SerialNumber.Equals(x))
            {
                index = Containers.IndexOf(cont);
            }
            
        }

        if (index != -1)
        {
            Containers.RemoveAt(index);
        }
    }
    
    
}