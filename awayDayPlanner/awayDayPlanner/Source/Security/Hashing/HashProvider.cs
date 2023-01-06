using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace awayDayPlanner.Source.Security
{
    public class HashProvider
    {
        private static string BytesToString(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i <bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }

            return builder.ToString();
        }
        public static string Hash(string input, IHasher hasher)
        {
            return BytesToString(hasher.Hash(Encoding.Default.GetBytes(input)));
        }
    }
}
