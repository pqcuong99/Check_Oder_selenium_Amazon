using Auto_Check_Oder_Amazon.controller.api.dolphin_anty;
using Auto_Check_Oder_Amazon.controller.automation.Selenium;
using Auto_Check_Oder_Amazon.model.Dolphin_info;
using Auto_Check_Oder_Amazon.model.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller.automation
{
    public class Script_check_oder
    {
        public async Task<string> StartBrowser(int profile_id)
        {
            try
            {
                Dolphin dolphin = new Dolphin();
                var response = await dolphin.StartBrowserAutomation(LoginData.Token, profile_id);
                if (response != null && response.Contains("success")) {

                    return response;
                }
                return null;
            }
            catch (Exception ex) {
                return null;
            }
        }
        public async Task StartAuto(string wsEndpoint)
        {
            function_auto function_ = new function_auto();
            var webDriver = function_.ConnectWithWsEndpoint(wsEndpoint);
            int dem = 2;
        }
        public async Task StartAuto2(int port)
        {
            function_auto function_ = new function_auto();
            var webDriver = function_.ConnectDriver(port);
            int dem = 2;
        }
    }
}
