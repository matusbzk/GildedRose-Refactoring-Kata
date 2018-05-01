using System.Collections.Generic;
using System.Linq;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public Item UpdateQuality(Item item)
        {
            if (item.Name.ToLower().Contains("sulfuras"))
            {
                return item;
            }

            item.SellIn--;

            int qualityDifference = item.Quality > 0 && item.Quality < 50 ? -1 : 0;

            if (item.Name.ToLower().Contains("aged brie") || item.Name.ToLower().Contains("backstage passes"))
            {
                qualityDifference *= -1;
            }

            if (item.Name.ToLower().Contains("backstage passes"))
            {
                if (item.SellIn < 11)
                {
                    qualityDifference += 1;
                }

                if (item.SellIn < 6)
                {
                    qualityDifference += 1;
                }
            }

            item.Quality += qualityDifference;

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (!item.Name.ToLower().Contains("backstagepasses"))
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality = item.Quality - 1;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            return item;
        }

        public void UpdateQuality()
        {
            this.Items = this.Items
                .Select(this.UpdateQuality)
                .ToList();
        }
    }
}
