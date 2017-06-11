using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion.Repositorios
{
    internal interface IRepository<TEntity, in TKey>
    {
        List<TEntity> GetAll();
        Option<TEntity> GetById(TKey id);
        List<TEntity> GetByQuery(Func<TEntity, Boolean> query);
        Try<int> Update(TEntity e);
        Try<int> Insert(TEntity e);
        Try<int> Delete(TKey id);
    }
}
