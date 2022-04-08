using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Bcoder : ICoder

    {
        public int[] uniArray=new int[32];
        public int[] reversUniArray=new int[32];
        public Bcoder()
        {
            uniArray[0] = 1040;
            reversUniArray[0] = 1071;
            for (int i = 1; i < uniArray.Length; i++)
            {
                uniArray[i] = uniArray[i - 1] + 1;
                reversUniArray[i] = reversUniArray[i - 1] - 1;
            }

        }
        public string Decode(string s)
        {
            int temp;
            char[] symbols = s.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                temp = Convert.ToInt32(symbols[i]);
                for (int j = 0; j < uniArray.Length; j++)
                {
                    if (uniArray[j] == temp)
                    {
                        temp = reversUniArray[j];
                    }
                }


                symbols[i] = Convert.ToChar(temp);
            }
            return String.Concat(symbols);
        }

        public string Encode(string s)
        {
            int temp;
            char[] symbols = s.ToCharArray();
            for (int i = 0; i < symbols.Length; i++)
            {
                temp = Convert.ToInt32(symbols[i]);
                for (int j = 0; j < uniArray.Length; j++)
                {
                    if (reversUniArray[j] == temp)
                    {
                        temp = uniArray[j];
                    }
                }


                symbols[i] = Convert.ToChar(temp);
            }
            return String.Concat(symbols);
        }

    }


}
