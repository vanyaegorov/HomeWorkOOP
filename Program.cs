using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пункт задания 1
            Bank_account01 acc = new Bank_account01();
            acc.SetId(777);
            acc.SetBalans(999999);
            acc.SetType("дебетовый");
            Console.WriteLine($"ID:{acc.GetId()}");
            Console.WriteLine($"Баланс:{acc.GetBalans()}");
            Console.WriteLine($"Тип счета:{acc.GetType()}");
            Console.WriteLine(new string ('-',50));

            //Пункт задания 2
            Bank_account02 acc02 = new Bank_account02();
            acc02.SetId();
            acc02.SetBalans(999999);
            acc02.SetType("дебетовый");
            Console.WriteLine($"ID:{acc02.GetId()}");
            Console.WriteLine($"Баланс:{acc02.GetBalans()}");
            Console.WriteLine($"Тип счета:{acc02.GetType()}");
            Console.WriteLine(new string('-', 50));

            //Пункт задания 3
            Bank_account03 acc03 = new Bank_account03();
            Console.WriteLine($"ID:{acc03.id}");
            Console.WriteLine($"Баланс:{acc03.balans}");
            Console.WriteLine($"Тип счета:{acc03.account_type}");
            Console.WriteLine(new string('-', 50));

            Bank_account03 acc031 = new Bank_account03(1000000);
            Console.WriteLine($"ID:{acc031.id}");
            Console.WriteLine($"Баланс:{acc031.balans}");
            Console.WriteLine($"Тип счета:{acc031.account_type}");
            Console.WriteLine(new string('-', 50));

            Bank_account03 acc032 = new Bank_account03("кредитный");
            Console.WriteLine($"ID:{acc032.id}");
            Console.WriteLine($"Баланс:{acc032.balans}");
            Console.WriteLine($"Тип счета:{acc032.account_type}");
            Console.WriteLine(new string('-', 50));

            Bank_account03 acc033 = new Bank_account03(1000000,"дебетовый");
            Console.WriteLine($"ID:{acc033.id}");
            Console.WriteLine($"Баланс:{acc033.balans}");
            Console.WriteLine($"Тип счета:{acc033.account_type}");
            Console.WriteLine(new string('-', 50));

            //Пункт задания 4

            Bank_account04 acc04 = new Bank_account04();
            acc04.id = 777;
            acc04.balans = 999999;
            acc04.account_type = "кредитный";
            Console.WriteLine($"ID:{acc04.id}");
            Console.WriteLine($"Баланс:{acc04.balans}");
            Console.WriteLine($"Тип счета:{acc04.account_type}");
            Console.WriteLine(new string('-', 50));

            //Пункт задания 5

            Bank_account05 acc05 = new Bank_account05();
            acc05.id = 777;
            acc05.balans = 1000;
            acc05.account_type = "дебетовый";
            Console.WriteLine($"ID:{acc05.id}");
            Console.WriteLine($"Баланс:{acc05.balans}");
            Console.WriteLine($"Тип счета:{acc05.account_type}");
            acc05.TakeOff(2000);
            Console.WriteLine(new string('-', 50));
            acc05.TakeOff(500);
            Console.WriteLine(new string('-', 50));
            acc05.TopUp(10000);



        }
    }
}
