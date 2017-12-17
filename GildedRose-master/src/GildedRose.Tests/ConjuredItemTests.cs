
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class ConjuredItemTests:ItemBehaviorBase
    {
        [Fact]
        public void DecreaseSellIn()
        {
            SetItem(TestItems.ConjuredItem);
            Assert.Equal(2, testItem.SellIn);
        }
        [Fact]
        public void DecreaseSellInFurther()
        {
            Item item = TestItems.ConjuredItem;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(-2, testItem.SellIn);
        }
        [Fact]
        public void DecreaseQualityByFactor2()
        {
            Item item = TestItems.ConjuredItem;
            item.Quality = 10;
            SetItem(item);
            Assert.Equal(8, testItem.Quality);
        }
        [Fact]
        public void DecreaseQualityBelow0()
        {
            Item item = TestItems.ConjuredItem;
            item.Quality = 0;
            SetItem(item);
            Assert.Equal(0, testItem.Quality);
        }
        [Fact]
        public void ExpiredDecreaseQualityByFactor4()
        {
            Item item = TestItems.ConjuredItem;
            item.Quality = 10;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(6, testItem.Quality);
        }
        [Fact]
        public void ExpiredDecreaseQualityBelow0()
        {
            Item item = TestItems.ConjuredItem;
            item.Quality = 0;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(0, testItem.Quality);
        }
    }
}
