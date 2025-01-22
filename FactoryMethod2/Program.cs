using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
//порождающий 
namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите персонажа: 1- эльф, 2-орк");
            int choice = int.Parse(Console.ReadLine());
            Create create;

            switch (choice)
            {
                case 1:
                    create = new ElfCreate();
                    break;
                case 2:
                    create = new OrkCreate();
                    break;
                default:
                    Console.WriteLine("некоректный выбор(");
                    return;
            }
           create.Creat();
        }
    }
    }
    public abstract class Enemy
    {
        public abstract void Create();
    }
    public class Elf : Enemy
    {
        public override void Create(){

            Console.WriteLine("ваш малепнький эльф создается");
        }
    }
    public class Ork : Enemy
    {
        public override void Create()
        {

            Console.WriteLine("ваш злой орк создается");
        }
    }
    public abstract class Create
    {
        //фабричный метод
        public abstract Enemy CreateEnemy();
        public void Creat()
        {
            var enemy = CreateEnemy();
            enemy.Create();
            Console.WriteLine("перс создан!");
        }
    }
    public class ElfCreate : Create
    {
        public override Enemy CreateEnemy()
        {
            return new Elf();
        }
    }
    public class OrkCreate : Create
    {
        public override Ork CreateEnemy()
        {
            return new Ork();
        }
    }


