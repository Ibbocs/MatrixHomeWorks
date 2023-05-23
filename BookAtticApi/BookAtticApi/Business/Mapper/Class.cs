using System.Collections.Generic;

namespace BookAtticApi.Business.Mapper
{
    public class Class
    {
        public bool IsAnagram(string s, string t)
        {
            List<string> strings1= new List<string>();
            List<string> strings2= new List<string>();

            foreach (var item in s)
            {
                strings1.Add(item.ToString());
            }

            foreach (var item in t)
            {
                strings2.Add(item.ToString());
            }

            if (strings1.Equals(strings2))
            {

            }


            return true;
        }
    }
}
