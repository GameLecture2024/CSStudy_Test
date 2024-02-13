using Class03;

class Program
{
    static bool exitGame = false;
    static int maxAttempts = 10;
    static int targetNumber;
    // 숫자 맞추기 게임

    static void Main(string[] args)
	{
        //#region 숫자 맞추기
        //// 게임 로딩 및 타이틀 구현
        //Loading();

        //// 게임 로직 구현 해야할 기능 : 게임 승리, 게임 오버, 게임 재시작
        //GameLogic();
        //#endregion

        #region 클래스 버전
        GuessNumberClass guessingGame = new GuessNumberClass(1, 100, 10);
        guessingGame.GameStart();
        #endregion
    }

    private static void GameLogic()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("********** Mini-Game Menu **********");
            Console.WriteLine("*                                  *");
            Console.WriteLine("*  1. Start Game                   *");
            Console.WriteLine("*  2. Exit Game                    *");
            Console.WriteLine("*                                  *");
            Console.WriteLine("************************************");

            Console.Write("Select an option (1 or 2): ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    #region 게임 로직 구현
                    Console.Clear();
                    Console.WriteLine("Starting the game...");

                    Console.WriteLine("Exiting the mini-game. Thanks for playing!");

                    // 숫자의 최소, 최대 범위 설정
                    int minValue = 1;
                    int maxValue = 100;

                    // 정답을 랜덤으로 설정
                    Random random = new Random();
                    targetNumber = random.Next(minValue, maxValue + 1);

                    // 남은 정답 횟수 초기화
                    int attemptsLeft = maxAttempts;

                    // 로직 반복 : 남은 횟수가 0이 되거나 정답을 맞출 때 까지 반복한다.
                    while (attemptsLeft > 0)
                    {
                        Console.Write($"Guess the number ({minValue}-{maxValue}): ");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out int userGuess))
                        {
                            if (userGuess == targetNumber)
                            {
                                GameClear();
                                break;
                            }
                            else if (userGuess < targetNumber)
                            {
                                Console.WriteLine("Too low. Try again!");
                            }
                            else
                            {
                                Console.WriteLine("Too high. Try again!");
                            }

                            attemptsLeft--;
                            Console.WriteLine($"Attempts left: {attemptsLeft}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number.");
                        }
                    }
                 
                    if (attemptsLeft == 0)
                    {
                        GameOver();
                    }

                    Console.WriteLine("Thanks for playing!");
                    #endregion

                    break;

                case "2":
                    exitGame = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter 1 or 2.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }

        }
        // 게임 재시작 : exitGame이 true가 될 때 까지 무한 반복한다. 
        while (!exitGame);
    }

    private static void GameOver()
    {
        Console.WriteLine($"Sorry, you've run out of attempts. The correct number was {targetNumber}.");

        Console.ReadKey();
    }

    private static void GameClear()
    {
        Console.WriteLine("Congratulations! You guessed the correct number!");
        Console.ReadKey();
    }

    static void Loading()
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
        exitGame = false;

    }

}