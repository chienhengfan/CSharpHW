using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp02
{
    public class Monster
    {
        public int ID; private float _maxHP { get; } = 100f; public float MaxHP() { return _maxHP; }
        public float HP; public float power { get; private set; } = 21.2f; public int state = 0; // state = 0 ; HP Full // state = 1 ; HP Not Full // state = 2 ; Dead private int _EXP { get; } = 5; public int EXP() { return _EXP; } public bool IsItemFall = false;

    }

    public class Player
    {
        private float _maxHP { get; } = 100f;
        public float MaxHP() { return _maxHP; }
        public float HP;
        public float power { get; private set; } = 25.3f;
        public int EXP = 0;

    }

    public class Bag
    {
        private int[] _spaceBag { get; } = new int[10];
        public int[] SpaceBag() { return _spaceBag; }
    }

    //後面要設計不同物品
    public class Item
    {
        public float power { get; private set; } = 52.3f;
        public int quantity = 1;
        public class Bomb : Item
        {

        }
        public class Bomb2 : Item
        {

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.HP = player.MaxHP();
            Item bomb = new Item();
            List<Item> items = new List<Item>(10);

            bool IsExit = false;

            Console.WriteLine("Please set Monster Number: \n");
            int numberMonster = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You set {numberMonster} monsters.");

            List<Monster> monsterList = new List<Monster>();

            for (int pointer = 0; pointer < numberMonster; pointer++)
            {
                Monster monster = new Monster();
                monster.ID = pointer + 1;
                monster.HP = monster.MaxHP();
                monsterList.Add(monster);
            }

            while (IsExit == false)
            {
                Console.WriteLine("Choose your action \n " +
                    "      1:show player status\n " +
                    "      2:show Monster status\n" +
                    "      3:Attack monster\n" +
                    "      4:Exit game");

                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.WriteLine($"player status:\nHP : {player.HP}\nPower : {player.power}\n");
                        break;

                    case 2:
                        Console.WriteLine("Choose monster you want to check: \n");
                        int monsterID = Convert.ToInt32(Console.ReadLine());
                        foreach (Monster monster in monsterList)
                        {
                            if (monster.ID == monsterID)
                            {
                                Console.WriteLine($"monster{monster.ID} status:\nHP : {monster.HP}\nPower : {monster.power}\n");
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Choose monster you want to check: \n");
                        int monsterAttackID = Convert.ToInt32(Console.ReadLine());
                        foreach (Monster monster in monsterList)
                        {
                            if (monster.ID == monsterAttackID)
                            {
                                Console.WriteLine("Choose which style to want to attack?\n1: direct attack\n 2: Use Bomb");
                                int styleAttack = Convert.ToInt32(Console.ReadLine());
                                if (styleAttack == 1)
                                {
                                    monster.HP -= player.power;
                                }
                                else if (styleAttack == 2)
                                {
                                    for (int i = 0; i < items.Count; i++)
                                    {
                                        monster.HP -= bomb.power;
                                    }
                                }

                                float maxHP = monster.MaxHP();
                                if (monster.HP == maxHP)
                                {
                                    monster.state = 0;
                                }
                                else if (monster.HP < maxHP && monster.HP > 0)
                                {
                                    monster.state = 1;
                                }
                                else
                                {
                                    monster.state = 2;
                                    monster.HP = 0;
                                }
                            }
                        }
                        break;




                }


            }
        }
    }