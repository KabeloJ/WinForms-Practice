using System;
using System.Collections.Generic;

#nullable disable

namespace WinForms_Practice.Context
{
    public partial class User
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }
}
