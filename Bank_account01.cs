using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Bank_account01
    {
        private int _id;
        private decimal _balans;
        private string _account_type;

        

        public int GetId()
        {
            return _id;
        }

        public void SetId(int _id)
        {
            this._id = _id;
        }
        public decimal GetBalans()
        {
            return _balans;
        }
        public void SetBalans(decimal _balans) 
        {
            this._balans = _balans;
        }
        public string GetType()
        {
            return _account_type;
        }
        public void SetType(string _account_type)
        {
            this._account_type = _account_type;
        }

    }
}
