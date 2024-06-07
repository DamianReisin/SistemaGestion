using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;
namespace SistemaGestionBussiness
{
    public class UsuarioBussines
    {
        public static List<Usuario> ObtenerUsuario(int usuarioData)
        {
            return UsuarioData.ObtenerUsuarioData(usuarioData);
        }

        public static List<Usuario> ListarUsuarios() 
        {
            return UsuarioData.ListarUsuarioData();
        }
        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuarioData(usuario);
        }
        public static void EliminarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }
        public static void ModificarUsuario(Usuario usuario) 
        {
            UsuarioData.ModificarUsuario(usuario);
        }
    }
}
