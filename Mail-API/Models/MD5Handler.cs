using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mail_API.Models
{
    public class MD5Handler
    {
        public static string Hash(string str)
        {
            if (str == null)
            {
                str = "";
            }
            byte[] hash;
            using (MD5 md5 = MD5.Create())
            {
                hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            }
            return BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }
    }
}
