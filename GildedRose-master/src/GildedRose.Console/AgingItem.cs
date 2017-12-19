

namespace GildedRose.Console
{
    public class AgingItem : RetailItem
    {
        public AgingItem(Item item) : base(item) { }
        protected override void UpdateQuality()
        {
            IncreaseQuality();
            if (IsItemExpired())
            {
                IncreaseQuality();
            }
        }
    }
}