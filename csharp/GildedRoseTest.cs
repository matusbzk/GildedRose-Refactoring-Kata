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
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = 15, Quality = 24 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(23, items[0].Quality);
            Assert.AreEqual(14, items[0].SellIn);
        }

        [Test]
        public void QualityDegradationAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = -5, Quality = 13 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(11, items[0].Quality);
            Assert.AreEqual(-6, items[0].SellIn);
        }

        [Test]
        public void QualityDegradationAtZeroTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = 0, Quality = 15 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(13, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }

        [Test]
        public void QualityGoingBelowZeroBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Quattro Stagioni", SellIn = 42, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(41, items[0].SellIn);
        }

        [Test]
        public void QualityGoingBelowZeroAfterSellInFrom0Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void QualityGoingBelowZeroAfterSellInFrom1Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void AgedBrieBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 5, Quality = 7 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(8, items[0].Quality);
            Assert.AreEqual(4, items[0].SellIn);
        }

        [Test]
        public void AgedBrieAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -5, Quality = 7 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].Quality);
            Assert.AreEqual(-6, items[0].SellIn);
        }

        [Test]
        public void AgedBrieGoingOver50BeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 15, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(14, items[0].SellIn);
        }

        [Test]
        public void AgedBrieGoingOver50AfterSellInFrom50Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -15, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void AgedBrieGoingOver50AfterSellInFrom49Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Aged Brie", SellIn = -15, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void SulfurasTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
        }

        [Test]
        public void SulfurasBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(5, items[0].SellIn);
        }

        [Test]
        public void SulfurasAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Sulfuras", SellIn = -5, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(-5, items[0].SellIn);
        }

        [Test]
        public void BackstagePassesLongBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to Apocalyptica concert", SellIn = 25, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(13, items[0].Quality);
            Assert.AreEqual(24, items[0].SellIn);
        }

        [Test]
        public void BackstagePasses10To6BeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to Metallica concert", SellIn = 7, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(14, items[0].Quality);
            Assert.AreEqual(6, items[0].SellIn);
        }

        [Test]
        public void BackstagePasses5To1BeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to Baby Metal concert", SellIn = 4, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(15, items[0].Quality);
            Assert.AreEqual(3, items[0].SellIn);
        }

        [Test]
        public void BackstagePassesAtZeroTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to Evanescence concert", SellIn = 0, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }

        [Test]
        public void BackstagePassesAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to Martin Jakubec concert", SellIn = -5, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-6, items[0].SellIn);
        }


    }
}
