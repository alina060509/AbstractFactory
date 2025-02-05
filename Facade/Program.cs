using System;
using Facade;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var hometheater = new HomeTheaterSystem();
            var ligting = new LightInqSystem();

            var facade = new HomeTheaterFacade(hometheater, ligting);
            facade.WatchMovi();
            Console.WriteLine("просмотр фильма....");
            facade.StopWatch();

        }
    }

    public class HomeTheaterSystem
    {
        public void TurnOnTV()
        {
            Console.WriteLine("Телик включен!");
        }
        public void TurnOffTV()
        {
            Console.WriteLine("Телик выключен!");
        }
        public void SetSound()
        {
            Console.WriteLine("Зук настроен!");
        }
        public void SetStreamIngSiervice()
        {
            Console.WriteLine("Подключение к стриминговому сервису!");
        }
    }
    public class LightInqSystem
    {
        public void OffLights()
        {
            Console.WriteLine("Свет выключен!");
        }
        public void OnLights()
        {
            Console.WriteLine("Свет включен!");
        }
    }
    public class HomeTheaterFacade
    {
        private readonly HomeTheaterSystem _homeTheater;
        private readonly LightInqSystem _lightInqSystem;

        public HomeTheaterFacade(HomeTheaterSystem theater, LightInqSystem lighting)
        {
            _homeTheater = theater;
            _lightInqSystem = lighting;

        }

        public void WatchMovi()
        {
            _homeTheater.TurnOnTV();
            _homeTheater.SetSound();
            _homeTheater.SetStreamIngSiervice();
            _lightInqSystem.OffLights();
        }
        public void StopWatch()
        {
            _lightInqSystem.OnLights();
            _homeTheater.TurnOffTV();
        }
    }

}


//namespace Facade
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }

//    public class Bank
//    {
//        public void AcceptCArd()
//        {
//            Console.WriteLine("принять карту!");
//        }
//        public void WaitPinCodInput()
//        {
//            Console.WriteLine("ожидание ввода пинкода!");
//        }
//        public void SendingPinCpd()
//        {
//            Console.WriteLine("отправка пинкода на сервер!");
//        }
//        public void WaitPinCodReceveing()
//        {
//            Console.WriteLine("ожидание получения пинкода!");
//        }
//        public void ReceveingPinCod()
//        {
//            Console.WriteLine("получение пинкода!");
//        }
//        public void Display()
//        {
//            Console.WriteLine("Показ операций:");
//        }
//        public void Print()
//        {
//            Console.WriteLine("Распечатать чек");
//        }
//    }
//    public class Server
//    {
//        public void CheckCard()
//        {
//            Console.WriteLine("Проверить карту!");
//        }
//        public void ChekPinCod()
//        {
//            Console.WriteLine("проверка пинкода!");
//        }
//        public void ChekPinCod2()
//        {
//            Console.WriteLine("Проверка пинкода!");
//        }
//        }
//    }
//    public class BankFacade
//    {
//        private readonly Bank  _bank;
//        private readonly Server _server;

//        public BankFacade(Bank bank, Server server)
//        {
//        _bank = bank;
//        _server = server;

//        }

//        public void WatchMovi()
//        {
//        _bank.AcceptCArd();
//        _server.CheckCard();
//        _bank.WaitPinCodInput();
//        _server.ChekPinCod();
//        _bank.SendingPinCpd();
//        _server.ChekPinCod2();
//        _bank.WaitPinCodReceveing();
//        _bank.ReceveingPinCod();
//        _bank.Display();





//        }
//        public void StopWatch()
//        {
//            _lightInqSystem.OnLights();
//            _homeTheater.TurnOffTV();
//        }
//    }

//}
