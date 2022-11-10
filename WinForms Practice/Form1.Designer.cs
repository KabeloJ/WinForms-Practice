
namespace WinForms_Practice
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flTop = new System.Windows.Forms.FlowLayoutPanel();
            this.Get = new System.Windows.Forms.RadioButton();
            this.Post = new System.Windows.Forms.RadioButton();
            this.Delete = new System.Windows.Forms.RadioButton();
            this.Put = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Parameter = new System.Windows.Forms.RadioButton();
            this.Header = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.flTop);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.richTextBox2);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            // 
            // flTop
            // 
            resources.ApplyResources(this.flTop, "flTop");
            this.flTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flTop.Controls.Add(this.Get);
            this.flTop.Controls.Add(this.Post);
            this.flTop.Controls.Add(this.Delete);
            this.flTop.Controls.Add(this.Put);
            this.flTop.Controls.Add(this.textBox1);
            this.flTop.Controls.Add(this.btnSend);
            this.flTop.Name = "flTop";
            // 
            // Get
            // 
            resources.ApplyResources(this.Get, "Get");
            this.Get.Name = "Get";
            this.Get.TabStop = true;
            this.Get.Tag = "Method";
            this.Get.UseVisualStyleBackColor = true;
            this.Get.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // Post
            // 
            resources.ApplyResources(this.Post, "Post");
            this.Post.Name = "Post";
            this.Post.TabStop = true;
            this.Post.Tag = "Method";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Name = "Delete";
            this.Delete.TabStop = true;
            this.Delete.Tag = "Method";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // Put
            // 
            resources.ApplyResources(this.Put, "Put");
            this.Put.Name = "Put";
            this.Put.TabStop = true;
            this.Put.Tag = "Method";
            this.Put.UseVisualStyleBackColor = true;
            this.Put.CheckedChanged += new System.EventHandler(this.MethodChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox2, "richTextBox2");
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Add);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtValue);
            this.panel2.Controls.Add(this.txtKey);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Parameter);
            this.flowLayoutPanel1.Controls.Add(this.Header);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // Parameter
            // 
            resources.ApplyResources(this.Parameter, "Parameter");
            this.Parameter.Checked = true;
            this.Parameter.Name = "Parameter";
            this.Parameter.TabStop = true;
            this.Parameter.Tag = "ParaNHeader";
            this.Parameter.UseVisualStyleBackColor = true;
            this.Parameter.CheckedChanged += new System.EventHandler(this.Parameter_CheckedChanged);
            // 
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.Name = "Header";
            this.Header.TabStop = true;
            this.Header.Tag = "ParaNHeader";
            this.Header.UseVisualStyleBackColor = true;
            this.Header.CheckedChanged += new System.EventHandler(this.Header_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtValue
            // 
            resources.ApplyResources(this.txtValue, "txtValue");
            this.txtValue.Name = "txtValue";
            // 
            // txtKey
            // 
            resources.ApplyResources(this.txtKey, "txtKey");
            this.txtKey.Name = "txtKey";
            // 
            // Add
            // 
            resources.ApplyResources(this.Add, "Add");
            this.Add.Name = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flTop.ResumeLayout(false);
            this.flTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flTop;
        private System.Windows.Forms.RadioButton Get;
        private System.Windows.Forms.RadioButton Post;
        private System.Windows.Forms.RadioButton Delete;
        private System.Windows.Forms.RadioButton Put;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton Parameter;
        private System.Windows.Forms.RadioButton Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button Add;
    }
}
