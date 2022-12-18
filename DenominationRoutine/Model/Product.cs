using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TariffComparator.Model
{
    public class Product
    {
        public double Consumption { get; set; }
        public double AnnualCosts { get; set; }
        public string TariffName { get; set; }
    }
}
