using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class PersianExtentions
    {
        public static string ToPersian(this StringBuilder input, bool isFloat = false) => ToPersian(input.ToString(), isFloat);
        public static string ToPersian(this string input, bool isFloat = false)
        {
            if (string.IsNullOrWhiteSpace(input)) 
                return string.Empty;

            var result = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if ('0' <= c && c <= '9')
                    c += 'ۀ';

                if (isFloat && c == '.')
                    c = '/';

                result.Append(c);
            }

            return result.ToString();
        }

        public static string ToLatin(this StringBuilder input) => ToLatin(input.ToString());
        public static string ToLatin(this string input)
        {
            if (string.IsNullOrWhiteSpace(input)) 
                return string.Empty;

            var result = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if ('۰' <= c && c <= '۹')
                    c -= 'ۀ';

                result.Append(c);
            }

            return result.ToString();
        }

    }
}
