using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void AgedBrieBeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 7 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(8, Items[0].Quality);
            Assert.AreEqual(4, Items[0].SellIn);
        }

        [Test]
        public void SulfurasBeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(4, Items[0].SellIn);
        }
    }
}
