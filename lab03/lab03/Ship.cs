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
        foreach (var c in list)
        {
            if (Containers.Count == maxContainers)
            {
                throw new Exception(" Too many containers on one ship!!");
            }
            if (c.CargoWeight + c.ContainerWeight + calcCurrentWeight() > maxWeight)
            {
                throw new Exception(" Too heavy weight!!!");
            }
            Containers.Add(c);
        }
    }
    
    public void load(Container c)
    {
        if (Containers.Count == maxContainers)
        {
            throw new Exception(" Too many containers on one ship!!");
        }
        if (c.CargoWeight + c.ContainerWeight + calcCurrentWeight() > maxWeight)
        {
            throw new Exception(" Too heavy weight!!!");
        }
        Containers.Add(c);
        
    }

    public Container remove(String x)
    {
        int index = -1;
        foreach (var cont in Containers)
        {
            if (cont.SerialNumber.Equals(x))
            {
                index = Containers.IndexOf(cont);
            }
            
        }

        Container tmp = null;
      
        

        if (index != -1)
        {
            tmp = Containers[index];
            Containers.RemoveAt(index);
        }

        if (tmp == null)
        {
            throw new Exception(" No such container on ship");
        }    
        return tmp;
    }

    public void replaceCont(String x, Container c)
    {
        remove(x);
        Containers.Add(c);
        
    }

    public void moveContBetweenships(String x, Ship toShip)
    {
        Container tmp = remove(x);
        toShip.load(tmp);
    }

    public double calcCurrentWeight()
    {
        double sum = 0;
        foreach (var cont in Containers)
        {
            sum += cont.CargoWeight + cont.ContainerWeight;
        }

        return sum;
    }

    public override string ToString()
    {
        String x = "";
        foreach (var cont in Containers)
        {
            x += cont;
            x += "\n";
        }
        return "velocity: " + velocity + " maxContainers: " + maxContainers + " maxWeight: " + maxWeight + "\nContainers on ship: \n" + x;
    }
}