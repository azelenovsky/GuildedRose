using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class StandardItemTests:ItemBehaviorBase
    {
        [Fact]
        public void StandardItemDecreaseInQuality()
        {
            SetItem(TestItems.StandardItem);
            Assert.Equal(19, testItem.Quality);
        }

        [Fact]
        public void StandardItemQualityNeverNegative()
        {
            Item item = TestItems.StandardItem;
            item.Quality = 0;
            SetItem(item);
            Assert.Equal(0, testItem.Quality);
        }

        [Fact]
        public void StandardItemDecreaseSellIn()
        {
            SetItem(TestItems.StandardItem);
            Assert.Equal(19, testItem.SellIn);
        }

        [Fact]
        public void StandardItemDecreaseSellInFurther()
        {
            Item item = TestItems.StandardItem;
            item.SellIn = -1;

            SetItem(item);
            Assert.Equal(-2, testItem.SellIn);
        }

        [Fact]
        public void ExpiredStandardItemQualityDecrease2x()
        {
            Item item = TestItems.StandardItem;
            item.SellIn = -1;
            item.Quality = 10;

            SetItem(item);
            Assert.Equal(8, testItem.Quality);
        }

        [Fact]
        public void ExpiredStandardItemQualityPositive ()
        {
            Item item = TestItems.StandardItem;
            item.SellIn = -1;
            item.Quality = 0;

            SetItem(item);
            Assert.Equal(0, testItem.Quality);

        }

    }
}
