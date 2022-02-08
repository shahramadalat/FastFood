using System;
using System.Security.Cryptography;
using System.Text;

namespace FastFood
{
   public class classencrypt
    {
        private static string hash = "f0xle@rn";
        public static string endresult = null;
        public void encrypt(string values)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(values);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            ICryptoTransform transform = triple.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            endresult = Convert.ToBase64String(result, 0, result.Length);
        }

        public void decrypt(string value)
        {
            byte[] data = Convert.FromBase64String(value);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            TripleDESCryptoServiceProvider triple = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
            ICryptoTransform transform = triple.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
            endresult = UTF8Encoding.UTF8.GetString(result);
        }



    }
}
