using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beletskiy
{
    internal class Class3 : ICrud
    {
         static int stroka = 4;
        ConsoleKeyInfo klavisha;
        static void admin()
        {
            Console.SetCursorPosition((int)admin_enum.name, 4);
            while (y.key.Key != ConsoleKey.F10)
            {
                Class2.Human = Class2.MyDeserialize<List<Class1>>("Human.json");
                Console.Clear();

                Console.WriteLine("Добро пожаловать!");
                arrows();
                Console.SetCursorPosition(stolbec, pos);
                if (y.key.Key == ConsoleKey.F1)
                    Create();
                else if (y.key.Key == ConsoleKey.F3)
                    Update();
                else if (y.key.Key == ConsoleKey.Delete)
                    Delete();
                else if (y.key.Key == ConsoleKey.F2)
                    search();
                else if (y.key.Key == ConsoleKey.Escape)
                    return;
                Console.WriteLine("->");
                y.key = Console.ReadKey();
            }
        }
        public void create()
        {
            try
            {
                 = 4;
                stolbec = (int)admin_enum.name;
                y.key = new ConsoleKeyInfo((char)ConsoleKey.A, ConsoleKey.A, false, false, false);
                string newname = "";
                string newpassword = "";
                int newid = 0;
                int newjobtitle = 0;
                int newname_length = 0;
                int newpassword_length = 0;
                int newid_length = 0;
                int newjobtitle_length = 0;
                Console.Clear();
                admin_Person newperson = new admin_Person(newname, newpassword, newid, newjobtitle);
                head();
                Console.SetCursorPosition(stolbec, pos);
                Console.Write("->");
                while (y.key.Key != ConsoleKey.S)
                {
                    Console.SetCursorPosition(70, 10);
                    Console.WriteLine("Для сохранения нажмите S");
                    Console.SetCursorPosition(stolbec, pos);
                    Console.Write("  ");
                    if (y.key.Key == ConsoleKey.RightArrow)
                    {
                        if (stolbec == (int)admin_enum.id)
                            stolbec = (int)admin_enum.job_title;
                        if (stolbec == (int)admin_enum.password)
                            stolbec = (int)admin_enum.id;
                        if (stolbec == (int)admin_enum.name)
                            stolbec = (int)admin_enum.password;
                    }
                    if (y.key.Key == ConsoleKey.LeftArrow)
                    {
                        if (stolbec == (int)admin_enum.name)
                            stolbec = (int)admin_enum.name;
                        if (stolbec == (int)admin_enum.password)
                            stolbec = (int)admin_enum.name;
                        if (stolbec == (int)admin_enum.id)
                            stolbec = (int)admin_enum.password;
                        if (stolbec == (int)admin_enum.job_title)
                            stolbec = (int)admin_enum.id;
                    }
                    Console.SetCursorPosition(stolbec, pos);
                    Console.Write("->");
                    Console.SetCursorPosition(stolbec + 2, pos);
                    if (stolbec == (int)admin_enum.name)
                        newname = changing_string(newname, newname_length);
                    else if (stolbec == (int)admin_enum.password)
                        newpassword = changing_string(newpassword, newpassword_length);
                    else if (stolbec == (int)admin_enum.id)
                        newid = Convert.ToInt32(changing_string(newid.ToString(), newid_length));
                    else if (stolbec == (int)admin_enum.job_title)
                        newjobtitle = Convert.ToInt32(changing_string(newjobtitle.ToString(), newjobtitle_length));
                    y.key = Console.ReadKey();
                }
                y.admin_panel_workers.Add(newperson);
                y.admin_serialize(y.admin_panel_workers, "admin_Person.json");
            }
            catch (Exception)
            {
                Console.WriteLine("Видимо, вы допустили ошибку. Попробуйте заново");
            }

        }

        public void delete()
        {
            y.admin_panel_workers.Remove(y.admin_panel_workers[pos - 4]);
            Console.Clear();
            y.admin_serialize(y.admin_panel_workers, "admin_Person.json");
        }

        public void read()
        {
            pos = 4;
            foreach (var a in y.admin_panel_workers)
            {
                Console.SetCursorPosition((int)admin_enum.name, pos);
                Console.Write("  " + a.username);
                Console.SetCursorPosition((int)admin_enum.password, pos);
                Console.Write("  " + a.password);
                Console.SetCursorPosition((int)admin_enum.id, pos);
                Console.Write("  " + a.idi);
                Console.SetCursorPosition((int)admin_enum.job_title, pos);
                Console.Write("  " + a.enum_job_title);
                pos++;
            }
            pos = 4;
            Console.SetCursorPosition((int)admin_enum.name, 4);
        }

        public void update()
        {
            y.key = new ConsoleKeyInfo((char)ConsoleKey.A, ConsoleKey.A, false, false, false);
            string change = "";
            int change_pos = 0;
            if (stolbec == (int)admin_enum.name)
            {
                try
                {
                    change = y.admin_panel_workers[pos - 4].username;
                    change_pos = change.Length + 1;
                    Console.SetCursorPosition(change.Length + 1, pos);
                    change = changing_string(change, change_pos);
                    y.admin_panel_workers[pos - 4].username = change;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if (stolbec == (int)admin_enum.password)
            {
                try
                {
                    change = Convert.ToString(y.admin_panel_workers[pos - 4].password);
                    Console.SetCursorPosition(change.Length + 2 + (int)admin_enum.password, pos);
                    change_pos = change.Length + 1;
                    change = changing_string(change, change_pos);
                    y.admin_panel_workers[pos - 4].password = change;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if (stolbec == (int)admin_enum.id)
            {
                try
                {
                    change = Convert.ToString(y.admin_panel_workers[pos - 4].idi);
                    Console.SetCursorPosition(change.Length + 1 + (int)admin_enum.id, pos);
                    change_pos = change.Length + 1;
                    change = changing_string(change, change_pos);
                    y.admin_panel_workers[pos - 4].idi = Convert.ToInt32(change);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if (stolbec == (int)admin_enum.job_title)
            {
                try
                {
                    change = Convert.ToString(y.admin_panel_workers[pos - 4].enum_job_title);
                    Console.SetCursorPosition(change.Length + 1 + (int)admin_enum.job_title, pos);
                    change_pos = change.Length + 1;
                    change = changing_string(change, change_pos);
                    y.admin_panel_workers[pos - 4].enum_job_title = Convert.ToInt32(change);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            y.admin_serialize(y.admin_panel_workers, "admin_Person.json");
        }
    }
        static void strlochki(ConsoleKeyInfo klavisha, int pozitsia)
        {
            switch (klavisha)
            {
                case ConsoleKey.DownArrow:
                    {
                        Console.WriteLine("  ");
                        pozitsia++;
                        if (pozitsia > 5)
                            pozitsia = 5;
                        return pozitsia;

                    }
                case ConsoleKey.UpArrow:
                    {
                        Console.Write("  ");
                        pos--;
                        if (pos < 4)
                            pos = 4;
                        break;
                    }
            }
        }
        public static string changing_string(string change_string, int change_string_pos)
        {
            while (y.key.Key != ConsoleKey.Enter)
            {
                y.key = Console.ReadKey();
                if (y.key.Key == ConsoleKey.UpArrow || y.key.Key == ConsoleKey.DownArrow)
                {
                    break;
                }
                if (y.key.Key == ConsoleKey.Backspace && change_string.Length > 0)
                {
                    change_string = change_string.Remove(change_string.Length - 1);
                    login.clear(change_string, change_string_pos);
                    change_string_pos--;
                }
                else if (y.key.Key != ConsoleKey.Enter || y.key.Key == ConsoleKey.UpArrow || y.key.Key == ConsoleKey.DownArrow)
                {
                    change_string_pos++;
                    change_string += y.key.KeyChar;
                }
            }
            return change_string;
        }
    private static void search()
    {
        Console.SetCursorPosition(70, 10);
        Console.Clear();
        head();
        Console.SetCursorPosition(70, 8);
        Console.WriteLine("Для выхода нажмите Escape");
        Console.SetCursorPosition(70, 10);
        search_string = changing_string(search_string, search_pos);

        while (y.key.Key != ConsoleKey.Escape)
        {
            show_search();
            y.key = Console.ReadKey();
        }
    }
    private static void show_search()
    {
        Console.Clear();
        head();
        foreach (var a in y.admin_panel_workers)
        {
            if (search_string == a.idi.ToString() || search_string == a.username || search_string == a.enum_job_title.ToString() || search_string == a.password)
            {
                Console.SetCursorPosition((int)admin_enum.name, pos);
                Console.Write("  " + a.username);
                Console.SetCursorPosition((int)admin_enum.password, pos);
                Console.Write("  " + a.password);
                Console.SetCursorPosition((int)admin_enum.id, pos);
                Console.Write("  " + a.idi);
                Console.SetCursorPosition((int)admin_enum.job_title, pos);
                Console.Write("  " + a.enum_job_title);
                pos++;
            }
        }
    }
}
