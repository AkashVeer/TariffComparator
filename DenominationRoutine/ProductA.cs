using TariffComparator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparator
{
    public class ProductA : AbstractProduct
    {
        private readonly double BaseCostPerMonth = 5;
        private readonly double ConsumptionCostPerUnit = 0.22;
        public ProductA()
        {
            TariffName = "Basic electricity tariff";
            PriceChart = new List<Product>();
        }

        public override void CalculateAnnualCosts(double consumption)
        {
            double TotalBaseCostPerYear = BaseCostPerMonth * 12;
            double TotalConsumptionCost = TotalBaseCostPerYear + consumption * ConsumptionCostPerUnit;
            PriceChart.Add(new Product()
            {
                TariffName = this.TariffName,
                Consumption = consumption,
                AnnualCosts = TotalConsumptionCost
            });
        }
    }
}
