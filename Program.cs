using System;
using System.IO;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount takeOff = new BankAccount(3000, "debet");
            Console.WriteLine("До снятия");
            Console.WriteLine($"Счет баланс={takeOff.Balans}");
            Console.WriteLine("Снимаем 500");
            BankAccount.TransferMoney(takeOff, 500);
            Console.WriteLine("После снятия");
            Console.WriteLine($"Счет баланс={takeOff.Balans}");
            Console.WriteLine("Снимаем еще 5000");
            BankAccount.TransferMoney(takeOff, 5000);

            Console.WriteLine(ReverseString("123456789"));
            /*3. * Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail 
                адрес.Разделителем между ФИО и адресом электронной почты является 
                символ &: Кучма Андрей Витальевич & Kuchma@mail.ru
                Мизинцев Павел Николаевич &Pasha@mail.ru Сформировать новый файл,
                содержащий список адресов электронной почты. Предусмотреть метод, 
                выделяющий из строки адрес почты. Методу в качестве параметра передается 
                символьная строка s, e-mail возвращается в той же строке 
                s: public void SearchMail(ref string s).*/
            string filename = "text.txt";
            string newfilename = "newtext.txt";
            string[] arrstr = File.ReadAllLines(filename);
            for (int i = 0; i < arrstr.Length; i++)
            {
                SearchMail(ref arrstr[i]);
            }
                File.WriteAllLines(newfilename, arrstr);
            foreach (string p in arrstr)
            {
                Console.WriteLine(p);
            }
        }

        /*Реализовать метод, который в качестве входного параметра принимает строку string,
            возвращает строку типа string, буквы в которой идут в обратном порядке.
            Протестировать метод.*/
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string revers = String.Concat<char>(arr);
            return revers;
        }

        public static void SearchMail(ref string s)
        {
            string[] words = s.Split('&');
            s = words[1];
        }

    }
}
