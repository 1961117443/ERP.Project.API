using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Project.Common.Helper
{
    public static class ApiHelper
    {
        /// <summary>
        /// 发送get请求
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string Get(string url)
        {
            HttpClient httpClient = new HttpClient();
            string context = "";
            try
            {
                var httpResponse = httpClient.GetAsync(url).Result;
              //  httpResponse.EnsureSuccessStatusCode();
                context = httpResponse.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return context;
        }
        /// <summary>
        /// 发送post请求
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="data">发送的数据</param>
        /// <returns></returns>
        public static string Post(string url,string data)
        {
            using (HttpClient httpClient = new HttpClient())
            { 
                string context = "";
                try
                {
                    HttpContent httpContent = new StringContent(data);
                    httpContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                    var httpResponse = httpClient.PostAsync(url, httpContent).Result;
                   // httpResponse.EnsureSuccessStatusCode();
                    context = httpResponse.Content.ReadAsStringAsync().Result;
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }

                return context;
            }
        }
    }
}
