using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LanguageExt;
using static LanguageExt.Prelude;

namespace InicioSesion.Repositorios
{
    /// <summary>
    /// 
    /// Clase base para los repositorios. Tiene como finalidad reducir la duplicacion
    /// de codigo.
    /// 
    /// Se usan tipos de datos que se encuentran LanguageExt tales como <c>Try<T></c>
    /// y <c>Option<T></c> https://github.com/louthy/language-ext
    /// 
    /// </summary>
    /// <typeparam name="TEntity">
    /// La entidad generada por EntityFramework de la tabla deseada.
    /// </typeparam>
    /// 
    /// <typeparam name="TKey">
    /// El tipo de dato de la PrimaryKey de la tabla.
    /// </typeparam>
    public class GenericRepository<TEntity, TKey> where TEntity : class
    {
        public List<TEntity> GetAll(DbSet<TEntity> dbSet)
        {
            return dbSet.ToList();
        }

        public Option<TEntity> GetById(DbSet<TEntity> dbSet, TKey id)
        {
            return dbSet.Find(id);
        }

        public Try<int> Insert(dbcabEntities db, DbSet<TEntity> dbSet, TEntity e)
        {
            dbSet.Add(e);
            return () => db.SaveChanges();
        }

        public Try<int> Update(dbcabEntities db, DbSet<TEntity> dbSet, TEntity toUpdate, TKey id, Action<TEntity, TEntity> updateAction)
        {
            Try<int> UpdateEntity(TEntity current, TEntity that)
            {
                updateAction(current, that);
                return () => db.SaveChanges();
            }
            return GetById(dbSet, id)
                .Some(current => UpdateEntity(current, toUpdate))
                .None(() => (() => 0));
        }

        public Try<int> Delete(dbcabEntities db, DbSet<TEntity> dbSet, TKey id)
        {
            return GetById(dbSet, id)
                .Some(e => Try(() =>
                    {
                        dbSet.Remove(e);
                        return db.SaveChanges();
                    }
                ))
                .None(() => Try(() => 0));
        }

        public List<TEntity> GetByQuery(DbSet<TEntity> dbSet, Func<TEntity, bool> query)
        {
            return dbSet.Where(query).ToList();
        }


    }
}