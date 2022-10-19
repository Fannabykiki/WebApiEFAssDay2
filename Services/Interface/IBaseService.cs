using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEFAssDay1.Services.Interface
{
   public interface IBaseService<T, K> where T : class where K : class
{
    T Create(K createModel);
    T Update(K updateModel);
    T Delete(K deleteModel);
}
}