using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.view.dashbroad
{
    public class DataItemProfile
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string ID_Profile { get; set; }
        public string MainWebsite { get; set; }
    }

    public class ResponseListProfile
    {
        public int current_page { get; set; }
        public Datum[] data { get; set; }
        public string first_page_url { get; set; }
        public int from { get; set; }
        public object next_page_url { get; set; }
        public string path { get; set; }
        public string per_page { get; set; }
        public object prev_page_url { get; set; }
        public int to { get; set; }
        public int last_page { get; set; }
        public int total { get; set; }
    }

    public class Datum
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int teamId { get; set; }
        public string name { get; set; }
        public string platform { get; set; }
        public string browserType { get; set; }
        public int proxyId { get; set; }
        public string mainWebsite { get; set; }
        public Useragent useragent { get; set; }
        public Webrtc webrtc { get; set; }
        public Canvas canvas { get; set; }
        public Webgl webgl { get; set; }
        public Webglinfo webglInfo { get; set; }
        public Clientrect clientRect { get; set; }
        public Notes notes { get; set; }
        public Timezone timezone { get; set; }
        public Locale locale { get; set; }
        public int totalSessionDuration { get; set; }
        public string userFields { get; set; }
        public Geolocation geolocation { get; set; }
        public bool doNotTrack { get; set; }
        public object[] args { get; set; }
        public Cpu cpu { get; set; }
        public Memory memory { get; set; }
        public Screen screen { get; set; }
        public Ports ports { get; set; }
        public string tabs { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string deleted_at { get; set; }
        public string platformName { get; set; }
        public string cpuArchitecture { get; set; }
        public string osVersion { get; set; }
        public string screenWidth { get; set; }
        public string screenHeight { get; set; }
        public int connectionDownlink { get; set; }
        public string connectionEffectiveType { get; set; }
        public int connectionRtt { get; set; }
        public int connectionSaveData { get; set; }
        public string vendorSub { get; set; }
        public string productSub { get; set; }
        public string vendor { get; set; }
        public string product { get; set; }
        public string appCodeName { get; set; }
        public Mediadevices mediaDevices { get; set; }
        public object datadirHash { get; set; }
        public object cookiesHash { get; set; }
        public string storagePath { get; set; }
        public string platformVersion { get; set; }
        public int extensionsNewNaming { get; set; }
        public int archived { get; set; }
        public string webgl2Maximum { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string sortingName { get; set; }
        public int addedSortingName { get; set; }
        public Access access { get; set; }
        public int transfer { get; set; }
        public Webgpu webgpu { get; set; }
        public string recoverCount { get; set; }
        public string lastStartTime { get; set; }
        public Proxy proxy { get; set; }
        public string sorting_name { get; set; }
        public Macaddress macAddress { get; set; }
        public Devicename deviceName { get; set; }
        public int isHiddenProfileName { get; set; }
        public Audio audio { get; set; }
        public object[] tags { get; set; }
        public object[] tags_with_separator { get; set; }
        public bool pinned { get; set; }
        public string folder { get; set; }
        public object transferToEmail { get; set; }
        public object transferStatus { get; set; }
        public object transferHandleDate { get; set; }
        public object transferWithProxy { get; set; }
        public object[] homepages { get; set; }
    }

    public class Useragent
    {
        public string mode { get; set; }
        public string value { get; set; }
    }

    public class Webrtc
    {
        public string mode { get; set; }
        public object ipAddress { get; set; }
    }

    public class Canvas
    {
        public string mode { get; set; }
        public int[] noise { get; set; }
    }

    public class Webgl
    {
        public string mode { get; set; }
        public int[] noise { get; set; }
    }

    public class Webglinfo
    {
        public string mode { get; set; }
        public string vendor { get; set; }
        public string renderer { get; set; }
    }

    public class Clientrect
    {
        public string mode { get; set; }
        public float[] noise { get; set; }
    }

    public class Notes
    {
        public string content { get; set; }
        public string color { get; set; }
        public string style { get; set; }
        public string icon { get; set; }
    }

    public class Timezone
    {
        public string mode { get; set; }
        public object value { get; set; }
    }

    public class Locale
    {
        public string mode { get; set; }
        public object value { get; set; }
    }

    public class Geolocation
    {
        public string mode { get; set; }
        public object latitude { get; set; }
        public object longitude { get; set; }
    }

    public class Cpu
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Memory
    {
        public string mode { get; set; }
        public int value { get; set; }
    }

    public class Screen
    {
        public string mode { get; set; }
        public string resolution { get; set; }
    }

    public class Ports
    {
        public string mode { get; set; }
        public string blacklist { get; set; }
    }

    public class Mediadevices
    {
        public string mode { get; set; }
        public int audioInputs { get; set; }
        public int videoInputs { get; set; }
        public int audioOutputs { get; set; }
    }

    public class Access
    {
        public int view { get; set; }
        public int update { get; set; }
        public int delete { get; set; }
        public int share { get; set; }
        public int usage { get; set; }
    }

    public class Webgpu
    {
        public string mode { get; set; }
        public string value { get; set; }
    }

    public class Proxy
    {
        public int id { get; set; }
        public string name { get; set; }
        public string host { get; set; }
        public string type { get; set; }
        public Lastcheck lastCheck { get; set; }
    }

    public class Lastcheck
    {
        public int status { get; set; }
        public string ip { get; set; }
        public string country { get; set; }
        public int found { get; set; }
        public int total { get; set; }
        public object[] blacklists { get; set; }
        public string createdAt { get; set; }
    }

    public class Macaddress
    {
        public string mode { get; set; }
        public string value { get; set; }
    }

    public class Devicename
    {
        public string mode { get; set; }
        public string value { get; set; }
    }

    public class Audio
    {
        public string mode { get; set; }
    }

}
