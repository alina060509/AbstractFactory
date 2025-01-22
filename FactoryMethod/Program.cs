using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
//порождающий 
namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите тип доставки: 1-пицца, 2-суши, 3-бургер");
            int choice = int.Parse(Console.ReadLine());
            Delivery delivery;

            switch (choice)
            {
                case 1:
                    delivery = new PizzaDelivery();
                    break;
                case 2:
                    delivery = new SushiDelivery();
                    break;
                case 3:
                    delivery = new BurgerDelivery();
                    break;
                default:
                    Console.WriteLine("некоректный выбор(");
                    return;
            }
            delivery.Deliver();
        }
    }
    //абстрактнфй продукт
    public abstract class Food
    {
        public abstract void Prepare();
    }
    //конкретный продукт
    public class Pizza : Food
    {
        public override void Prepare()
        {
            Console.WriteLine("пицца готовиться с грибами");
        }
    }
    //конкретный продукт
    public class Sushi : Food
    {
        public override void Prepare()
        {
            Console.WriteLine("суши готовяться с рыбкой и рисом");
        }
    }
    //конкретный продукт
    public class Burger : Food
    {
        public override void Prepare()
        {
            Console.WriteLine("бургер готовиться с булочкой, салатиком и котлетой");
        }
    }
    public abstract class Delivery
    {
        //фабричный метод
        public abstract Food CreateFood();
       public void Deliver()
        {
            var food = CreateFood();
            food.Prepare();
            Console.WriteLine("доставка выполнена!");
        }
    }
    public class PizzaDelivery : Delivery
    {
        public override Food CreateFood()
        {
            return new Pizza();
        }
    }
    public class SushiDelivery : Delivery
    {
        public override Food CreateFood()
        {
            return new Sushi();
        }
    }
    public class BurgerDelivery : Delivery
    {
        public override Food CreateFood()
        {
            return new Burger();
        }
    }
}

