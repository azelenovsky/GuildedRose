using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class AgingItemTests : ItemBehaviorBase
    {
        [Fact]
        public void DecreaseSellIn()
        {
            SetItem(TestItems.AgingItem);
            Assert.Equal(1, testItem.SellIn);
        }
        [Fact]
        public void DecreaseSellInFurther()
        {
            Item item = TestItems.AgingItem;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(-2, testItem.SellIn);
        }
        [Fact]
        public void IncreaseQuality()
        {
            SetItem(TestItems.AgingItem);
            Assert.Equal(1, testItem.Quality);
        }
        [Fact]
        public void IncreaseQualityBeyondMax()
        {
            Item item = TestItems.AgingItem;
            item.Quality = ItemBehaviorBase.MAX_Quality;
            SetItem(item);
            Assert.Equal(ItemBehaviorBase.MAX_Quality, testItem.Quality);
        }
        [Fact]
        public void ExpiredIncreaseQualityTwice()
        {
            Item item = TestItems.AgingItem;
            item.Quality = 10;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(12, testItem.Quality);
        }
        [Fact]
        public void ExpiredIncreaseQualityBeyondMax()
        {
            Item item = TestItems.AgingItem;
            item.Quality = ItemBehaviorBase.MAX_Quality;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(ItemBehaviorBase.MAX_Quality, testItem.Quality);
        }
    }
}
