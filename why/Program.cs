namespace why
{
    internal class Program
    {
        private static Character player;
        
        static void Main(string[] args)
        {
            GameDataSetting();
            DisplayMyInfo();
            isDead();
            test();
        }


        static void GameDataSetting()
        {
            player = new Character(1,"chad",10,5,100,1500);
        }

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("상태보기");
            Console.ResetColor();
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name} (전사)");
            Console.WriteLine($"공격력 : {player.Atk}");
            Console.WriteLine($"방어력 : {player.Def}");
            Console.WriteLine($"채력 : {player.HP}");
            Console.WriteLine($"Gold : {player.Gold}");
        }




        static void isDead()
        {
            while(player.HP == 0)
            {
                Console.Write("패배했습니다");
            }
            bool isDead = true;
        }

        static void test()
        {
            Console.WriteLine("test");
        }

        public class Character
        {
            public int Level { get; }
            public string Name { get; }         
            public int Atk { get; set; }
            public int Def { get; set; }
            public int HP { get; }
            public int Gold { get; }

            public Character (int level, string name, int atk, int def, int hp, int gold)
            {
                Level = level;
                Name = name;
                Atk = atk;
                Def = def;
                HP = hp;
                this.Gold = gold;
            }

        }
    }
}
