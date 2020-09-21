using System;

class BullsAndCows
{
    static void Main()
    {
        bool key = true; //ключ выхода из игры

        /*Организовываем меню игры*/
        while (key)
        {
            int item;
            Console.WriteLine("Добро пожаловать в игру \"Быки и коровы\"!");
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
                    System.Console.Clear();
                    key = false;
                    break;

                default:
                    Console.WriteLine("Ошибка! Неверный ввод, попробуйде еще раз.");

                    break;
            }
        }
        /*************************************************/

    }

    /*************************************************/
    /*Описаны особенности запуска для игры с ПК (получение рандомного числа в заданном диапазоне)+запуск механники игры*/
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

    /*************************************************/
    /*Описаны особенности запуска для игры с другом (ввод числа другом, проверка этого числа)+запуск механники игры*/
    static void GameWithFriend()
    {
        int magic;
        bool suitablenumber = true;
        Console.WriteLine("Пусть твой друг загадает и введет трехзначное число:");
        while (suitablenumber)
        {
            magic = Convert.ToInt32(Console.ReadLine());
            if (magic < 1000 && magic > 99)
            {
                System.Console.Clear();
                Console.WriteLine("Угадай трехзначное число которое загадал твой друг :)");
                Game(magic);
                suitablenumber = false;

            }
            else
            { Console.WriteLine("Число {0} не подходит. Необходимо число от 100 до 999. Попробуй еще раз.", magic); }
        }
        Console.ReadKey();
    }

    /*************************************************/
    /*Функция игровой механники. Подходит как для игры с ПК так и с другом*/
    static void Game(int magic)
    {
        int ma, mb, mc, ua, ub, uc, score=1;
        ma = magic / 100;
        mb = magic % 100 / 10;
        mc = magic % 10;

        bool gameprogress = true;
        while (gameprogress)
        {
            int userinput;
            userinput = Convert.ToInt32(Console.ReadLine());
            ua = userinput / 100;
            ub = userinput % 100 / 10;
            uc = userinput % 10;
            int bulls = 0, cows = 0;
            if (ma == ua && mb == ub && mc == uc)
            {
                Console.WriteLine("Победа! Загаданное число {0}", magic);
                Console.WriteLine("Колличество попыток: {0}", score);
                gameprogress = false;
            }
            else
            {
                Console.WriteLine("Неверно, это не {0}, попробуй еще раз :)", userinput);

                int[] magic_arr = new int[] { ma, mb, mc };
                for (int i = 0; i < 3; i++)
                {
                    if (magic_arr[i] == ua)
                        cows++;
                }
                for (int i = 0; i < 3; i++)
                {
                    if (magic_arr[i] == ub)
                        cows++;
                }
                for (int i = 0; i < 3; i++)
                {
                    if (magic_arr[i] == uc)
                        cows++;
                }

                if (magic_arr[0] == ua)
                    bulls++;
                if (magic_arr[1] == ub)
                    bulls++;
                if (magic_arr[2] == uc)
                    bulls++;
                cows -= bulls;
                Console.WriteLine("У тебя в числе коров: {0}, быков:{1}", cows, bulls);
                bulls = 0; cows = 0;
                score++;
            }
        }
    }
    /*************************************************/

}
