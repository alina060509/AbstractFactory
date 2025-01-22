using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
//порождающий 
namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter hero1 = new GameCharacter("Invoker","mar",1,"сферы");
            Console.WriteLine(hero1);
            GameCharacter hero2 = hero1.Clone();
            Console.WriteLine(hero2);
            hero2.Level = 5;
            Console.WriteLine("после изменений:");
            Console.WriteLine(hero1);
            Console.WriteLine(hero2);
        }
    }
    public interface IClonePrototype<T>
    {
        T Clone();
    }
    public class GameCharacter : IClonePrototype<GameCharacter>
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public string Weapon { get; set; }

        public GameCharacter(string name,
                             string heroClass,
                             int level,
                             string weapon)
        {
            Name = name;
            Class = heroClass;
            Level = level;
            Weapon = weapon;
        }
        public GameCharacter Clone()
        {
            return (GameCharacter)MemberwiseClone(); //поверхностное клонирование

        }

        public override string ToString()
        {
            return $"имя:{Name}, класс:{Class}, уровень:{Level}, оружие:{Weapon}";
        }
    }
}
