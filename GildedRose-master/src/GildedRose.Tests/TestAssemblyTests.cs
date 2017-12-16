using Xunit;
using GildedRose.Console;
using System.Collections.Generic;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth()
        {
            Assert.True(true);
        }

    }

    public static class TestingItems
    {
        public static Item StandardItem
        {
            get
            {
                return new Item
                {
                    Name = "Standard Item",
                    SellIn = 20,
                    Quality = 20
                };
            }
        }
        

        public static Item AgingItem
        {
            get
            {
                return new Item
                {
                    Name = "Aged Brie",
                    SellIn = 20,
                    Quality = 20
                };
            }
        }

        public static Item ConcertItem
        {
            get
            {
                return new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                };
            }
        }

        public static Item ImmortalItem
        {
            get
            {
                return new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                };
            }
        }
    }

    //public class StandardItemTests

    public class ImmortalItemTests // For the Sulfuras item that doesn't age
    {


    }

    
}