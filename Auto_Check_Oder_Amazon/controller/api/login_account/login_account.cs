using Auto_Check_Oder_Amazon.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller.api.login_account
{
    public class API_login_account
    {
        public async static Task<string> Login(string gmail,string pass)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var requestBody = new
                    {
                        username = "mariuszwojtkielewicz064@gmail.com",
                        password = "cuquki-zaxid-pokomy",
                        captcha = (string)null
                    };

                    string json = JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    //client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en,vi;q=0.9,vi-VN;q=0.8,fr-FR;q=0.7,fr;q=0.6,en-US;q=0.5,zh-CN;q=0.4,zh;q=0.3");
                    client.DefaultRequestHeaders.Add("Connection", "keep-alive");
                    client.DefaultRequestHeaders.Add("Origin", Url_base.URL_BASE);
                    client.DefaultRequestHeaders.Add("Referer", Url_base.URL_BASE);
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "cross-site");
                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/134.0.0.0 Safari/537.36");
                    client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"134\", \"Not:A-Brand\";v=\"24\", \"Google Chrome\";v=\"134\"");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");

                    HttpResponseMessage response = await client.PostAsync(Url_base.URL_BASE + Url_base.LOGIN_ACCOUNT, content);

                    string responseString = await response.Content.ReadAsStringAsync();
                    return responseString;
                }
            }
            catch (Exception ex) { 
                return null;
            }
        }
    }
}
