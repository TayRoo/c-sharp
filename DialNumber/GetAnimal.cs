using System;
using System.Collections.Generic;

namespace DialNumber
{
    public class GetAnimal
    {
        public GetAnimal()
        {
        }
        public List<object> GetAnimals(string numbers, List<object> list)
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
            int count = 0;
            List<string> newList = new List<string>();

            foreach (var i in numbers)
            {
                // i == "2" : "2" : 8
                foreach (var j in numberLetter)
                {
                    int val = (int)Char.GetNumericValue(i);
                    if (j.Key == val )
                    {
                        result = j.Value;
                        foreach (string k in list)
                        {// k = CAT : DOG : BAT
                            for (int c = 0 + count; c <= k.Length; c++) // foreach (var m in k)
                            {// m = C
                                if (result.Contains(k[c]))
                                {
                                    // add new list
                                    newList.Add(k);
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }                         
                        }
                    }
                }
                list.Clear();
                list.AddRange(newList);
                newList.Clear();
                count++;
            }
            return list;
        }
    }
}
