using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Acoder : ICoder
    {
        public string Decode(string s)
        {
            string final;
            int temp;
            char[] symbols = s.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                temp = Convert.ToInt32(symbols[i] - 1);
                symbols[i] =Convert.ToChar(temp);
            }
            
            return final=String.Concat(symbols);
        }

        public string Encode(string s)
        {
            string final;
            int temp;
            char[] symbols = s.ToCharArray();

            for (int i = 0; i < symbols.Length; i++)
            {
                temp = Convert.ToInt32(symbols[i] + 1);
                symbols[i] = Convert.ToChar(temp);
            }

            return final = String.Concat(symbols);
        }
    }
}
