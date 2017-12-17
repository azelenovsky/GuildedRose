using GildedRose.Console;
using System.Collections.Generic;
using Xunit;

namespace GildedRose.Tests
{
    public class ConcertItemTests:ItemBehaviorBase
    {
        [Fact]
        public void DecreaseSellIn()
        {
            SetItem(TestItems.ConcertItem);
            Assert.Equal(14, testItem.SellIn);
        }
        [Fact]
        public void DecreaseSellInFurther()
        {
            Item item = TestItems.ConcertItem;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(-2, testItem.SellIn);
        }
        [Fact]
        public void IncreaseQuality()
        {
            SetItem(TestItems.ConcertItem);
            Assert.Equal(21, testItem.Quality);
        }
        [Fact]
        public void IncreaseQualityBelow11()
        {
            Item item = TestItems.ConcertItem;
            item.SellIn = 10;
            SetItem(item);
            Assert.Equal(22, testItem.Quality);
        }
        [Fact]
        public void IncreaseQualityBelow6()
        {
            Item item = TestItems.ConcertItem;
            item.SellIn = 5;
            SetItem(item);
            Assert.Equal(23, testItem.Quality);
        }
        [Fact]
        public void ExpiredDecreaseQuality()
        {
            Item item = TestItems.ConcertItem;
            item.SellIn = -1;
            SetItem(item);
            Assert.Equal(0, testItem.Quality);
        }
    }
}
