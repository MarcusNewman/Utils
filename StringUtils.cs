using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class StringUtils
    {
        public static string Pluralize(int number, string word)
        {
            return string.Format("{0} {1}{2}", number, word, number > 1 ? "s" : "");
        }
    }
}
