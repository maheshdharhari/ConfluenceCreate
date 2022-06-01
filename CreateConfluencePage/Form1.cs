using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using Serilog;
using System;
using System.Windows.Forms;

namespace CreateConfluencePage
{
    public partial class Form1 : Form
    {
        string _pageTitle = string.Empty;

        public Form1()
        {
            InitializeComponent();
            txtBaseUrl.Text = @"https://confluence.av.local:8411/";
            txtUsername.Text = @"admin";
            txtPassword.Text = @"admin";
            txtNumber.Text = @"10000";
            txtSpaceKey.Text = @"TEST";
            txtParentPageID.Text = @"12877826";
            txtPageName.Text = @"TestPage";
        }

        protected void CreatePages(object sender, EventArgs e)
        {
            try
            {
                for (var i = 0; i < Convert.ToInt64(txtNumber.Text); i++)
                {
                    try
                    {
                        var pageTitle = txtPageName.Text + " " + i + " " + Guid.NewGuid();
                        _pageTitle = pageTitle;
                        var parentPageId = txtParentPageID.Text;
                        var spaceKey = txtSpaceKey.Text;
                        const string pageHtml =
                            "<p>This page was created with code written by <a href = 'https://www.maheshyadav.com.np/'> Mahesh Kumar Yadav </a></p>";
                        var data =
                            $"{{\"type\":\"page\",\"title\":\"{pageTitle}\",\"ancestors\":[{{\"id\":\"{parentPageId}\"}}],\"space\":{{\"key\":\"{spaceKey}\"}},\"body\":{{\"storage\":{{\"value\":\"{pageHtml}\",\"representation\":\"storage\"}}}}}}";
                        var jsonObject = JObject.Parse(data);

                        var client = new RestClient(txtBaseUrl.Text)
                        {
                            Authenticator = new HttpBasicAuthenticator(txtUsername.Text, txtPassword.Text)
                        };
                        var request = new RestRequest("/rest/api/content/", Method.POST);
                        request.AddHeader("Content-Type", "application/json");
                        request.AddParameter("application/json; charset=utf-8", jsonObject, ParameterType.RequestBody);
                        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                        var response = client.Execute(request);
                        if (response.IsSuccessful)
                        {
                            var message = i+". "+"Page created successfully with Title: " + pageTitle;
                            listBox1.Items.Add(message);
                            Log.Information(message);
                        }
                    }
                    catch (Exception ex)
                    {
                        var message = "Page creation failed with Title: " + _pageTitle;
                        listBox1.Items.Add(message);
                        Log.Error(ex, message);
                    }
                }
            }
            catch (Exception ex)
            {
                var message = "Unable to create pages in space key: " + txtSpaceKey.Text;
                listBox1.Items.Add(message);
                Log.Error(ex, message);
            }
        }
    }
}