using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    public class Bank_account03
    {
        private int _id;
        private decimal _balans;
        private string _account_type;

        public int id;
        public decimal balans;
        public string account_type;

        public Bank_account03()
        {
            Random rand = new Random();
            _id = rand.Next(1, 99999);
            id = _id;
        }

        public Bank_account03(decimal _balans)
        {
            Random rand = new Random();
            _id = rand.Next(1, 99999);
            this._balans = _balans;
            id = _id;
            balans = _balans;
        }

        public Bank_account03(string _account_type)
        {
            Random rand = new Random();
            _id = rand.Next(1, 99999);
            this._account_type = _account_type;
            id = _id;
            account_type = _account_type;
        }

        public Bank_account03(decimal _balans,string _account_type)
        {
            Random rand = new Random();
            _id = rand.Next(1, 99999);
            this._balans = _balans;
            this._account_type = _account_type;
            id = _id;
            balans = _balans;
            account_type = _account_type;
        }


    }
}
