using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Practice.Models;

namespace WinForms_Practice.Services
{
    public class RequestServices
    {
        public RequestServices()
        {

        }
        public (bool, List<string>) Validate()
        {
            var errors = new List<string>();
            if (string.IsNullOrEmpty(RequestModel.URL))
            {
                errors.Add("URL cannot be empty");
            }
            if (string.IsNullOrEmpty(RequestModel.Body))
            {
            RequestModel.Body = null;
            }
            if (errors.Count == 0)
            {
                return (true, null);
            }
            errors.Add("Model cannot be empty");
            return (false, errors);
        }

        internal RestResponse APICall()
        {
            try
            {

                var client = new RestClient(RequestModel.URL);
                var request = new RestRequest();
                request.Method = RequestModel.MethodType;
                if (RequestModel.requestItemsModels != null && RequestModel.requestItemsModels.Count > 0)
                {
                    foreach (var item in RequestModel.requestItemsModels)
                    {
                        if (item.ItemType == "header")
                        {
                            request.AddHeader(item.Key, item.Value);
                        }
                        if (item.ItemType == "parameter")
                        {
                            request.AddParameter(item.Key, item.Value);
                        }
                    }
                }
                if (RequestModel.Body != null)
                {
                    try
                    {
                        JContainer.Parse(RequestModel.Body);
                        request.AddBody(RequestModel.Body);
                    }
                    catch (Exception e)
                    {

                    }
                }
                var response = client.Execute(request);
                return response;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
