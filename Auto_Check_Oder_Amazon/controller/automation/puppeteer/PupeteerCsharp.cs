using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller.automation.puppeteer
{
    public class PupeteerCsharp
    {
        public async Task<IBrowser> ConnectToBrowserAsync()
        {
            var connectOptions = new ConnectOptions
            {
                BrowserURL = "http://127.0.0.1:4000"
            };

            IBrowser browser = await Puppeteer.ConnectAsync(connectOptions);

            return browser;
        }
        public async Task<IBrowser> ConnectToBrowser(string wsEndpoint)
        {
            IBrowser browser = await Puppeteer.ConnectAsync(new ConnectOptions
            {
                BrowserWSEndpoint = wsEndpoint
            });
            return browser; ;
        }
        public async Task<IPage> newPage(IBrowser browser, string url)
        {
            IPage page = await browser.NewPageAsync();
            await page.SetViewportAsync(new ViewPortOptions()
            {
                Width = 1280,
                Height = 720
            });
            page.Request += OnPageRequest;
            page.Response += OnPageReponse;

            await page.GoToAsync(url);
            return page;
        }
        public static async void OnPageRequest(object sender, RequestEventArgs RequestEvent)
        {
            if (RequestEvent.Request.ResourceType == ResourceType.Xhr)
            {
                await RequestEvent.Request.Response.JsonAsync();
                var add = RequestEvent.Request.Response.BufferAsync();
            }
            //await RequestEvent.Request.ContinueAsync();
        }
        public static async void OnPageReponse(object sender, ResponseCreatedEventArgs ResponseEvent)
        {
            var response = ResponseEvent.Response;
            var url = response.Url;
            var status = response.Status;
            if (url == "https://checkip.vip/") // Replace with your desired URL
            {
                var add = ResponseEvent.Response.TextAsync();
                var content = await response.TextAsync();
            }
        }
        public async Task clickXpath(IPage page, string element)
        {
            await page.WaitForXPathAsync(element);
            await page.ClickAsync(element);
        }
        public async Task clickElement(IPage page, string element)
        {
            await page.WaitForSelectorAsync(element);
            await page.ClickAsync(element);
        }
        public async Task inputTextSelector(IPage page, string element, string text)
        {
            IElementHandle inputElement = await page.QuerySelectorAsync(element);
            await inputElement.TypeAsync(text);
        }
        public async Task inputTextXpath(IPage page, string element, string text)
        {
            IElementHandle inputElement = await page.WaitForXPathAsync(element);
            await inputElement.TypeAsync(text);
        }
        public async Task scrollDown(IPage page, int down)
        {
            await page.EvaluateExpressionAsync("window.scrollBy(0," + down + ")");
        }
        public async Task scrollUp(IPage page, int up)
        {
            await page.EvaluateExpressionAsync("window.scrollBy(" + up + ",0)");
        }
        public async Task keyBoard(IPage page, string type)
        {
            await page.Keyboard.PressAsync(type);
        }
        public async Task<string> getTextElementXpath(IPage page, string element)
        {
            IElementHandle elementHandle = await page.WaitForXPathAsync(element);
            var content = await page.EvaluateFunctionAsync<string>("e => e.textContent", elementHandle);
            return content;
        }
        public async Task<string> getTextElementSelector(IPage page, string element)
        {
            IElementHandle elementHandle = await page.WaitForSelectorAsync(element);
            var content = await page.EvaluateFunctionAsync<string>("e => e.textContent", elementHandle);
            return content;
        }
    }
}
