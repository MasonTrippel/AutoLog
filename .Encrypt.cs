using System;
using System.Security.Cryptography;
using System.Text;

namespace Autolog
{
    public class Encrypt


    {
        public static string HashString(string paswordString)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte b in GetHash(paswordString))
            {

                sb.Append(b.ToString("X3"));
            }
            return sb.ToString();



        }

        public static byte[] GetHash(string passwordString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
            {
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordString));
            }

        }

        public static String MasterPass;
        public string gameHashString(string passwordString)
        {

            int hash = MasterPass.GetHashCode();
            if (hash < 0)
            {
                hash *= -1;
            }
            while (hash > 10)
            {
                hash /= 10;
            }
            StringBuilder sb = new StringBuilder();



            foreach (char c in passwordString)
            {
                char x = (char)((int)c + hash);
                sb.Append(x);
                hash++;
            }
            return sb.ToString();
        }

        public string gamePassDecrypt(string passwordString)
        {
            int hash = MasterPass.GetHashCode();
            if (hash < 0)
            {
                hash *= -1;

            }
            while (hash > 10)
            {
                hash /= 10;
            }
            StringBuilder sb = new StringBuilder();



            foreach (char c in passwordString)
            {
                char x = (char)((int)c - hash);
                sb.Append(x);
                hash++;
            }
            return sb.ToString();
        }

    }

}

