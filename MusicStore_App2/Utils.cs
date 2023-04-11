using System.Security.Cryptography;
using System.Text;

namespace MusicStore_App2
{
    internal class Utils
    {
        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            //Convert the input string to a byte array and compute the hash.
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            //Create a new Stringbuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();

            //Loop through each byte of the hased data and format each one as hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                //This expression formats each byte in the data array as a two-character wide hexadecimal string ("x2").
                sBuilder.Append(data[i].ToString("x2"));
            }

            //At this point, anything the user types in will be nothing like the actual insertion, but it will be completely encrypted.
            return sBuilder.ToString();
        }
    }
}
