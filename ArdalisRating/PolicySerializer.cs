using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArdalisRating
{
    public class PolicySerializer
    {
        public Policy getPolicyFromJsonString(string jsonFile)
        {
            return JsonConvert.DeserializeObject<Policy>(jsonFile,
                new StringEnumConverter());
        }
    }
}
