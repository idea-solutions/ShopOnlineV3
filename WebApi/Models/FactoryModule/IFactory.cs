using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.FactoryModule{
    public interface IFactory<T> where T : class
    {
        Task<List<T>> GetAll();
        T GetById(object id);
        T CreateNew(T data);
        bool Update(object id, T data);
        bool Delete(object id);
    }

}
