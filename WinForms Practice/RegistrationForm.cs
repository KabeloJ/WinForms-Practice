using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Practice.Models;
using WinForms_Practice.Services.Security;

namespace WinForms_Practice
{
    public partial class RegistrationForm : Form
    {
        UserSecurity _security;
        public RegistrationForm()
        {
            InitializeComponent();
            _security = new UserSecurity();
            Initialize();
            this.();
        }
        private void Initialize()
        {

            var user = System.Security.Principal.WindowsIdentity.GetCurrent();
            string pcUser = user?.Name;
            if (pcUser != null)
            {
                pcUser = pcUser.Split("\\").LastOrDefault();
            }
            string filePath = @$"C:\Users\{pcUser}\AppData\Roaming\Microsoft\AddIns\\piuyguihuh.txt";

            if (File.Exists(filePath))
            {
                string objId = File.ReadAllText(filePath);
                if (!string.IsNullOrEmpty(objId))
                {
                    UserPreference.Id = objId;
                    var mainForm = new MainForm();
                    mainForm.Show();
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrWhiteSpace(txtUsername.Text)&&
                    !string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    string status;
                    bool success;
                   (success, status) = _security.Register(txtUsername.Text, txtPassword.Text);
                    if (success)
                    {
                        _security.Authorize(status);
                    }
                    else
                    {
                        MessageBox.Show(status, "Login Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
