using Auto_Check_Oder_Amazon.controller.api.dolphin_anty;
using Auto_Check_Oder_Amazon.model.Login;
using Auto_Check_Oder_Amazon.view.dashbroad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.controller
{
    public class DashbroadController
    {
        public async Task<List<DataItemProfile>> GetDataProfiles(int page, int limit)
        {
            try
            {
                Dolphin dolphin_api = new Dolphin();
                var response = await dolphin_api.GetListBrowser(LoginData.Token, page, limit);
                var resConvert = JsonConvert.DeserializeObject<ResponseListProfile>(response);

                List<DataItemProfile> dataItemProfiles = new List<DataItemProfile>();
                foreach (var itemProfile in resConvert.data)
                {
                    DataItemProfile item = new DataItemProfile
                    {
                        ID_Profile = itemProfile.id.ToString(),
                        Name = itemProfile.name,
                        Platform = itemProfile.platform,
                        MainWebsite = itemProfile.mainWebsite
                    };
                    dataItemProfiles.Add(item);
                }
                return dataItemProfiles;
            }
            catch (Exception ex)
            {
                return new List<DataItemProfile>();
            }
        }

    }
}
