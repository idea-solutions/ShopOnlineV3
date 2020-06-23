using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebAdmin.Models.ApiService;
using WebAdmin.Models.ModelView;

namespace WebAdmin.Models.Business
{
    public class TypeProductBus
    {
        private const string ModelName = "/api/TypeCategory";

        public static async Task<List<TypeProductMv>> GetAll()
        {
            var res = ServiceApi.GetData(ModelName).Result;
            return res.StatusCode == HttpStatusCode.OK ?  JsonConvert.DeserializeObject<List<TypeProductMv>>(res.Content.ReadAsStringAsync().Result) : null;
        }
    }
}
