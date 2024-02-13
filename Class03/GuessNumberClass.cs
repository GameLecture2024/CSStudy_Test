using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    class GuessNumberClass
    {
        private int minNumber;
        private int maxNumber;
        private int targetNumber;
        private int maxAttempts;
        private int remainCount;

        public int MinNumber { get => minNumber;}
        public int MaxNumber { get => maxNumber;}
        public int MaxAttempts { get => maxAttempts; }

        public int TargetNumber { get => targetNumber;} 


       public GuessNumberClass(int minNumber, int maxNumber, int maxAttempts)
        {
            this.minNumber = minNumber;
            this.maxNumber = maxNumber;
            this.maxAttempts = maxAttempts;
            remainCount = maxAttempts;

            Random random = new Random();
            targetNumber = random.Next(minNumber, maxNumber + 1);
        }

        public void GameStart()
        {
            Loading();
            ShowMenu();
        }

        private void Loading()
        {
            Console.WriteLine("Welcome to the Guess the Number game!");

            Console.WriteLine("Press Any Key");
            Console.ReadKey();

            string title = "";

            for (int i = 0; i < 47; i++)
            {
                title += "*";
            }
            title += "\n";
            title += "**      Guess the Number Game Loading      **\n";
            for (int i = 0; i < 47; i++)
            {
                title += "*";
            }

            // 타이틀 애니메이션 예시
            int frames = 48;

            for (int i = 0; i < frames; i++)
            {
                Console.Clear();

                title = title.Substring(1);

                Console.WriteLine(title);

                Thread.Sleep(50);
            }

            Console.Title = "Mini-Game Window";
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("********** Mini-Game Menu **********");
            Console.WriteLine("*                                  *");
            Console.WriteLine("*  1. Start Game                   *");
            Console.WriteLine("*  2. Exit Game                    *");
            Console.WriteLine("*                                  *");
            Console.WriteLine("************************************");

            Console.Write("게임 진행을 위하여 1 또는 2를 입력해주세요. (1 or 2) :");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Play();
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("입력을 잘못하였습니다. 숫자 1 또는 2를 입력해주세요");
                    ShowMenu();
                    break;
            }
        }

        public void Play()
        {
            Console.WriteLine("숫자 맞추기 게임 시작!");

            while (remainCount > 0)
            {
                Console.WriteLine($"Guess the number : {MinNumber} - {MaxNumber}");
                string input = Console.ReadLine();

                // TryParse를 사용하는 이유?
                if (int.TryParse(input, out int userGuess)) // 문자 변환 성공시 true : false
                {
                    GuessTargetValue(userGuess);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                }
            }

            GameOver();
            
        }

        private void GameOver()
        {
            Console.WriteLine("남은 횟수를 모두 사용하여 게임에서 패배하였습니다.");
            Console.WriteLine($"정답은 {TargetNumber} 이였습니다.");

            ShowMenu();
        }

        private void GuessTargetValue(int userGuess)
        {
            if (userGuess == TargetNumber)
            {
                Console.WriteLine($"축하합니다!. 남은 시도 횟수는 {remainCount - 1}번 입니다.");
                Console.ReadKey();
                ShowMenu();
            }
            else if (userGuess < TargetNumber)
            {
                Console.WriteLine("입력한 값이 정답보다 작습니다.");
            }
            else
            {
                Console.WriteLine("입력한 값이 정답보다 큽니다.");
            }

            remainCount--;
            Console.WriteLine($"남은 시도 횟수는 {remainCount} 입니다.");
        }
    }
}
