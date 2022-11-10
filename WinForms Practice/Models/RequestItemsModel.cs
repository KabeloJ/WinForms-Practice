using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Practice.Models
{
    public class RequestItemsModel
    {
        public string Id { get; set; }
        [Display(Name = "Item")]
        public string ItemType { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
