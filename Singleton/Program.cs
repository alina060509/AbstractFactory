using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
//порождающий 

//namespace Singleton
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Singleton singleton1 = Singleton.GetInstance();
//            Singleton singleton2 = Singleton.GetInstance();

    //            singleton1.Connection();

    //            Console.WriteLine(singleton1.status);
    //            singleton1.status = "Подключение к БД";
    //            Console.WriteLine(singleton2.status);
    //            singleton2.status = "OK";
    //            Console.WriteLine(singleton1.status);
    //        }

    //    }

    //    public class Singleton
    //    {
    //        private static Singleton _instance;
    //        public string status;
    //        private Singleton()
    //        {
    //            Console.WriteLine();

    //        }

    //        public static Singleton GetInstance()
    //        {
    //            if (_instance == null)
    //            {
    //                _instance = new Singleton();
    //            }

    //            return _instance;
    //        }
    //        public void Connection()
    //        {
    //            Console.WriteLine("Подключение к БД....");
    //        }
    //    }

    //}


    //namespace Singleton
    //{
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Game game1 = Game.GetInstance();
    //           Game game2 =Game.GetInstance();

    //            game1.Connection();

    //            Console.WriteLine(game1.status);
    //            game2.status = "в игре";
    //            Console.WriteLine(game2.status);
    //            game2.status = "OK";
    //            Console.WriteLine(game1.status);
    //        }

    //    }

    //    public class Game
    //    {
    //        private static Game _instance;
    //        public string status;
    //        private Game()
    //        {
    //            Console.WriteLine();

    //        }

    //        public static Game GetInstance()
    //        {
    //            if (_instance == null)
    //            {
    //                _instance = new Game();
    //            }

    //            return _instance;
    //        }
    //        public void Connection()
    //        {
    //            Console.WriteLine("в игре");
    //        }
    //    }

    //}


namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetLogger();
            Logger logger2 = Logger.GetLogger();
            logger1.Log("ошибка1");
            logger1.Log("ошибка2");
            Logger.GetLogger();
        }

    }
    public class Logger
    {
        private static Logger _logger;
        private static List<string> messages = new List<string>();
        private Logger()
        {
            Console.WriteLine("объект создан");

        }

        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }
        public void Log(string message)
        {
            messages.Add(message);
        }
        public static void GetLogs()
        {
            foreach (var item in messages)
            {
                Console.WriteLine(item);
            }
        }
    }

}