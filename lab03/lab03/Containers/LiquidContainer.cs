using lab03.Interfaces;

namespace lab03.Containers;

public class LiquidContainer : Container, IHazardNotifier
    
{
    private bool dangerous;
    public LiquidContainer(bool dangerous, double cargoheight, double containerWeight, double containerDepth, double maxload, double cargoWeight) : base(cargoheight, containerWeight, containerDepth, maxload, cargoWeight)
    {
        this.dangerous = dangerous;
        _containerid = id++;
        serialNumber = "CON-L-" + _containerid;
    }

    public override void Load(double cargoWeight)
    {
        if ((dangerous && _cargoWeight + cargoWeight > _maxload * 0.5)|| (!dangerous && _cargoWeight + cargoWeight > _maxload* 0.9))
        { 
            sendtextnote();
        }
        else
        {
            _cargoheight += cargoWeight;
        }
    }
    

    public void sendtextnote()
    {
        Console.Out.Write("Dangerous operation !!! \n  " + serialNumber );
    }
}