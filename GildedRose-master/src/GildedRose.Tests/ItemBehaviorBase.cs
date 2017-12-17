using System.Collections.Generic;
using GildedRose.Console;

namespace GildedRose.Tests
{
    public class ItemBehaviorBase
    {
        protected static readonly int MAX_Quality = 50;

        protected Item testItem;

        protected void SetItem (Item item)
        {
            testItem = item;
            Program app = new Program()
            {
                Items = new List<Item>
                {
                    item,
                }
            };
            app.UpdateQuality();
        }
    }
}
