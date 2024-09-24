using System.Security.Cryptography;
using System.Text;

namespace Controllers
{
    public class Encrypt
    {
        public static string GetSHA256(string str) 
        {
            SHA256 sh = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();

            stream = sh.ComputeHash(encoding.GetBytes(str));

            for (int i= 0; i< stream.Length; i++) 
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            //string s = sb.ToString();
            return sb.ToString();
        }
    }
}
