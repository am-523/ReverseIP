using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace Reverse_IPs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private readonly HttpClient httpClient = new HttpClient();
        private const string ApiUrl = "https://api.rostovabrothers.com/api?ip=";

        private void InitializeListView()
        {
            lvResults.View = View.Details;
            lvResults.Columns.Add("IP Address", 150);
            lvResults.Columns.Add("Domain Count", 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async Task ScanIpsAsync(string[] ips, int threads)
        {
            await Task.WhenAll(Array.ConvertAll(ips, ip => ReverseIp(ip, threads)));
        }
        private async Task ReverseIp(string ip, int threads)
        {
            string url = ApiUrl + ip;
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeAnonymousType(responseBody, new { status = 0, message = "", result = new List<string>() });
                if (data.status == 200)
                {
                    var domains = data.result;
                    if (domains.Count > 0)
                    {
                        using (var writer = new StreamWriter("results.txt", append: true))
                        {
                            foreach (var domain in domains)
                            {
                                writer.WriteLine(domain);
                            }
                        }
                        int count = domains.Count;
                        UpdateListView(ip, count);
                    }
                    else
                    {
                        tbResults.AppendText($"IP [ {ip.Trim()} ] Doesn't have domains\n");
                    }
                }
                else
                {
                    tbResults.AppendText($"IP [ {ip.Trim()} ] API returned an error - {data.message}\n");
                }
            }
            catch
            {
                tbResults.AppendText($"IP [ {ip.Trim()} ] Failed to connect to the API, API Host down!\n");
            }
        }
        private void UpdateListView(string ip, int count)
        {
            ListViewItem item = new ListViewItem(ip);
            item.SubItems.Add(count.ToString());
            lvResults.Items.Add(item);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string file_name = tbInputFile.Text.Trim();
            int threads;

            if (!File.Exists(file_name))
            {
                MessageBox.Show($"Error: File '{file_name}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(tbThreads.Text, out threads))
            {
                MessageBox.Show("Error: Threads must be an integer. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateResultsFile();
            lvResults.Items.Clear();
            lbIPs.Items.Clear();

            string[] ips = File.ReadAllLines(file_name);
            lbIPs.Items.AddRange(ips);

            await ScanIpsAsync(ips, threads);

            tbInputFile.Enabled = true; // Enable the text box after the lookup is completed
            button2.Enabled = true;
            MessageBox.Show("Reverse IP Lookup completed!", "Scan Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CreateResultsFile()
        {
            string fileName = "results.txt";
            if (!File.Exists(fileName))
            {
                File.Create(fileName).Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbInputFile.Text = openFileDialog.FileName;
                    button1.Enabled = true;
                }
            }
        }
    }
}