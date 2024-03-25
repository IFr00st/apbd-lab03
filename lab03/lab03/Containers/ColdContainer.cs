namespace lab03.Containers;

public class ColdContainer : Container
{
    public static Dictionary<String, double> productTemps = ColdContainer.createProductTemp() ;
    private String productType;
    private double temp;
    
    public ColdContainer(double temp,String productType,double cargoheight, double containerWeight, double containerDepth, double maxload, double cargoWeight) : base(cargoheight, containerWeight, containerDepth, maxload, cargoWeight)
    {
        if (!productTemps.ContainsKey(productType))
        {
            throw new Exception("Can't transport this cargo");
            
        }
        else if (productTemps[productType] > temp)
        {
            throw new Exception("Too low temperature");
        }
        else
        {
            this.temp = temp;
            this.productType = productType;
            serialNumber = "CON-C-" + _containerid;
        }
    }


    public static Dictionary<String, double> createProductTemp()
    {
        Dictionary<String, double> tmp = new Dictionary<string, double>();
        tmp.Add("Bananas", 13.3);
        tmp.Add("Chocolate", 18);
        tmp.Add("Fish", 2);
        tmp.Add("Meat", -15);
        tmp.Add("Ice cream", -18);
        tmp.Add("Frozen pizza", -30);
        tmp.Add("Cheese", 7.2);
        tmp.Add("Sausages", 5);
        tmp.Add("Butter", 20.5);
        tmp.Add("Eggs", 19);

        return tmp;

    }

    public override string ToString()
    {
        return base.ToString() + " productType: " + productType + " temp: " + temp;
    }
}