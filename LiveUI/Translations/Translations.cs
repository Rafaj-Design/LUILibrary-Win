using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUI.Translations
{
    class Translations
    {

        static Translations()
        {
            Translations.Instance = new Translations();
        }

        public static Translations Instance
        {
            get;
            private set;
        }

    }
}
