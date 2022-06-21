using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BINAES
{
    public static class Utils
    {
        public static string GenerateNonEncryptedHash ()
        {
            string cad = "hola";
            SHA1 hash = SHA1.Create();
            byte[] textBytes = Encoding.UTF8.GetBytes(cad);

            return BitConverter.ToString(hash.ComputeHash(textBytes)).Replace("-", string.Empty);
        }
    }
}
