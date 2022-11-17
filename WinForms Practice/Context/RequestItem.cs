using System;
using System.Collections.Generic;

#nullable disable

namespace WinForms_Practice.Context
{
    public partial class RequestItem
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string ItemType { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
