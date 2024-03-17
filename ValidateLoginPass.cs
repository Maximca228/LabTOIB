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

            if(actual_pw.Length != typed_pw.Length)
            {
                sw.Stop();
                MessageBox.Show($"Ошибка авторизации за {sw.Elapsed}");
                return false;

            }


            for (int i = 0; i < actual_pw.Length; i++)
            {
                Thread.Sleep(100);
                if (actual_pw[i] != typed_pw[i])
                {
                    sw.Stop();
                    MessageBox.Show($"Ошибка авторизации за {sw.Elapsed}");
                    return false;
                }
            }

            sw.Stop();
            MessageBox.Show($"Авторизовано за {sw.Elapsed}");
            return true;
        }
    }

}
