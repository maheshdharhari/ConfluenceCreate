
namespace CreateConfluencePage
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCreatePage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParentPageID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPageName = new System.Windows.Forms.TextBox();
            this.txtSpaceKey = new System.Windows.Forms.TextBox();
            this.CreatePage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BaseUrl = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabCreatePage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCreatePage
            // 
            this.tabCreatePage.Controls.Add(this.tabPage1);
            this.tabCreatePage.Controls.Add(this.tabPage2);
            this.tabCreatePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCreatePage.Location = new System.Drawing.Point(0, 0);
            this.tabCreatePage.Name = "tabCreatePage";
            this.tabCreatePage.SelectedIndex = 0;
            this.tabCreatePage.Size = new System.Drawing.Size(728, 347);
            this.tabCreatePage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtParentPageID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPageName);
            this.tabPage1.Controls.Add(this.txtSpaceKey);
            this.tabPage1.Controls.Add(this.CreatePage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPassword);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtUsername);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.BaseUrl);
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.txtBaseUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(695, 173);
            this.listBox1.TabIndex = 15;
            this.listBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Parent Page &ID";
            // 
            // txtParentPageID
            // 
            this.txtParentPageID.Location = new System.Drawing.Point(610, 63);
            this.txtParentPageID.Name = "txtParentPageID";
            this.txtParentPageID.Size = new System.Drawing.Size(100, 20);
            this.txtParentPageID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Page Name pre&fix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Space&Key";
            // 
            // txtPageName
            // 
            this.txtPageName.Location = new System.Drawing.Point(610, 37);
            this.txtPageName.Name = "txtPageName";
            this.txtPageName.Size = new System.Drawing.Size(100, 20);
            this.txtPageName.TabIndex = 7;
            // 
            // txtSpaceKey
            // 
            this.txtSpaceKey.Location = new System.Drawing.Point(82, 37);
            this.txtSpaceKey.Name = "txtSpaceKey";
            this.txtSpaceKey.Size = new System.Drawing.Size(294, 20);
            this.txtSpaceKey.TabIndex = 5;
            // 
            // CreatePage
            // 
            this.CreatePage.Location = new System.Drawing.Point(635, 107);
            this.CreatePage.Name = "CreatePage";
            this.CreatePage.Size = new System.Drawing.Size(75, 23);
            this.CreatePage.TabIndex = 14;
            this.CreatePage.Text = "Create &Page";
            this.CreatePage.UseVisualStyleBackColor = true;
            this.CreatePage.Click += new System.EventHandler(this.CreatePages);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "&Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(82, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(294, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "&User";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(82, 63);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(294, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Number of Pages";
            // 
            // BaseUrl
            // 
            this.BaseUrl.AutoSize = true;
            this.BaseUrl.Location = new System.Drawing.Point(12, 11);
            this.BaseUrl.Name = "BaseUrl";
            this.BaseUrl.Size = new System.Drawing.Size(44, 13);
            this.BaseUrl.TabIndex = 0;
            this.BaseUrl.Text = "Base&Url";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(610, 11);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(82, 11);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(357, 20);
            this.txtBaseUrl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create User and Groups";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 347);
            this.Controls.Add(this.tabCreatePage);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Confluence Test";
            this.tabCreatePage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCreatePage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParentPageID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPageName;
        private System.Windows.Forms.TextBox txtSpaceKey;
        private System.Windows.Forms.Button CreatePage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BaseUrl;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

