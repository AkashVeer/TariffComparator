using TariffComparator;
using System.Runtime.Versioning;

public class Program
{

    public static void Main()
    {
        double[] Consumption = { 3500, 4500, 6000 };

        AbstractProduct productA = new ProductA();
        AbstractProduct productB = new ProductB();


        foreach (var item in Consumption)
        {
            productA.CalculateAnnualCosts(item);
            productB.CalculateAnnualCosts(item);
        }

        productA.PrintChart();
        productB.PrintChart();

    }

    
}
