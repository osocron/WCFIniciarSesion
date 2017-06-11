using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LanguageExt;

namespace InicioSesion.Repositorios
{
    public class UsuariosRepository : 
        GenericRepository<usuario, long>, 
        IRepository<usuario, long>
    {
        private readonly dbcabEntities _db = new dbcabEntities();

        public List<usuario> GetAll()
        {
            return GetAll(_db.usuarios);
        }

        public Option<usuario> GetById(long id)
        {
            return GetById(_db.usuarios, id);
        }

        public List<usuario> GetByQuery(Func<usuario, bool> query)
        {
            return GetByQuery(_db.usuarios, query);
        }

        public Try<int> Update(usuario e)
        {
            return Update(_db, _db.usuarios, e, e.IdUsuario, (current, that) =>
            {
                current.Usuario1 = that.Usuario1;
                current.Contrasenia = that.Contrasenia;
                current.UltimoAcceso = that.UltimoAcceso;
            });
        }

        public Try<int> Insert(usuario e)
        {
            return Insert(_db, _db.usuarios, e);
        }

        public Try<int> Delete(long id)
        {
            return Delete(_db, _db.usuarios, id);
        }
    }
}