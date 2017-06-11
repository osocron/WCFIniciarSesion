using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using InicioSesion.Entities.WebResults;
using InicioSesion.Repositorios;

namespace InicioSesion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public ServiceResponse Autenticar(string usuario, string password)
        {
            var usuariosRepo = new UsuariosRepository();
            var user = usuariosRepo.GetByQuery(u => u.Usuario1 == usuario && u.Contrasenia == password);
            if (user.Any())
            {
                return new ServiceResponse()
                {
                    Error = false,
                    Message = "Usuario encontrado"
                };
            }
            else
            {
                return new ServiceResponse()
                {
                    Error = true,
                    Message = "Credenciales no encontradas"
                };
            }
        }
    }
}
