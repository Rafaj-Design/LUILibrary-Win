using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Path.

namespace LiveUI.Networking
{
    class Headers
    {

        public void addHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Device
            client.DefaultRequestHeaders.Add("", "");

            // OS
        }

    }
}
