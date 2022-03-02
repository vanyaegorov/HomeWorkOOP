using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Bank_account04
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
    }
}
