using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ImmortalItemTests:ItemBehaviorBase
    {
        [Fact]
        public void DecreaseSellInFurther()
        {
            SetItem(TestItems.ImmortalItem);
            Assert.Equal(0, testItem.SellIn);
        }
        [Fact]
        public void DecreaseSellIn()
        {
            Item item = TestItems.ImmortalItem;
            item.SellIn = 1;
            SetItem(item);
            Assert.Equal(1, testItem.SellIn);
        }
        [Fact]
        public void DecreaseQuality()
        {
            SetItem(TestItems.ImmortalItem);
            Assert.Equal(80, testItem.Quality);
        }
        [Fact]
        public void DecreaseQualityBelow0()
        {
            Item item = TestItems.ImmortalItem;
            item.Quality = 0;
            SetItem(item);
            Assert.Equal(0, testItem.Quality);
        }
        [Fact]
        public void ExpiredDecreaseQualityTwice()
        {
            Item item = TestItems.ImmortalItem;
            item.Quality = 10;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(10, testItem.Quality);
        }
        [Fact]
        public void ExpiredDecreaseQualityBelow0()
        {
            Item item = TestItems.ImmortalItem;
            item.Quality = 0;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(0, testItem.Quality);
        }
    }
}
