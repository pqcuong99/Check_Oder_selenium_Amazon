using Auto_Check_Oder_Amazon.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller.api.dolphin_anty
{
    public class Dolphin
    {
        public async Task<string> GetListBrowser(string token,int page = 1, int limit = 100)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
                    client.DefaultRequestHeaders.Add("accept-language", "en-US");
                    client.DefaultRequestHeaders.Add("authorization", $"Bearer {token}");
                    client.DefaultRequestHeaders.Add("priority", "u=1, i");
                    client.DefaultRequestHeaders.Add("referer", "https://dolphin-anty-cdn.com/");
                    client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not?A_Brand\";v=\"99\", \"Chromium\";v=\"130\"");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                    client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
                    client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
                    client.DefaultRequestHeaders.Add("sec-fetch-site", "cross-site");

                    HttpResponseMessage response = await client.GetAsync(Url_base.URL_BASE_DOLPHIN + Url_base.GET_LIST_BROWSER_PROFILE + $"page={page}&limit={limit}");

                    string responseString = await response.Content.ReadAsStringAsync();
                    return responseString;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<string> EventStartBrowser(string token, int browser_id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
                    client.DefaultRequestHeaders.Add("accept-language", "en-US");
                    client.DefaultRequestHeaders.Add("authorization", $"Bearer {token}");
                    client.DefaultRequestHeaders.Add("priority", "u=1, i");
                    client.DefaultRequestHeaders.Add("referer", "https://dolphin-anty-cdn.com/");
                    client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not?A_Brand\";v=\"99\", \"Chromium\";v=\"130\"");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                    client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
                    client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
                    client.DefaultRequestHeaders.Add("sec-fetch-site", "cross-site");

                    using (var request = new HttpRequestMessage(HttpMethod.Post, $"{Url_base.URL_BASE_DOLPHIN}browser_profiles/{browser_id}/events"))
                    {
                        request.Content = new StringContent("{\"type\":\"start\"}", Encoding.UTF8, "application/json"); ; // Đảm bảo stringContent được khai báo đúng kiểu
                        using (HttpResponseMessage response = await client.SendAsync(request))
                        {
                            if (!response.IsSuccessStatusCode)
                            {
                                Console.WriteLine($"Request failed: {response.StatusCode}");
                            }
                            return await response.Content.ReadAsStringAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<string> StartBrowser(string token,int browser_id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                    client.DefaultRequestHeaders.Add("Accept-Language", "en-US");
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                    client.DefaultRequestHeaders.Add("Connection", "keep-alive");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                    client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "cross-site");
                    client.DefaultRequestHeaders.Add("User-Agent", "dolphin_anty_2025.152.125_Windows_NT");
                    client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not?A_Brand\";v=\"99\", \"Chromium\";v=\"130\"");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                    client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");

                    string url = $"{Url_base.URL_BASE_DOLPHIN}/browser_profiles/{browser_id}/start?screenWidth=1920&screenHeight=1080&dpr=1&mainWebsite=&login=&password=";

                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            Console.WriteLine($"Request failed: {response.StatusCode}");
                            return null;
                        }
                        else
                        {
                            string responseString = await response.Content.ReadAsStringAsync();
                            return responseString;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<string> StopBrowser(string token, int browser_id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                client.DefaultRequestHeaders.Add("Accept-Language", "en-US");
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                client.DefaultRequestHeaders.Add("Connection", "keep-alive");
                client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
                client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
                client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "cross-site");
                client.DefaultRequestHeaders.Add("User-Agent", "dolphin_anty_2025.152.125_Windows_NT");
                client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Not?A_Brand\";v=\"99\", \"Chromium\";v=\"130\"");
                client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");

                string url = $"{Url_base.URL_BASE_DOLPHIN}/browser_profiles/{browser_id}/stop";

                try
                {
                    using (HttpResponseMessage response = await client.GetAsync(url))
                    {
                        if (!response.IsSuccessStatusCode)
                        {
                            Console.WriteLine($"Request failed: {response.StatusCode}");
                            return null;
                        }
                        else
                        {
                            string responseString = await response.Content.ReadAsStringAsync();
                            return responseString;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
