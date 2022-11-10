using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Practice.Models;
using RestSharp;
using WinForms_Practice.Services;
using Newtonsoft.Json;

namespace WinForms_Practice
{
    public partial class MainForm : Form
    {
        string paramOrheader { get; set; }
        RequestServices services { get; set; }
        public MainForm()
        {
            InitializeComponent();
            RequestModel.MethodType = RestSharp.Method.Get;
            paramOrheader = "parameter";
            dataGridView1.AutoSize = true;
        }
        void Toggle()
        {
            panel1.Visible = !panel1.Visible;
            panel2.Visible = !panel2.Visible;
        }

        #region AutoSize FlowLayoutPanel
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            flTop.Width = this.Width-30;
            richTextBox2.Width = this.Width - 30;
            richTextBox2.BorderStyle = BorderStyle.None;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MethodChanged(object sender, EventArgs e)
        {
            if (this.Get.Checked)
            {
                RequestModel.MethodType = Method.Get;
            }
            if (this.Post.Checked)
            {
                RequestModel.MethodType = Method.Post;
            }
            if (this.Delete.Checked)
            {
                RequestModel.MethodType = Method.Delete;
            }
            if (this.Put.Checked)
            {
                RequestModel.MethodType = Method.Put;
            }
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            RequestModel.URL = textBox1.Text;
            RequestModel.Body = richTextBox1.Text;
            services = new RequestServices();
            bool success;
            List<string> errors;
            richTextBox2.Text = "";
            (success,errors) = services.Validate();
            if (success)
            {
                var r = services.APICall();
                if (r != null)
                {
                    try
                    {

                        var t = JsonConvert.DeserializeObject(r.Content);
                        var str = JsonConvert.SerializeObject(t, Formatting.Indented);
                        RequestModel.Response = str;
                    }
                    catch (Exception)
                    {
                        RequestModel.Response = r.Content;
                    }
                }
                richTextBox2.Text = RequestModel.Response;
            }
            else
            {
                richTextBox2.Text = "";
                richTextBox2.ForeColor = Color.Red;
                foreach (var item in errors)
                {
                    richTextBox2.Text = item.ToString();
                }
            }
        }

        private void Header_CheckedChanged(object sender, EventArgs e)
        {
            paramOrheader = "header";
        }

        private void Parameter_CheckedChanged(object sender, EventArgs e)
        {
            paramOrheader = "parameter";
        }

        private void Add_Click(object sender, EventArgs e)
        {

            if (RequestModel.requestItemsModels == null)
            {
                RequestModel.requestItemsModels = new List<RequestItemsModel>();
            }
            RequestModel.requestItemsModels.Add(
                new RequestItemsModel()
                {  
                    Id = Guid.NewGuid().ToString(),
                    ItemType = paramOrheader,
                    Key = txtKey.Text,
                    Value = txtValue.Text
                }
            );
            txtKey.Text = "";
            txtValue.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = RequestModel.requestItemsModels;
            if (dataGridView1.Columns.Count != 3)
            {
                dataGridView1.Columns.RemoveAt(0);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
