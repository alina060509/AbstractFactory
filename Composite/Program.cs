using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //            MenuItem pizza = new MenuItem("пицца");
            //            MenuItem iceCream = new MenuItem("мороженое");
            //            MenuItem pasta = new MenuItem("паста");

            //            Menu desertMenu = new Menu("десерты:");
            //            desertMenu.Add(iceCream);

            //            Menu mainMenu = new Menu("основное меню:");
            //            mainMenu.Add(pasta);
            //            mainMenu.Add(pizza);
            //            mainMenu.Add(desertMenu);
            //;

            //            mainMenu.Display();

            Menu firstDishesMenu = new Menu("\tПервые блюда:");
            Menu secondDishesMenu = new Menu("Вторые блюда:");
            Menu desertMenu = new Menu("Десерты:");
            Menu saladMenu = new Menu("\tСалаты:");

            MenuItem dishes1 = new MenuItem("блюдо1");
            MenuItem dishes2 = new MenuItem("блюдо2");
            MenuItem dishes3 = new MenuItem("блюдо3");
            MenuItem dishes4 = new MenuItem("блюдо4");

            firstDishesMenu.Add(dishes1);
            firstDishesMenu.Add(dishes2);
            firstDishesMenu.Add(dishes3);
            firstDishesMenu.Add(dishes4);

            MenuItem dishes5= new MenuItem("второе блюдо1");
            MenuItem dishes6 = new MenuItem("второе блюдо2");
            MenuItem dishes7 = new MenuItem("второе блюдо3");

            secondDishesMenu.Add(dishes5);
            secondDishesMenu.Add(dishes6);
            secondDishesMenu.Add(dishes7);

            MenuItem dishes8 = new MenuItem("десерт1");
            MenuItem dishes9 = new MenuItem("десерт2");
            desertMenu.Add(dishes8);
            desertMenu.Add(dishes9);

            MenuItem dishes10 = new MenuItem("\tсалат1");
            saladMenu.Add(dishes10);
            secondDishesMenu.Add(saladMenu);

            Menu mainMenu = new Menu("Основное меню:");
            mainMenu.Add(firstDishesMenu);
            mainMenu.Add(secondDishesMenu);
            mainMenu.Add(desertMenu);

            mainMenu.Display();
        }
    }

    public interface IMenuCompanent
    {
        void Display();
    }
    public class MenuItem : IMenuCompanent
    {
        private string _name;
        public MenuItem(string name)
        {
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine("\tБлюдо:" + _name);
        }
    }

    public class Menu : IMenuCompanent
    {
        private string _name;
        private List<IMenuCompanent> _items = new List<IMenuCompanent>();

        public Menu(string name)
        {
            _name = name;
        }

        public void Add(IMenuCompanent companent)
        {
            _items.Add(companent);
        }

        public void Display()
        {
            Console.WriteLine("Меню:" + _name);
            foreach (var companent in _items)
            {
                companent.Display();
            }
        }
    }
}
