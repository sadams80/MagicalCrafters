using System.Security.Cryptography;
using System.Text;

namespace MagicalCrafters.BLL
{
    public class PasswordBLL
    {
        public string HashPassword(string passwordToHash, string salt)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(passwordToHash);
            byte[] hashedBytes = md5.ComputeHash(inputBytes);
            StringBuilder newPassword = new StringBuilder();
            for (int i = 0; i < hashedBytes.Length; i++)
            {
                newPassword.Append(hashedBytes[i].ToString("X2")); //X2 turns it to hexadecimal
            }
            return newPassword.ToString();
        }
        public string CreateSalt()
        {
            char[] characters = new char[62];
            characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                //crypto.GetBytes(data);
                data = new byte[8];
                crypto.GetBytes(data);
            }
            StringBuilder salt = new StringBuilder(8);
            foreach (byte b in data)
            {
                salt.Append(characters[b % (characters.Length)]);
            }
            return salt.ToString();
        }
    }
}
