using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace parlem.common.Config
{
    public class Config
    {
        public static IConfiguration Configuration;

        public static string GetConfig(string key)
        {         
            return Configuration.GetValue<string>(key);
        }
    }
}
