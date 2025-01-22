using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
//порождающий 

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterBuilder warriorBuilder = new WarriorBuilder();
            CharacterDirector director = new CharacterDirector(warriorBuilder);
            director.BuildCharacter();
            Character warrior = director.GetCharacter();
            Console.WriteLine(warrior);

            Console.WriteLine();
            director = new CharacterDirector(new FairyBuilder());
            director.BuildCharacter();
            Character fairy = director.GetCharacter();
            Console.WriteLine(fairy);
        }
    }
    //обЪект
    public class Character
    {
        public string Type { get; set; }
        public string Weapon { get; set; }
        public int Health{ get; set; }
        public int Armor { get; set; }
        public int AttackPower { get; set; }
        public override string ToString()
        {
            return $"Type: {Type}\n" +
                $"Weapon: {Weapon}\n" +
                $"Health: {Health}\n" +
                $"Armor: {Armor}\n" +
                $"AttackPower: {AttackPower}";
        }
    }
    //абстрактный построитель
    public abstract class CharacterBuilder
    {
        protected Character character = new Character();
        public abstract void SetType();
        public abstract void SetWeapon();
        public abstract void SetAttributes();

        public Character GetResult()
        {
            return character;
        }
    }
        //конкретнвй построитель
        public class WarriorBuilder : CharacterBuilder
        {
            public override void SetType()
            {
                character.Type = "воин";

            }
            public override void SetWeapon()
            {
                character.Weapon = "кинжал";

            }
            public override void SetAttributes()
            {
                character.Health = 100;
                character.Armor = 100;
                character.Armor = 50;

            }
        }
        //конкретный построитель2
        public class FairyBuilder : CharacterBuilder
        {
            public override void SetType()
            {
                character.Type = "Фея";

            }
            public override void SetWeapon()
            {
                character.Weapon = "пыльца";

            }
            public override void SetAttributes()
            {
                character.Health = 50;
                character.Armor = 70;
                character.AttackPower = 100;

            }
        }
        //директор
        public class CharacterDirector
        {
            private CharacterBuilder builder;
            public CharacterDirector(CharacterBuilder builder)
            {
                this.builder = builder;
            }
            public void BuildCharacter()
            {
                builder.SetType();
                builder.SetWeapon();
                builder.SetAttributes();
            }
            public Character GetCharacter()
            {
                return builder.GetResult();
            }

        }
    }

