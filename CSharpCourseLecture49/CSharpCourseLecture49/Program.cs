using System;

class Product
{
    private decimal price;

    public Product(decimal p)
    {
        this.price = p;
    }

    public virtual string GetDesc()
    {
        return "Price: " + price;
    }
}

class Book: Product
{
    private int pageCount;

    public Book(int pages, decimal p) : base(p)
    {
        this.pageCount = pages;
    }

    public override string GetDesc()
    {
        return base.GetDesc() + ", Page Count: " + this.pageCount;
    }
}

class UseProductClasses
{
    static void Main()
    {
        Book bk = new Book(250, 25.59m);
        Console.WriteLine(bk.GetDesc());
    }
}