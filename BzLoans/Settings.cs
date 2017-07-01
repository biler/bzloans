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
        [DefaultSettingValue(".\\SQLEXPRESS")]
        public String db_host
        {
            get => (String)this["db_host"];
            set
            {
                this["db_host"] = value;
            }
        }

        [ApplicationScopedSetting()]
        [DefaultSettingValue("bzloans")]
        public String db_name
        {
            get => (String)this["db_name"];
            set
            {
                this["db_name"] = value;
            }
        }

        [ApplicationScopedSetting()]
        [DefaultSettingValue("bzloans")]
        public String db_username
        {
            get => (String)this["db_username"];
            set
            {
                this["db_username"] = value;
            }
        }

        [ApplicationScopedSetting()]
        [DefaultSettingValue("bzloans")]
        public String db_password
        {
            get => (String)this["db_password"];
            set
            {
                this["db_password"] = value;
            }
        }
    }
}
