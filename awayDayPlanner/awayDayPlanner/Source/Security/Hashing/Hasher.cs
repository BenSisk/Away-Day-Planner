using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace awayDayPlanner.Source.Security
{
    public class SHA256Hasher : IHasher
    {
        public byte[] Hash(byte[] data)
        {
            SHA256 hasher = new SHA256Managed();
            return hasher.ComputeHash(data);
        }
    }
}
