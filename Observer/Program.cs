using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Newspublisher Buster = new Newspublisher();
            User user1 = new User("Evelon");
            User user2 = new User("Gensyha");
            User user3 = new User("Artem Mureev");
            User user4= new User("Artem Mureev");

            User user5 = new User("Amir");
            User user6 = new User("Alino4ka");
            User user7 = new User("MAksimka");
            User user8 = new User("princess");
            User user9 = new User("6666");


            Buster.Subscribe(user3);
            Buster.Subscribe(user2);
            Buster.Subscribe(user4);
            Buster.Subscribe(user5); 
            Buster.Subscribe(user6);
            Buster.Subscribe(user7);
            Buster.Subscribe(user8);
            Buster.Subscribe(user9);
            Buster.NotIfyObserver("Стрим начался! Муреев артем - заходи) Ссылка на твич");
            Buster.UnSubscribe(user2);
            Buster.NotIfyObserver("новое видео на канале");
        }
    }
    //интерфейс издателя
    public interface IObserver
    {
        void Update(string message);
    }
    //интерфейс подписчика
    public interface IFollower
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void NotIfyObserver(string message);
    }
    //реализация издателя
    public class Newspublisher : IFollower
    {
        private List<IObserver> followers = new List<IObserver>();
        public void Subscribe(IObserver follower)
        {
            followers.Add(follower);
            Console.WriteLine("ПОДПИСЧИК ДОБАВЛЕЕЕЕЕЕН");
        }
        public void UnSubscribe(IObserver follower)
        {
            followers.Remove(follower);
            Console.WriteLine("Подписчик удален.");
        }
        public void NotIfyObserver(string message)
        {
            foreach(var follower in followers)
            {
                follower.Update(message);
            }
        }
    }

    //реализация подписчика
    public class User : IObserver
    {
        private string _name;
        public User(string name)
        {
            _name = name;
        }
        public void Update(string message)
        {
            Console.WriteLine($"{_name} получил уведомление: {message}");
        }
    }
}
