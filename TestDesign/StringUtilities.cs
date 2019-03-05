using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesign
{
   public class StringUtilities
    {
        public int CountOccurences(string stringToCheck, char stringToFind)
        {

            if (stringToCheck == null)
            {
                return -1;
            }

            else
            {
                    return stringToCheck.ToUpper().ToLower().Count(s => s == stringToFind);
            }
            
        }


    }
}
