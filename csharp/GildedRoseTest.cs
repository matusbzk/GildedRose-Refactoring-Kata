using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void QualityDegradationBeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = 15, Quality = 24 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(23, Items[0].Quality);
            Assert.AreEqual(14, Items[0].SellIn);
        }

        [Test]
        public void QualityDegradationAfterSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = -5, Quality = 13 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(11, Items[0].Quality);
            Assert.AreEqual(-6, Items[0].SellIn);
        }

        [Test]
        public void QualityDegradationAtZeroTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = 0, Quality = 15 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(13, Items[0].Quality);
            Assert.AreEqual(-1, Items[0].SellIn);
        }

        [Test]
        public void QualityGoingBelowZeroBeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Frozen Pizza: Quattro Stagioni", SellIn = 42, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(41, Items[0].SellIn);
        }

        [Test]
        public void QualityGoingBelowZeroAfterSellInFrom0Test()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-16, Items[0].SellIn);
        }

        [Test]
        public void QualityGoingBelowZeroAfterSellInFrom1Test()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 1 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(0, Items[0].Quality);
            Assert.AreEqual(-16, Items[0].SellIn);
        }

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
        public void AgedBrieAfterSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -5, Quality = 7 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(9, Items[0].Quality);
            Assert.AreEqual(-6, Items[0].SellIn);
        }

        [Test]
        public void AgedBrieGoingOver50BeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 15, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
            Assert.AreEqual(14, Items[0].SellIn);
        }

        [Test]
        public void AgedBrieGoingOver50AfterSellInFrom50Test()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -15, Quality = 50 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
            Assert.AreEqual(-16, Items[0].SellIn);
        }

        [Test]
        public void AgedBrieGoingOver50AfterSellInFrom49Test()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -15, Quality = 49 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(50, Items[0].Quality);
            Assert.AreEqual(-16, Items[0].SellIn);
        }

        [Test]
        public void SulfurasTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(0, Items[0].SellIn);
        }

        [Test]
        public void SulfurasBeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(5, Items[0].SellIn);
        }

        [Test]
        public void SulfurasAfterSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras", SellIn = -5, Quality = 80 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(80, Items[0].Quality);
            Assert.AreEqual(-5, Items[0].SellIn);
        }

        [Test]
        public void BackstagePassesLongBeforeSellInTest()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to Apocalyptica concert", SellIn = 25, Quality = 12 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual(13, Items[0].Quality);
            Assert.AreEqual(24, Items[0].SellIn);
        }

    }
}
