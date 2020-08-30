using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Dapper;
using PracticaWeb.Models;

namespace PracticaWeb.Clases
{
    public class MetodosUsuario:DBConexion
    {
        public bool ValidarUsuario(string NombreUsuario, string Clave)
        {
            var usuario = this.Conection.Query<Usuario>("Validar_Usuario",new { @NombreC= NombreUsuario, @ClaveC=Clave }, commandType: CommandType.StoredProcedure);
            if (usuario.ToList().Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //verificar si el nombre de ussuario esta en uso
        public bool VerificarUsuario(string NombreU)
        {
            var usuario = this.Conection.Query<Usuario>("Verificar_Usuario", new { @NombreUsuario = NombreU}, commandType: CommandType.StoredProcedure);
            if(usuario.ToList().Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RegistrarUsuario(Usuario UsuarioData)
        {
            
             var respuesta = this.Conection.Execute("Registrar_Usuario", new { @Nombre= UsuarioData.Nombre, @NombreUsuario = UsuarioData.NombreUsuario, @Apellido= UsuarioData.Apellido, @Clave= UsuarioData.Clave }, commandType: CommandType.StoredProcedure);
            if (respuesta > 0)
            {
                return true;
            }
            else { return false; }

        }

        public Usuario ObtenerUsuario(string NombreUsuario)
        {
            var usuario = this.Conection.Query<Usuario>("Verificar_Usuario", new { @NombreUsuario = NombreUsuario }, commandType: CommandType.StoredProcedure).FirstOrDefault();
           
            if(usuario != null)
            {
                return usuario;
            }
            else
            {
                return null;
            }
        }

        public void EditarPerfil(int IdUsuario, string nombre, string apellido)
        {
            this.Conection.Query<Usuario>("Editar_Perfil", new { @Id=IdUsuario, @Nombre=nombre , @Apellido=apellido }, commandType: CommandType.StoredProcedure);
         
        }
    }
}