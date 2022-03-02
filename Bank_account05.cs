using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Bank_account05
    {
        private int _id;
        private decimal _balans;
        private string _account_type;

        public int id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public decimal balans
        {
            set
            {
                _balans = value;
            }
            get
            {
                return _balans;

            }
        }
        public string account_type
        {
            set
            {
                _account_type = value;
            }
            get
            {
                return _account_type;
            }
        }

        public void TakeOff(decimal x)
        {
            if (x > _balans)
            {
                Console.WriteLine("Недостаточно средств");
                
            }
            else
            {
                _balans-=x;
                Console.WriteLine($"Ваш баланс {_balans}");
               
            }
        }

        public void TopUp(decimal x)
        {
            _balans +=x;
            Console.WriteLine($"Ваш баланс {_balans}");

        }

    }
}
