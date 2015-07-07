using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUI.Translations
{
    class Translations
    {

        private static volatile Translations instance;
        private static object syncRoot = new Object();

        private Translations() { }

        public static Translations Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Translations();
                        }
                    }
                }

                return instance;
            }
        }

        public void update()
        {

        }

    }
}
