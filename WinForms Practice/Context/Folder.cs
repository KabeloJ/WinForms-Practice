using System;
using System.Collections.Generic;

#nullable disable

namespace WinForms_Practice.Context
{
    public partial class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FolderId { get; set; }
    }
}
