using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public static class Helper
    {

        /// <summary>
        /// Parse string to int
        /// </summary>
        /// <param name="source"></param>
        /// <returns>
        /// If unable parse to int return -1
        /// </returns>
        public static int GetInt(this string source)
        {
            int i;
            if (int.TryParse(source, out i))
            {
                return i;
            }
            return -1;
        }

        public static DateTime GetDate(this string source)
        {
            DateTime date = DateTime.Now;
            //if (date.(source))
            //{
            //    return i;
            //}
            return date;
        }

    }
}
