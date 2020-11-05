using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ZvukDb
{
    class Password
    {
        public static string GetHashCode(string str)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            return Convert.ToBase64String(hash);
        }

        public static bool EqualHashCode(string str, string hash)
        {
            return hash == GetHashCode(str);
        }
    }
}
