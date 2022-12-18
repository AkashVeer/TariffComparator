namespace TariffComparator.Tests
{
    public class Tests
    {
        

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ProductA_GivenConsumption_CalculateAnnualCost_EntersToList_ShouldBeSuccessFul()
        {
            AbstractProduct productA = new ProductA();
            productA.CalculateAnnualCosts(3500);
            Assert.AreEqual(1, productA.PriceChart.Count);
            Assert.AreEqual("Basic electricity tariff", productA.PriceChart.First().TariffName);
            Assert.AreEqual(830, productA.PriceChart.First().AnnualCosts);
        }

        [Test]
        public void ProductB_GivenConsumption_CalculateAnnualCost_EntersToList_ShouldBeSuccessFul()
        {
            AbstractProduct productA = new ProductB();
            productA.CalculateAnnualCosts(3500);
            Assert.AreEqual(1, productA.PriceChart.Count);
            Assert.AreEqual("Packaged tariff", productA.PriceChart.First().TariffName);
            Assert.AreEqual(800, productA.PriceChart.First().AnnualCosts);
        }
    }
}