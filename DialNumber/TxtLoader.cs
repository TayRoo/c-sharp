using System;
using System.Collections.Generic;

namespace DialNumber
{
    public class TxtLoader
    {
        public TxtLoader()
        {
        }
        public List<object> txtLoading()
        {
            string[] text = System.IO.File.ReadAllLines(@"animalText.txt");
            List<object> readingTextList= new List<object>();
            foreach (var item in text)
            {
                readingTextList.Add(item);
            }
            return readingTextList;
        }
    }
}
