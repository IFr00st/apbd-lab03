using System.Collections;
using lab03.Containers;
using Container = System.ComponentModel.Container;

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
}