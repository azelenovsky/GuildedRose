using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        public IList<Item> Items;
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var app = new Program()
                          {
                              Items = new List<Item>
                                          {
                                              new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                                              new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                                              new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                                              new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                                              new Item
                                                  {
                                                      Name = "Backstage passes to a TAFKAL80ETC concert",
                                                      SellIn = 15,
                                                      Quality = 20
                                                  },
                                              new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                                          }

                          };


            app.UpdateQuality();

            System.Console.ReadKey();

        }

        //public void UpdateQuality() 
        //{
        //    for (var i = 0; i < Items.Count; i++)
        //    {
        //        if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //        {
        //            if (Items[i].Quality > 0)
        //            {
        //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                {
        //                    Items[i].Quality = Items[i].Quality - 1;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
        //                Items[i].Quality = Items[i].Quality + 1;

        //                if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].SellIn < 11)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }

        //                    if (Items[i].SellIn < 6)
        //                    {
        //                        if (Items[i].Quality < 50)
        //                        {
        //                            Items[i].Quality = Items[i].Quality + 1;
        //                        }
        //                    }
        //                }
        //            }
        //        }

        //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //        {
        //            Items[i].SellIn = Items[i].SellIn - 1;
        //        }

        //        if (Items[i].SellIn < 0)
        //        {
        //            if (Items[i].Name != "Aged Brie")
        //            {
        //                if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //                {
        //                    if (Items[i].Quality > 0)
        //                    {
        //                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                        {
        //                            Items[i].Quality = Items[i].Quality - 1;
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //                }
        //            }
        //            else
        //            {
        //                if (Items[i].Quality < 50)
        //                {
        //                    Items[i].Quality = Items[i].Quality + 1;
        //                }
        //            }
        //        }
        //    }
        //}
        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateItemQuality(item);
                UpdateSellIn(item);
            }
        }
        public void UpdateSellIn(Item item)
        {
            if (!IsImmortal(item))
            {
                item.SellIn--;
            }
        }
        private void UpdateItemQuality(Item item)
        {
            if (IsAging(item))
            {
                UpdateAgingItemQuality(item);
            }
            else if (IsConcert(item))
            {
                UpdateConcertItemQuality(item);
            }
            else if (IsConjured(item))
            {
                UpdateConjuredItemQuality(item);
            }
            else if (!IsImmortal(item))
            {
                UpdateStandartItemQuality(item);
            }
        }
        private void UpdateAgingItemQuality(Item item)
        {
            IncreaseQuality(item);
            if (IsExpired(item))
            {
                IncreaseQuality(item);
            }
        }
        private void UpdateConcertItemQuality(Item item)
        {
            IncreaseQuality(item);
            if (item.SellIn < 11)
            {
                IncreaseQuality(item);
            }
            if (item.SellIn < 6)
            {
                IncreaseQuality(item);
            }
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }
        private void UpdateStandartItemQuality(Item item)
        {
            DecreaseQuality(item);
            if (item.SellIn < 0)
                DecreaseQuality(item);
        }
        private void UpdateConjuredItemQuality(Item item)
        {
            UpdateStandartItemQuality(item);
            UpdateStandartItemQuality(item);
        }
        private bool IsImmortal(Item item)
        {
            return item.Name.Equals("Sulfuras, Hand of Ragnaros");
        }
        private bool IsAging(Item item)
        {
            return item.Name.Equals("Aged Brie");
        }
        private bool IsConcert(Item item)
        {
            return item.Name.Equals("Backstage passes to a TAFKAL80ETC concert");
        }
        private bool IsConjured(Item item)
        {
            return item.Name.Equals("Conjured Mana Cake");
        }
        private bool IsExpired(Item item)
        {
            return item.SellIn < 0;
        }
        private void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
                item.Quality--;
        }
        private void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
                item.Quality++;
        }
    }

    public class Item
    {
        public string Name { get; set; } 

        public int SellIn { get; set; } 

        public int Quality { get; set; } 

    }

}
