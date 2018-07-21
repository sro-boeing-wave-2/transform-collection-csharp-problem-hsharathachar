using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static List<int> Map(this int[] numarray, Func<int, int> doubleit)
        {
            //throw new NotImplementedException();
            List<int> numlist = new List<int>();
            foreach (int item in numarray)
	        {
                numlist.Add(doubleit(item));
	        }
            return numlist;
        }
    }
}
