using System;

namespace lesson3
{
    class BankAccount
    {
        private int id;
        private decimal balans;
        private string accountType;
        public decimal Balans { get { return balans; } set { balans = value; } }
        public BankAccount()
        {
            Random rand = new Random();
            id = rand.Next(1, 99999);
        }
        public BankAccount(decimal balans, string accountType)
        {
            Random rand = new Random();
            id = rand.Next(1, 99999);
            this.balans = balans;
            this.accountType = accountType;
        }
        /*1. В класс банковский счет, созданный в упражнениях, добавить метод, который 
            переводит деньги с одного счета на другой.У метода два параметра: ссылка на
        объект класса банковский счет откуда снимаются деньги, второй параметр – сумма.*/
        public static void TransferMoney(BankAccount accountTakeOff, decimal sum)
        {
            if (accountTakeOff.balans >= sum)
            {
                accountTakeOff.balans -= sum;
            }
            else
                Console.WriteLine("Недостаточно средств");
        }
    }
}
