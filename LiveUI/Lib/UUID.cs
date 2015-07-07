using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveUI.Lib
{
    class UUID
    {

        public static string toString()
        {
            string UUID = Refractored.Xam.Settings.CrossSettings.Current.GetValueOrDefault("LiveUI.UUID", "");
            if (UUID == null || UUID.Length == 0)
            {
                UUID = Guid.NewGuid().ToString("D");
                Refractored.Xam.Settings.CrossSettings.Current.AddOrUpdateValue("LiveUI.UUID", UUID);
            }
            return UUID;
        }

    }
}
