using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IElement> products = new List<IElement>() {
            new Book("Чистый код", 1000),
            new Fruit("гранат", 1.5) };

            IVisitor discountVisitir = new DiscountVisitor();
            foreach (var product in products)
            {
                product.Accept(discountVisitir);
            }
                
        }
    }
    public interface IElement
    {
      void Accept(IVisitor visitor);
    }
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }

    public class Book : IElement
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;

        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class Vegetable : IElement
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public Fruit(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }



    public class DiscountVisitor : IVisitor
    {
        public void Visit (Book book)
        {
            double discount = book.Price * 0.9;
            Console.WriteLine($"Книга \"{book.Title}\" со скидкой: {discount}");
        }
        public void Visit(Fruit fruit)
        {
            double discount = fruit.Weight * 100 * 0.8;
            Console.WriteLine($"Фрукт \"{fruit.Name}\" со скидкой: {discount}");
        }
    }
}
