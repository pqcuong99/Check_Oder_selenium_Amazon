using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.model.Login
{

    public class Response_login_account
    {
        public string token { get; set; }
        public string refresh_token { get; set; }
        public int expires { get; set; }
        public string refresh_token_expiration_time { get; set; }
    }

}
