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

        }


        static void GameDataSetting()
        {
            player = new Character(1, "chad", 10, 5, 100, 1500);

            minion = new Monster1(15);

            cannon = new Monster2(25);

            worm = new Monster3(10);

        }

        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 전투 시작");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요.: ");

           
            int input = CheckValidInput(1, 2);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    BattleStart();
                    break;

            }
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
            Console.WriteLine();
            Console.WriteLine("1. 돌아가기");
            Console.WriteLine("2. 전투시작");
            Console.WriteLine();
            Console.Write("원하는 행동을 입력하세요: ");

            int input = CheckValidInput(1,2);
            switch (input)
            {
                case 1:
                    DisplayGameIntro();
                    break;

                case 2:
                    BattleStart();
                    break;

            }
        }


        static void BattleStart()
        {
            Console.Clear();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Battle!!");
            Console.ResetColor();
            Console.WriteLine($"Lv.2 미니언 HP{minion.hp}");
            Console.WriteLine($"Lv.5 대포미니언 HP{cannon.hp}");
            Console.WriteLine($"Lv.3 공허충 HP{worm.hp}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[내정보]");
            Console.WriteLine($"Lv.{player.Level} {player.Name} (전사)");
            Console.WriteLine($"HP 100/{player.HP}");
            Console.WriteLine();
            Console.WriteLine("1. 미니언 공격");
            Console.WriteLine("2. 대포미니언 공격");
            Console.WriteLine("3. 공허충 공격");
            Console.WriteLine();
            Console.Write("원하시는 행동을 입력해주세요: ");

            int input = CheckValidInput(1, 3);
            switch (input)
            {
                case 1:
                    DisplayGameIntro();
                    break;

                case 2:
                    BattleStart();
                    break;
                
                case 3:
                    isDead();
                    break;

            }
        }


        static void isDead()
        {
            while (player.HP == 0)
            {
                Console.Write("패배했습니다");
            }
            bool isDead = true;
        }

       

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }

    }
    public class Character
    {
        public int Level { get; }
        public string Name { get; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int HP { get; }
        public int Gold { get; }

        public Character(int level, string name, int atk, int def, int hp, int gold)
        {
            Level = level;
            Name = name;
            Atk = atk;
            Def = def;
            HP = hp;
            Gold = gold;
        }
    
    }

    public class Monster1
    {
        public int Hp { get; }

        public Monster1(int hp)
        {
            Hp = hp;
        }
    }

    public class Monster2
    {
        public int Hp { get; }

        public Monster2(int hp)
        {
            Hp = hp;
        }
    }

    public class Monster3
    {
        public int Hp { get; }

        public Monster3(int hp)
        {
            Hp = hp;
        }
    }




}
