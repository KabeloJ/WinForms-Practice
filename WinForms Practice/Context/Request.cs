using System;
using System.Collections.Generic;

#nullable disable

namespace WinForms_Practice.Context
{
    public partial class Request
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string Url { get; set; }
        public int Method { get; set; }
        public string Response { get; set; }
        public int? FolderId { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
