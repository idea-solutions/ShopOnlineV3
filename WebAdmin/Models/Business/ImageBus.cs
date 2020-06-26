using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WebAdmin.Models.ApiService;
using WebAdmin.Models.ModelView;

namespace WebAdmin.Models.Business
{
    public class ImageBus
    {
        private const string ModelName = "/api/ImageProduct";

        internal async static Task<bool> PostImage(ImageMv imageProduct)
        {
            var res = await ServiceApi.PostData<ImageMv>(ModelName, imageProduct);
            return res.StatusCode == HttpStatusCode.Created;
        }
    }

}

