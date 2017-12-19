namespace GildedRose.Console
{
    public class RetailItem
    {
        private Item item;
        public int Quality
        {
            get { return item.Quality; }
            set { item.Quality = value; }
        }

        public int SellIn
        {
            get { return item.SellIn; }
            set { item.SellIn = value; }
        }

        public RetailItem(Item item)
        {
            this.item = item;
        }

        public void Update()
        {
            UpdateQuality();
            UpdateSellIn();
        }

        protected virtual void UpdateQuality()
        {
            DecreaseQuality();
            if (SellIn < 0)
                DecreaseQuality();
        }

        protected virtual void UpdateSellIn()
        {
            SellIn--;
        }

        protected virtual void DecreaseQuality()
        {
            if (Quality > 0)
                Quality--;
        }
        protected virtual void IncreaseQuality()
        {
            if (Quality < 50)
                Quality++;
        }
        protected virtual bool IsItemExpired()
        {
            return SellIn < 0;
        }
    }
}
