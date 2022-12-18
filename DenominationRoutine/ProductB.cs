using TariffComparator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparator
{
    public class ProductB : AbstractProduct
    {
        private readonly double FixedCost = 800;
        private readonly double FixedConsumption = 4000;
        private readonly double ConsumptionCostPerUnit = 0.30;
        public ProductB()
        {
            TariffName = "Packaged tariff";
            PriceChart = new List<Product>();
        }

        public override void CalculateAnnualCosts(double consumption)
        {
            double TotalConsumptionCost = 0;
            if (consumption <= FixedConsumption)
                TotalConsumptionCost = FixedCost;
            else
                TotalConsumptionCost = FixedCost + (consumption - FixedConsumption) * ConsumptionCostPerUnit;
            PriceChart.Add(new Product()
            {
                TariffName = this.TariffName,
                Consumption = consumption,
                AnnualCosts = TotalConsumptionCost
            });
        }
    }
}
