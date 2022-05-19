using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using HashingAlgorithms;

namespace ChapeauLogica
{
    public class PasswordService
    {
        // er komt nog van HashSaltResult bij


        /*   private bool PasswordVerify(string enteredPassword, Password hashSalt)
           {
               byte[] saltInBytes = Convert.FromBase64String(hashSalt.Salt);
               Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(enteredPassword, saltInBytes, 10000);
               return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == hashSalt.Digest;
           }*/
        public Password HashWithSalt(string password)
        {
            HashAlgorithm hashAlgo = SHA512.Create();
            byte[] saltBytes = this.GetSaltBytes();
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new Password(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        public byte[] GenerateSalt(int saltLength)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            return saltBytes;
        }

        private byte[] GetSaltBytes()
        {
            byte[] saltBytes;
            if (ConfigurationManager.AppSettings["Salt"] == null)
            {
                saltBytes = this.GenerateSalt(64);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Add("Salt", Convert.ToBase64String(saltBytes));
                config.Save(ConfigurationSaveMode.Modified);
            }
            else
            {
                saltBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["Salt"]);
            }
            return saltBytes;
        }
        private bool PasswordVerify(string password, string hashSalt) 
        {
            string checkPassword = HashWithSalt(password).Digest;

            if (checkPassword == hashSalt)
                return true;
            return false;
        }


    }
}
