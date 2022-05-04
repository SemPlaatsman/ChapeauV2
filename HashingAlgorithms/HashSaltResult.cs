using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashingAlgorithms
{
    public class HashSaltResult
    {
        public string Salt { get; }
        public string Digest { get; set; }

        public HashSaltResult(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}
