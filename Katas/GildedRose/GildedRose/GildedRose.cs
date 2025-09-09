using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<IProduct> Items = new List<IProduct>();
    //IProduct product = null;

    public GildedRose(IList<Item> OriginalItems)
    {
        for (var i = 0; i < OriginalItems.Count; i++)
        {
            IProduct newProduct = ProductFactory.Create(OriginalItems[i]);
            Items.Add(newProduct);
        }
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            Items[i].Update();
        }
    }
}

public interface IProduct
{
    string Name { get; set; }
    int SellIn { get; set; }
    int Quality { get; set; }

    public void Update();
}

public class Sulfuras : IProduct
{
    public Sulfuras(Item item)
    {
        Name = item.Name;
        SellIn = item.SellIn;
        Quality = item.Quality;
    }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update() { }

}

public class BackStagePass : IProduct
{
    public BackStagePass(Item item)
    {
        Name = item.Name;
        SellIn = item.SellIn;
        Quality = item.Quality;
    }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update() {
        if (Quality < 50)
        {
            Quality = Quality + 1;
            if (SellIn < 11)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }

            if (SellIn < 6)
            {
                if (Quality < 50)
                {
                    Quality = Quality + 1;
                }
            }
        }

        SellIn = SellIn - 1;

        if (SellIn < 0)
        {
            Quality = Quality - Quality;
        }

    }
}

public class AgedBrie : IProduct
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public AgedBrie(Item item)
    {
        Name = item.Name;
        SellIn = item.SellIn;
        Quality = item.Quality;
    }

    public void Update()
    {
        if (Quality < 50)
        {
            Quality = Quality + 1;
        }

        SellIn = SellIn - 1;

        if (SellIn < 0)
        {
            if (Quality < 50)
            {
                Quality = Quality + 1;
            }
        }
    }
}

public class GenericItem : IProduct
{
    public GenericItem(Item item)
    {
        Name = item.Name;
        SellIn = item.SellIn;
        Quality = item.Quality;
    }

    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    public void Update()
    {
        if (Quality > 0)
        {
            Quality = Quality - 1;
        }

        SellIn = SellIn - 1;

        if (SellIn < 0)
        {
            if (Quality > 0)
            {

                Quality = Quality - 1;

            }
        }
    }

}

public class ProductFactory 
{
    public static IProduct Create(Item item)
    {
        switch (item.Name)
        {
            case "Backstage passes to a TAFKAL80ETC concert":
                return new BackStagePass(item);
            case "Aged Brie":
                return new AgedBrie(item);
            case "Sulfuras, Hand of Ragnaros":
                return new Sulfuras(item);
            default:
                return new GenericItem(item);
        }
    }

}
