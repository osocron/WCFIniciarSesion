using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using InicioSesion.Repositorios;

namespace InicioSesion.Auth
{
    public class ServiceAuthenticator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            var usuariosRepo = new UsuariosRepository();
            if (string.IsNullOrEmpty(userName))
                throw new ArgumentNullException("Empty UserName");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("Empty Password");

            var user = usuariosRepo.GetByQuery(u => u.Usuario1 == userName && u.Contrasenia == password);
            if (!user.Any())
                throw new SecurityTokenException("Usuario no encontrado");
        }
    }
}