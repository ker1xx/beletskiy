using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beletskiy
{
    internal class Class3 : ICrud
    {
        private static ConsoleKeyInfo klavisha;
        private static int pozitsia = 3;
        public void admin()
        {
            while (klavisha.Key != ConsoleKey.Escape)
            {
                Class2.Human = Class2.MyDeserialize<List<Class1>>("Human.json");
                Console.Clear();
                zagolovok();
                Console.SetCursorPosition(0, 6);
                read();
                if (klavisha.Key == ConsoleKey.UpArrow)
                    goup();
                if (klavisha.Key == ConsoleKey.DownArrow)
                    godown();
                if (klavisha.Key == ConsoleKey.F1)
                    create();
                else if (klavisha.Key == ConsoleKey.F3)
                    update();
                else if (klavisha.Key == ConsoleKey.Delete)
                    delete();
                else if (klavisha.Key == ConsoleKey.F5)
                    search();
                else if (klavisha.Key == ConsoleKey.Escape)
                    return;
                Console.WriteLine("->");
                klavisha = Console.ReadKey();
            }
        }
        public void create()
        {
            try
            {
                pozitsia = 3;
                string parol = "";
                string nick = "";
                int id = 0;
                string role = "";
                int newname_length = 0;
                int newpassword_length = 0;
                int newid_length = 0;
                int newjobtitle_length = 0;
                Console.Clear();
                Class1 newperson = new Class1(id, role, nick, parol);
                head();
                Console.SetCursorPosition(2, 2);
                Console.WriteLine("Имя");
                Console.WriteLine("Пароль");
                Console.WriteLine("Роль");
                Console.WriteLine("ID");
                Console.SetCursorPosition(70, 10);
                Console.WriteLine("Для сохранения нажмите S");
                Console.SetCursorPosition(3, 0);
                while (klavisha.Key != ConsoleKey.S)
                {
                    Console.Write("  ");
                    if (klavisha.Key == ConsoleKey.UpArrow)
                        goup();
                    if (klavisha.Key == ConsoleKey.DownArrow)
                        godown();
                    Console.Write("->");
                    if (pozitsia == 3)
                        nick = Console.ReadLine();
                    else if (pozitsia == 4d)
                        parol = Console.ReadLine();
                    else if (pozitsia == 5)
                        role = Console.ReadLine();
                    else if (pozitsia == 6)
                        id = Convert.ToInt32(Console.ReadLine());
                    klavisha = Console.ReadKey();
                }
                Class2.Human.Add(newperson);
                Class2.MySerialize(Class2.Human, "Human.json");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Видимо, вы допустили ошибку. Попробуйте заново");
            }

        }

        public void delete()
        {
            Class2.Human.Remove(Class2.Human[pozitsia - 4]);
            Console.Clear();
            Class2.MySerialize(Class2.Human, "Human.json");
        }

        public void read()
        {
            pozitsia = 3;
            foreach (var a in Class2.Human)
            {
                Console.SetCursorPosition(2, pozitsia);
                Console.WriteLine(a.nick);
                Console.SetCursorPosition(25, pozitsia);
                Console.WriteLine(a.parol);
                Console.SetCursorPosition(45, pozitsia);
                Console.WriteLine(a.role);
                Console.SetCursorPosition(60, pozitsia);
                Console.WriteLine(a.id);
                pozitsia++;
            }
            pozitsia = 3;
            Console.SetCursorPosition(3, 0);
        }

        public void update()
        {
            Console.Clear();
            zagolovok();;
            Console.WriteLine("  " + Class2.Human[pozitsia-3].nick);
            Console.WriteLine("  " + Class2.Human[pozitsia - 3].parol);
            Console.WriteLine("  " + Class2.Human[pozitsia - 3].role);
            Console.WriteLine("  " + Class2.Human[pozitsia-3].id);
            pozitsia++;
            string change = "";
            int change_pos = 0;
            while (pozitsia != 6)
            {
                if (pozitsia == 2)
                {
                    try
                    {
                        while (klavisha.Key != ConsoleKey.Enter)
                        {
                            change = Class2.Human[pozitsia - 3].nick;
                            Console.SetCursorPosition(Class2.Human[pozitsia - 3].nick.Length + 2, 2);
                            klavisha = Console.ReadKey();
                            if (klavisha.Key == ConsoleKey.Backspace) 
                            change.Remove(change.Length, 1);
                            else
                                change += klavisha.KeyChar;
                            Class2.Human[pozitsia - 3].nick = change;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else if (pozitsia == 3)
                {
                    try
                    {
                        while (klavisha.Key != ConsoleKey.Enter)
                        {
                            change = Class2.Human[pozitsia - 3].parol;
                            Console.SetCursorPosition(Class2.Human[pozitsia - 3].parol.Length + 2, 2);
                            klavisha = Console.ReadKey();
                            if (klavisha.Key == ConsoleKey.Backspace)
                                change.Remove(change.Length, 1);
                            else
                                change += klavisha.KeyChar;
                            Class2.Human[pozitsia - 3].parol = change;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else if (pozitsia == 4)
                {
                    try
                    {
                        while (klavisha.Key != ConsoleKey.Enter)
                        {
                            change = Class2.Human[pozitsia - 3].role;
                            Console.SetCursorPosition(Class2.Human[pozitsia - 3].role.Length + 2, 2);
                            klavisha = Console.ReadKey();
                            if (klavisha.Key == ConsoleKey.Backspace) 
                            change.Remove(change.Length, 1);
                            else
                                change += klavisha.KeyChar;
                            Class2.Human[pozitsia - 3].role = change;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else if (pozitsia == 5)
                {
                    try
                    {
                        while (klavisha.Key != ConsoleKey.Enter)
                        {
                            change = Class2.Human[pozitsia - 3].id.ToString();
                            Console.SetCursorPosition(Class2.Human[pozitsia - 3].id + 2, 2);
                            klavisha = Console.ReadKey();
                            if (klavisha.Key == ConsoleKey.Backspace) 
                            change.Remove(change.Length, 1);
                            else
                                change += klavisha.KeyChar;
                            Class2.Human[pozitsia - 3].id = Convert.ToInt32(change);
                        };
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            Class2.MySerialize(Class2.Human, "Human.json");
        }
        private void goup()
        {
            Console.WriteLine("  ");
            pozitsia--;
            if (pozitsia < 3)
                pozitsia = 3;
        }
        private void godown()
        {
            Console.WriteLine("  ");
            pozitsia++;
            if (pozitsia > Class2.Human.Count() - 1)
                pozitsia = Class2.Human.Count() - 1;
        }
        private void search()
        {
            string poisk = "";
            pozitsia = 2;
            Console.Clear();
            Console.WriteLine("Чтобы начать поиск, выберите атрибут:");
            Console.WriteLine("  ID");
            Console.WriteLine("  Роль");
            Console.WriteLine("  Имя");
            Console.WriteLine("Для выхода нажмите Escape");
            Console.SetCursorPosition(1, 0);
            while (klavisha.Key != ConsoleKey.Enter)
            {
                klavisha = Console.ReadKey();
                if (klavisha.Key == ConsoleKey.UpArrow)
                    goup();
                if (klavisha.Key == ConsoleKey.DownArrow)
                    godown();
            }
            Console.SetCursorPosition(5, 0);
            Console.WriteLine("Поиск: ");
            Console.SetCursorPosition(5, 0);
            poisk = Console.ReadLine();
            foreach (var a in Class2.Human)
            {
                Console.Clear();
                if ((poisk == a.id.ToString()) || (poisk == a.role) || (poisk == a.nick))
                {
                    zagolovok();
                    Console.SetCursorPosition(2, pozitsia);
                    Console.WriteLine(a.nick);
                    Console.SetCursorPosition(25, pozitsia);
                    Console.WriteLine(a.parol);
                    Console.SetCursorPosition(45, pozitsia);
                    Console.WriteLine(a.role);
                    Console.SetCursorPosition(60, pozitsia);
                    Console.WriteLine(a.id);
                    pozitsia++;
                }
            }
        }
        private void zagolovok()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Меню администратора ");
            Console.WriteLine("______________________________________________________________________________________________________________________");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Имя");
            Console.SetCursorPosition(25, 2);
            Console.WriteLine("Пароль");
            Console.SetCursorPosition(45, 2);
            Console.WriteLine("Роль");
            Console.SetCursorPosition(60, 2);
            Console.WriteLine("ID");
        }
        private void head()
        {
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("Меню администратора ");
            Console.WriteLine("______________________________________________________________________________________________________________________");
        }
    }

}