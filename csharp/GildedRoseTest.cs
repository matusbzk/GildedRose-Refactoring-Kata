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
        public void QualityDegradationGoingToZeroTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Frozen Pizza: Hawai", SellIn = 1, Quality = 15 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(14, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
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
        public void BackstagePassesAtSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Backstage passes to Helena Vondrackova concert", SellIn = 1, Quality = 2 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(5, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
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

        [Test]
        public void ConjuredQualityDegradationBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Hawai", SellIn = 15, Quality = 24 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(22, items[0].Quality);
            Assert.AreEqual(14, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityDegradationAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Hawai", SellIn = -5, Quality = 13 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].Quality);
            Assert.AreEqual(-6, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityDegradationAtZeroTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Hawai", SellIn = 0, Quality = 15 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(11, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityGoingBelowZeroBeforeSellInFrom0Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Quattro Stagioni", SellIn = 42, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(41, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityGoingBelowZeroBeforeSellInFrom1Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Quattro Stagioni", SellIn = 42, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(41, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityGoingBelowZeroAfterSellInFrom0Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityGoingBelowZeroAfterSellInFrom1Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 1 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void ConjuredQualityGoingBelowZeroAfterSellInFrom3Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Frozen Pizza: Quattro Stagioni", SellIn = -15, Quality = 3 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Aged Brie", SellIn = 5, Quality = 7 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(9, items[0].Quality);
            Assert.AreEqual(4, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Aged Brie", SellIn = -5, Quality = 7 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(11, items[0].Quality);
            Assert.AreEqual(-6, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieGoingOver50BeforeSellInFrom50Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Aged Brie", SellIn = 15, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(14, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieGoingOver50BeforeSellInFrom49Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Aged Brie", SellIn = 15, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(14, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieGoingOver50AfterSellInFrom50Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Aged Brie", SellIn = -15, Quality = 50 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieGoingOver50AfterSellInFrom49Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ConjuredAged Brie", SellIn = -15, Quality = 49 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void ConjuredAgedBrieGoingOver50AfterSellInFrom47Test()
        {
            IList<Item> items = new List<Item> { new Item { Name = "ConjuredAged Brie", SellIn = -15, Quality = 47 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(50, items[0].Quality);
            Assert.AreEqual(-16, items[0].SellIn);
        }

        [Test]
        public void ConjuredSulfurasTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Sulfuras", SellIn = 0, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(0, items[0].SellIn);
        }

        [Test]
        public void ConjuredSulfurasBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Sulfuras", SellIn = 5, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(5, items[0].SellIn);
        }

        [Test]
        public void ConjuredSulfurasAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Sulfuras", SellIn = -5, Quality = 80 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(80, items[0].Quality);
            Assert.AreEqual(-5, items[0].SellIn);
        }

        [Test]
        public void ConjuredBackstagePassesLongBeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Backstage passes to Lordi concert", SellIn = 25, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(14, items[0].Quality);
            Assert.AreEqual(24, items[0].SellIn);
        }

        [Test]
        public void ConjuredBackstagePasses10To6BeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Backstage passes to Iron Maiden concert", SellIn = 7, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(16, items[0].Quality);
            Assert.AreEqual(6, items[0].SellIn);
        }

        [Test]
        public void ConjuredBackstagePasses5To1BeforeSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Backstage passes to Baby Metal concert", SellIn = 4, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(18, items[0].Quality);
            Assert.AreEqual(3, items[0].SellIn);
        }

        [Test]
        public void ConjuredBackstagePassesAtZeroTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Backstage passes to Satanica concert", SellIn = 0, Quality = 12 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-1, items[0].SellIn);
        }

        [Test]
        public void ConjuredBackstagePassesAfterSellInTest()
        {
            IList<Item> items = new List<Item> { new Item { Name = "Conjured Backstage passes to Peter Stasak concert", SellIn = -5, Quality = 0 } };
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.AreEqual(0, items[0].Quality);
            Assert.AreEqual(-6, items[0].SellIn);
        }

    }
}
