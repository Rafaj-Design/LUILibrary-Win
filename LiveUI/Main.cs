using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUI
{
    public class Main
    {

        public string apiKey { get; set; } = null;

        public void update()
        {
            if (this.apiKey != null && this.apiKey.Length > 0)
            {
                Translations.Translations.Instance.update();
            }
            else
            {
                throw new Exception("LiveUI API key has not been set!");
            }
        }

    }
}
