using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Password
    {
        public string Salt { get; }
        public string Digest { get; set; }

        public Password(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}
