using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tree> trees = new List<Tree>();
            for(int i = 0; i < 3; i++)
            {
                //создаеми шаблон дуба
                var TreeType = TreeFactory.GetTreeType("Дуб", "зеленый", "грубая кора");
                //шаблон березы
                var TreeType2 = TreeFactory.GetTreeType("Береза", "белый", "мягкая кора");
                //добавляем дуб на карту игровую
                trees.Add(new Tree(i * 10, i * 20, TreeType));
                //добавляем березу на карту игровую
                trees.Add(new Tree(i * 10, i * 20, TreeType2));
            }
            foreach(var tree in trees)
            {
                tree.Display();
            }
        }
    }
    //общий обьект-легковес

    public class TreeType
    {
        public string Name { get; }
        public string Color { get; }
        public string Texture { get; }

        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }
        public void Display(int x, int y)
        {
            Console.WriteLine($"Дерево с типом {Name} с цветом {Color} и текстурой {Texture} находитя на координатах({x},{y})");
        }
    }
    public class Tree
    {
        private readonly int _x;
        private readonly int _y;
        private readonly TreeType _type;

        public Tree(int x, int y, TreeType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }
        public void Display()
        {
            _type.Display(_x, _y);

        }
    }
    public class TreeFactory { 
        private static readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();
        public static TreeType GetTreeType(string name, string color, string texture)
        {
            string key = $"{name}_{color}_{texture}";
            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color, texture);
                Console.WriteLine($"Создан новый ключ: {key}"); 
            }
            return _treeTypes[key];
        }
    }

}
