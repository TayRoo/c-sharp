using System;
using System.Collections.Generic;

namespace DialNumber
{
    public class GetNumber
    {
        

        public GetNumber()
        {
            
        }
        public void GetNumbers(string animal)
        {
            Dictionary<int, string> numberLetter = new Dictionary<int, string>();

            numberLetter.Add(2, "ABC");
            numberLetter.Add(3, "DEF");
            numberLetter.Add(4, "GHI");
            numberLetter.Add(5, "JKL");
            numberLetter.Add(6, "MNO");
            numberLetter.Add(7, "PQRS");
            numberLetter.Add(8, "TUV");
            numberLetter.Add(9, "WXYZ");
            string result = "";
            foreach (var i in animal)
            {
                // C
                foreach (var j in numberLetter)
                {
                    if (j.Value.Contains(i))
                    {
                        result += j.Key;
                        break;
                    }
                }

            }
            Console.WriteLine(result);
        }
    }
}
