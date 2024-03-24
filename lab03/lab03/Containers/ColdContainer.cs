namespace lab03.Containers;

public class ColdContainer : Container
{
    private String productType;
    private double temp;
    
    public ColdContainer(double temp,String productType,double cargoheight, double containerWeight, double containerDepth, double maxload, double cargoWeight) : base(cargoheight, containerWeight, containerDepth, maxload, cargoWeight)
    {
        this.temp = temp;
        this.productType = productType;
    }
}