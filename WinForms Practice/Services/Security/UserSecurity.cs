using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WinForms_Practice.Access;

namespace WinForms_Practice.Services.Security
{
    public class UserSecurity
    {
        UserAccess _user;
        public UserSecurity()
        {
            _user = new UserAccess();
        }
        public (bool, string) Register(string userName, string password)
        {
            if (!_user.CheckUserName(userName))
            {
                string passwordHash = password.GetHashCode().ToString();
                return (true,_user.Create(userName, passwordHash));
            }
            return (false,"User already exist");
        }

        internal void Authorize(string status)
        {
            var user = System.Security.Principal.WindowsIdentity.GetCurrent();
            string pcUser = user?.Name;
            if (pcUser != null)
            {
                pcUser = pcUser.Split("\\").LastOrDefault();
            }
            string filePath = @$"C:\Users\{pcUser}\AppData\Roaming\Microsoft\AddIns\\piuyguihuh.txt";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            File.WriteAllText(filePath,status);
        }
    }
}
