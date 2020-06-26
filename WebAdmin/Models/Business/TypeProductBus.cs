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
        private const string ModelName = "/api/TypeProduct";

        public static async Task<List<TypeProductMv>> GetAll()
        {
            var res = await ServiceApi.GetData(ModelName);
            return res.StatusCode == HttpStatusCode.OK 
                ?  JsonConvert.DeserializeObject<List<TypeProductMv>>(res.Content.ReadAsStringAsync().Result) : null;
        }

        internal static async Task<ProductMv> GetByProductIdAsync(Guid id)
        {
            var res = await ServiceApi.GetDataById(ModelName + "/GetByProductId", id);
            return res.StatusCode == HttpStatusCode.OK ? JsonConvert.DeserializeObject<ProductMv>(res.Content.ReadAsStringAsync().Result) : null;
        }

        internal static async Task<bool> CreateNewTypeProductBusAsync(TypeProductMv typeProduct)
        {
            var res = await ServiceApi.PostData<TypeProductMv>(ModelName ,typeProduct);
            return res.StatusCode == HttpStatusCode.Created;
        }
    }
}
