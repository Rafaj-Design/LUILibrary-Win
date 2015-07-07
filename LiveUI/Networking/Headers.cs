using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace LiveUI.Networking
{
    class Headers
    {

        public void addHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Device
            client.DefaultRequestHeaders.Add("X-Platform", DeviceInfo.Plugin.CrossDeviceInfo.Current.Platform.ToString());
            client.DefaultRequestHeaders.Add("X-DeviceModel", DeviceInfo.Plugin.CrossDeviceInfo.Current.Model.ToString());
            client.DefaultRequestHeaders.Add("X-OsVersion", DeviceInfo.Plugin.CrossDeviceInfo.Current.Version.ToString());

            // API
            client.DefaultRequestHeaders.Add("X-ApiVersion", "1.0");
            
            // Environment
            client.DefaultRequestHeaders.Add("X-AppUUID", LiveUI.Lib.UUID.toString());
            client.DefaultRequestHeaders.Add("X-AppVersion", Version.Plugin.CrossVersion.Current.Version);

            client.DefaultRequestHeaders.Add("X-DeviceBatteryStatus", Battery.Plugin.CrossBattery.Current.Status.ToString());
            client.DefaultRequestHeaders.Add("X-DeviceBatteryLevel", Battery.Plugin.CrossBattery.Current.RemainingChargePercent.ToString());
            //client.DefaultRequestHeaders.Add("X-XXXXXXXX", Connectivity.Plugin.CrossConnectivity.Current.);
            client.DefaultRequestHeaders.Add("X-XXXXXXXX", Version.Plugin.CrossVersion.Current.Version);
            client.DefaultRequestHeaders.Add("X-XXXXXXXX", Version.Plugin.CrossVersion.Current.Version);
            client.DefaultRequestHeaders.Add("X-XXXXXXXX", Version.Plugin.CrossVersion.Current.Version);
        }

    }
}
