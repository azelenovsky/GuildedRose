namespace GildedRose.Console
{
    public class ConcertItem : RetailItem
    {
        public ConcertItem(Item item) : base(item) { }
        protected override void UpdateQuality()
        {
            IncreaseQuality();
            if (SellIn < 11)
            {
                IncreaseQuality();
            }
            if (SellIn < 6)
            {
                IncreaseQuality();
            }
            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }
}
