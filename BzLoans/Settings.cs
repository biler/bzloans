using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BzLoans
{
    class Settings : ApplicationSettingsBase
    {
        [ApplicationScopedSetting()]
        [DefaultSettingValue("127.0.0.1")]
        public String db_host
        {
            get => (String) this["db_host"];
            set
            {
                this["db_host"] = value;
            }
        }
    }
}
