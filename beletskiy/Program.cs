using Newtonsoft.Json;

namespace beletskiy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozitsia = 2;
            string password = "";
            string nick = "";
            int pravilno = 0;
            ConsoleKeyInfo klavisha = Console.ReadKey();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("МАГАЗИН'");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("  " + "логин: ");
            Console.WriteLine("  " + "пароль: ");
            Console.WriteLine("  " + "войти");
            Console.WriteLine("  " + "ввести заново");
            while (pravilno != 1)
            {

                if (klavisha.Key == ConsoleKey.Enter & pozitsia == 2)
                {
                    nick = username();
                }
                else if (klavisha.Key == ConsoleKey.Enter & pozitsia == 3)
                {
                    password = parol();
                }
                else if (klavisha.Key == ConsoleKey.Enter & pozitsia == 5)
                {
                    Console.Clear();
                    zagolovok();
                    password = "";
                    nick = "";
                }
                if (klavisha.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, pozitsia);
                    pozitsia = goup_login(pozitsia);
                }
                if (klavisha.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, pozitsia);
                    pozitsia = godown_login(pozitsia);
                }
                if (pozitsia == 4 && klavisha.Key == ConsoleKey.Enter)
                    pravilno = proverka(nick, password);
                Console.SetCursorPosition(0, pozitsia);
                Console.WriteLine("->");
                klavisha = Console.ReadKey();
            }
        }
        static int goup_login(int pozitsia)
        {
            Console.WriteLine("  ");
            pozitsia--;
            if (pozitsia < 2)
                pozitsia = 2;
            return pozitsia;
        }
        static int godown_login(int pozitsia)
        {
            Console.WriteLine("  ");
            pozitsia++;
            if (pozitsia > 5)
                pozitsia = 5;
            return pozitsia;
        }

        static string parol()
        {
            ConsoleKeyInfo klavisha = Console.ReadKey();
            int stop = 0;
            int pozitsia = 10;
            string password = "";
            while (true)
            {
                if (klavisha.Key == ConsoleKey.Escape)
                {
                    break;
                }
                pozitsia++;
                password += klavisha.KeyChar;
                Console.SetCursorPosition(pozitsia, 3);
                klavisha = Console.ReadKey();
                Console.SetCursorPosition(pozitsia - 1, 3);
                Console.Write("*");
            }
            return password;
        }
        static string username()
        {
            ConsoleKeyInfo klavisha = Console.ReadKey();
            int pozitsia = 9;
            int stop = 0;
            string nick = "";
            while (true)
            {
                if (klavisha.Key == ConsoleKey.Escape)
                {
                    break;
                }
                pozitsia++;
                nick += klavisha.KeyChar;
                Console.SetCursorPosition(pozitsia, 2);
                klavisha = Console.ReadKey();
            }
            return nick;
        }
        static int proverka(string nick, string parol)
        {
            int gotovo = 0;
            foreach (var a in Class2.Human)
            {
                if (a.nick == nick && a.parol == parol)
                {
                    gotovo = 1;
                    Console.SetCursorPosition(6, 0);
                    Console.WriteLine("вы вошли");
                    break;
                }
            }
            nick = "";
            parol = "";
            return gotovo;
        }
        static void zagolovok()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("МАГАЗИН'");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("  " + "логин: ");
            Console.WriteLine("  " + "пароль: ");
            Console.WriteLine("  " + "войти");
            Console.WriteLine("  " + "ввести заново");

        }
    }
}