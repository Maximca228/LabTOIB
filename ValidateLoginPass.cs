using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace LabTOIB
{
    class Valid
    {
        public static bool ValidateLogin(string actual_login, string typed_login)
        {
            return actual_login.Equals(typed_login, StringComparison.OrdinalIgnoreCase);
        }
        public static bool ValidatePassword(string actual_pw, string typed_pw)
        {

            Stopwatch sw = new Stopwatch();
            sw.Start();

            byte[] typedPwHash;
            using (SHA256 sha256 = SHA256.Create())
            {
                typedPwHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(typed_pw));
            }

            byte[] actualPwHash;
            using (SHA256 sha256 = SHA256.Create())
            {
                actualPwHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(actual_pw));
            }

            if (!typedPwHash.SequenceEqual(actualPwHash))
            {
                    sw.Stop();
                    MessageBox.Show($"Ошибка авторизации за {sw.Elapsed}");
                    return false;
            }

            sw.Stop();
            MessageBox.Show($"Авторизовано за {sw.Elapsed}");
            return true;
        }
    }

}
