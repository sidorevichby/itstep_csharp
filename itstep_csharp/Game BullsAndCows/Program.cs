using System;

class BullsAndCows
{
    static int Main()
    {
        /*Create game menu*/
        Console.WriteLine("Добро пожаловать в игру \"Быки и коровы\"!\n");
        while (true)
        {
            int item;
            Console.WriteLine("Выбирете нужный пункт:");
            Console.WriteLine("1. Играть с PC");
            Console.WriteLine("2. Играть с другом");
            Console.WriteLine("3. Выход");
            item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch (item)
            {
                case 1:
                    System.Console.Clear();
                    GameWithPC();
                    System.Console.Clear();
                    break;
                case 2:
                    System.Console.Clear();
                    GameWithFriend();
                    System.Console.Clear();
                    break;
                case 3:
                    return 0;
                default:
                    System.Console.Clear();
                    Console.WriteLine("Ошибка! Неверный ввод, попробуйде еще раз.\n");
                    break;
            }
        }
    }

    /*PC game description*/
    static void GameWithPC()
    {
        System.Console.Clear();
        Console.WriteLine("Угадай трехзначное число которое я загадал ;)");
        Random rnd = new Random();
        int magic = rnd.Next(100, 999);
        //Console.WriteLine(magic);
        Game(magic);
        Console.ReadKey();
    }

    /*Description of the game with a friend*/
    static int GameWithFriend()
    {
        int magic;
        Console.WriteLine("Пусть твой друг загадает и введет трехзначное число:");
        while (true)
        {
            magic = Convert.ToInt32(Console.ReadLine());
            if (magic < 1000 && magic > 99)
            {
                System.Console.Clear();
                Console.WriteLine("Угадай трехзначное число которое загадал твой друг :)");
                Game(magic);
                return 0;

            }
            else
            {
                Console.WriteLine("Число {0} не подходит. Необходимо число от 100 до 999. Попробуй еще раз.", magic);
            }
        }
    }

    /*Game mechanics*/
    static int Game(int magic)
    {
        int score = 1;
        int[] magic_arr = new int[3];
        int[] magic_user = new int[3];
        magic_arr[0] = magic / 100;
        magic_arr[1] = magic % 100 / 10;
        magic_arr[2] = magic % 10;

        while (true)
        {
            int userinput;
            int bulls = 0, cows = 0;

            userinput = Convert.ToInt32(Console.ReadLine());
            magic_user[0] = userinput / 100;
            magic_user[1] = userinput % 100 / 10;
            magic_user[2] = userinput % 10;

            for (int i = 0; i < 3; i++)
            {
                if (magic_arr[i] == magic_user[i])
                    bulls++;
            }

            if (bulls == 3)
            {
                Console.WriteLine("Победа! Загаданное число {0}", magic);
                Console.WriteLine("Колличество попыток: {0}", score);
                Console.ReadKey();
                return 0;
            }
            else
            {
                Console.WriteLine("Неверно, это не {0}, попробуй еще раз :)", userinput);
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (magic_arr[i] == magic_user[j])
                            cows++;
                    }
                }

                cows -= bulls;
                Console.WriteLine("У тебя в числе коров: {0}, быков:{1}", cows, bulls);
                bulls = 0; cows = 0;
                score++;
            }
        }
    }
}