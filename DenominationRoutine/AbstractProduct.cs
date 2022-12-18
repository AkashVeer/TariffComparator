using TariffComparator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparator
{
    public abstract class AbstractProduct
    {
        public List<Product> PriceChart;
        public string TariffName { get; set; }

        public abstract void CalculateAnnualCosts(double consumption);

        public void PrintChart()
        {
            Console.WriteLine("     Tariff Name            Consumption           AnnualCosts");

            foreach (var item in PriceChart)
            {
                Console.WriteLine(item.TariffName + "          " + item.Consumption + "          " + item.AnnualCosts);
            }
        }
    }
}
