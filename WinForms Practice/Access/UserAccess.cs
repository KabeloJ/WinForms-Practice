using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Practice.Context;

namespace WinForms_Practice.Access
{
    public class UserAccess
    {
        public string Create(string userName, string password)
        {
            using (var db = new PostManDBContext())
            {
                var data = new User()
                {
                    Id = Guid.NewGuid().ToString(),
                    PasswordHash = password,
                    UserName = userName
                };
                db.Users.Add(data);
                db.SaveChanges();
                return data.Id;
            }
        }

        public bool CheckUserName(string userName)
        {
            using (var db = new PostManDBContext())
            {
                var user = db.Users.Where(x => x.UserName == userName).Count();
                if (user > 0)
                    return true;
                return false;
            }
        }
    }
}
