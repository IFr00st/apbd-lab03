﻿using lab03.Exceptions;

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
    public void Unload()
    {
        _cargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (_cargoWeight + cargoWeight > _maxload)
        {
            throw new OverfillException("Too big cargo");
        }
    }
}