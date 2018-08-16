using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddAll(List<TEntity> entity);
        void Edit(TEntity entity);
        void Delete(TEntity entity);

    }
}
