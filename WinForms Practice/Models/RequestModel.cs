using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Practice.Models
{
    public static class RequestModel
    {
        public static int Id { get; set; }
        public static string? Body { get; set; }
        public static string? URL { get; set; } = "https://login.identity.barko.co.za/connect/token";
        public static List<RequestItemsModel> requestItemsModels { get; set; }
        public static string? Response { get; set; }
        public static Method MethodType { get; set; }
    }
}
