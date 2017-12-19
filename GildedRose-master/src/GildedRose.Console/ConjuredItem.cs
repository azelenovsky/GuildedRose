namespace GildedRose.Console
{
    public class ConjuredItem:RetailItem
    {
        public ConjuredItem(Item item) : base(item) { }
        protected override void UpdateQuality()
        {
            base.UpdateQuality();
            base.UpdateQuality();
        }
    }
}
