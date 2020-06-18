using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models.Entities;
using WebApi.Models.ModelView;

namespace WebApi.Models.Dao
{
    public interface IContainer
    {
        public IFactory<CategoryMv> CategoryFactory { get; }

    }
}
