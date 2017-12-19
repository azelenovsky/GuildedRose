
namespace GildedRose.Console
{
    public class RetailFactory
    {
        private static bool IsImmortal(Item item)
        {
            return item.Name.Equals("Sulfuras, Hand of Ragnaros");
        }
        private static bool IsAging (Item item)
        {
            return item.Name.Equals("Aged Brie");
        }
        private static bool IsConcert(Item item)
        {
            return item.Name.Equals("Backstage passes to a TAFKAL80ETC concert");
        }
        private static bool IsConjured(Item item)
        {
            return item.Name.Equals("Conjured Mana Cake");
        }
        public static RetailItem CreateItem(Item item)
        {
            if (IsAging(item))
                return new AgingItem(item);
            else if (IsConcert(item))
                return new ConcertItem(item);
            else if (IsImmortal(item))
                return new ImmortalItem(item);
            else if (IsConjured(item))
                return new ConjuredItem(item);
            return new RetailItem(item);
        }
    }
}
