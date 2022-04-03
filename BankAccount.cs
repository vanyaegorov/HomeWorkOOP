using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class BankAccount
    {

        private int _id;
        private decimal _balans;
        private string _accountType;
        public decimal Balans { get { return _balans; } set { _balans = value; } }
        public BankAccount()
        {
            Random rand = new Random();
            _id = rand.Next(1, 99999);
        }
        public BankAccount(decimal balans, string accountType)
        {
            Random rand = new Random();
            _id = rand.Next(1, 99999);
            this._balans = balans;
            this._accountType = accountType;
        }

        public static bool operator ==(BankAccount ba1,BankAccount ba2)
        {
            if (ba1._id == ba2._id && ba1._accountType == ba2._accountType && ba1._balans == ba2._balans)
                return true;
            else
                return false;
        }
        public static bool operator !=(BankAccount ba1, BankAccount ba2)
        {
            if (ba1._id != ba2._id || ba1._accountType != ba2._accountType || ba1._balans != ba2._balans)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            return obj is BankAccount account &&
                   _id == account._id &&
                   _balans == account._balans &&
                   _accountType == account._accountType &&
                   Balans == account.Balans;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_id, _balans, _accountType, Balans);
        }
        public override string ToString()
        {
            string s = $"ID:{_id};Account type:{_accountType};Balans:{_balans}";
            return s;
        }
    }
}
