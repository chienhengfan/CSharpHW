namespace CSharp02
{

    public class Monster
    {
        public int monsterID;
        private float maxHP { get; set; }
        private float currentHP { get; set; }
        private float state { get; set; }
        //state = 0 >> currentHP = maxHP 
        //state = 1 >> currentHP < maxHP 
        //state = 2 >> currentHP <= 0

        private int monsterEXP;
        private bool IsFallBomb = false;
    }


    public class Player
    {
        private int strength { get; set; }
        private int playerEXP { get; set; }

        public int[] bag = new int[10];
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            int numberMonster = Convert.ToInt32(Console.ReadLine());

            
            }
            
        }
    }
}