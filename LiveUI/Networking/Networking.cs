using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace LiveUI.Networking
{
    class Networking
    {

        public string apiUrl = "http://api.liveui.io/";
        public string imagesUrl = "http://images.liveui.io/";

        public void getApiAsync(string urlPath, HttpCompletionOption completionOption, string post=null)
        {
            HttpClient client = new HttpClient();

            if (post != null)
            {
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, urlPath);
                request.Content = new StringContent(post, Encoding.UTF8, "application/json");

                client.SendAsync(request, completionOption);
            }
            else
            {
                Uri uri = new Uri(new Uri(this.apiUrl), new Uri(urlPath));
                client.GetAsync(uri, completionOption);
            }
            
        }

    }
}
