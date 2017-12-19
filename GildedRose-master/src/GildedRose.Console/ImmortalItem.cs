namespace GildedRose.Console
{
    public class ImmortalItem : RetailItem
    {
        public ImmortalItem(Item item) : base(item) { }
        protected override void UpdateQuality() { }
        protected override void UpdateSellIn() { }
    }
}
