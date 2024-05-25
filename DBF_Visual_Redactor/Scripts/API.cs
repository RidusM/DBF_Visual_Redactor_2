using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_Visual_Redactor
{
    internal class API
    {
        public Task<string> CheckConnection(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                var response = httpClient.GetAsync("heartbeat").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }
        public Task<string> GetUsers(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                httpClient.DefaultRequestHeaders.TransferEncodingChunked = true;
                var response = httpClient.GetAsync("new/users").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public Task<string> GetWarehous(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                var response = httpClient.GetAsync("/new/warehous").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        public Task<string> GetFolders(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                httpClient.DefaultRequestHeaders.TransferEncodingChunked = true;
                var response = httpClient.GetAsync("/new/folders").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        public Task<string> GetPrevUsers(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                httpClient.DefaultRequestHeaders.TransferEncodingChunked = true;
                var response = httpClient.GetAsync("current/users").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        public Task<string> GetPrevWarehous(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                var response = httpClient.GetAsync("/previous/warehous").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        public Task<string> GetPrevFolders(string host, string port)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                httpClient.DefaultRequestHeaders.TransferEncodingChunked = true;
                var response = httpClient.GetAsync("/previous/folders").Result;
                string result = response.Content.ReadAsStringAsync().Result;
                return Task.FromResult(result);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        public void PostFolders(string host, string port, string strJson)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                var content = new StringContent(strJson, Encoding.UTF8, "application/json");
                httpClient.PostAsync("/current/folders", content);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
        public void PostWarehous(string host, string port, string strJson)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                var content = new StringContent(strJson, Encoding.UTF8, "application/json");
                httpClient.PostAsync("/current/warehous", content);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }
        public void PostUsers(string host, string port, string strJson)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri($"http://{host}:{port}/");
                var content = new StringContent(strJson, Encoding.UTF8, "application/json");
                httpClient.PostAsync("/current/users", content);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
