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
        _containerid = id++;
        serialNumber = "CON-Typ-" + _containerid;
    }


    public double CargoWeight
    {
        get => _cargoWeight;
        set => _cargoWeight = value;
    }

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

    public double ContainerWeight
    {
        get => _containerWeight;
        set => _containerWeight = value;
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
            this._cargoWeight += cargoWeight;
        }
    }

    public override string ToString()
    {
        return "id: " + _containerid + " SerialNumber: " + serialNumber + " CargoWeight: " + _cargoWeight +
               " CargoHeight: " + _cargoheight + " containerWeight: " + _containerWeight + " containerDepth: " +
               _containerDepth + " maxload: " + _maxload;
    }
}