using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorVersao.Application.Utils
{
    public static class StringExtensions
    {
        public static string RemoverExtencao(this string str)
        {
            IEnumerable<string> strings = str.Split(".");

            strings = strings.SkipLast(1);

            return string.Join(".", strings);
        }
    }
}
