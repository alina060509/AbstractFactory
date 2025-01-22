using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
//порождающий 

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите стиль игры: \n" +
                "1. Fantasy\n" +
                "2.Cyberpunk");
            int choise = int.Parse(Console.ReadLine());
            IGameFactory factory = choise == 1 ? new FantasyFactory() : new CyberpunkFactory();
            var game = new Game(factory);
            game.Start();
        }
    }
    //абстрактный продукт персонажа
    public interface ICharacter
    {
        void Describe();
     
    }
    //абстрактный продукт локации
    public interface ILocation
    {
        void Describe();
    }
    //абстрактный продукт друг
    public interface IFreind
    {
        void Describe();
    }
    //конктретный продукт персонажа
    public class FantasyCharacter : ICharacter
    {
        public void Describe()
        {
            Console.WriteLine("вы играете за ведьму");
        }
    }
    //конктретный продукт локации
    public class FantasyLocation : ILocation
    {
        public void Describe()
        {
            Console.WriteLine("локация: болото");
        }
    }
    //конктретный продукт друга
    public class FantasyFreind : IFreind
    {
        public void Describe()
        {
            Console.WriteLine("помощник: хищная кошка");
        }
    }
    //конктретный продукт персонажа
    public class CyberpunkChar : ICharacter
    {
        public void Describe()
        {
            Console.WriteLine("вы играете за хакера");
        }
    }
    //конктретный продукт локации
    public class CyberpunkLocation : ILocation
    {
        public void Describe()
        {
            Console.WriteLine("локация: мегаполис");
        }
    }
    //конктретный продукт друга
    public class CyberpunkFreind : IFreind
    {
        public void Describe()
        {
            Console.WriteLine("помощник: дружелюбный робот");
        }
    }
    // абстрактная фабрика
    public interface IGameFactory
    {
        ICharacter CreateCharacter();
        ILocation CreateLocation();
        IFreind CreateFreind();

    }
    //конктретная фабрика
    public class FantasyFactory : IGameFactory
    {
        public ICharacter CreateCharacter()
        {
            return new FantasyCharacter();
        }
        public ILocation CreateLocation()
        {
            return new FantasyLocation();
        }
        public IFreind CreateFreind()
        {
            return new FantasyFreind();
        }
    }
    //конктретная фабрика
    public class CyberpunkFactory : IGameFactory
    {
        public ICharacter CreateCharacter()
        {
            return new CyberpunkChar();
        }
        public ILocation CreateLocation()
        {
            return new CyberpunkLocation();
        }
        public IFreind CreateFreind()
        {
            return new CyberpunkFreind();
        }
    }

    //клиент
    public class Game
    {
        private ICharacter _character;
        private ILocation _location;
        private IFreind  _freind;

        public Game(IGameFactory factory)
        {
            _location = factory.CreateLocation();
            _character = factory.CreateCharacter();
            _freind = factory.CreateFreind();
        }
        public void Start()
        {
            Console.WriteLine("добро пожаловать в игру");
            _location.Describe();
            _character.Describe();
            _freind.Describe();
        }
    }
}
