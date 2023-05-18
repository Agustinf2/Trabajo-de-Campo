using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class usuarios
    {
        private static usuarios _instancia;

        private usuarios() { }

        public static usuarios obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new usuarios();
            }
            return _instancia;
        }

        public List<Contexto.Usuario> Listar_Usuarios()
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.ToList();
        }

        public void Agregar_Usuario(Contexto.Usuario usuario)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.Add(usuario);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Usuario(Contexto.Usuario usuario)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.Remove(usuario);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public Contexto.Usuario Obtener_Usuario(int CODIGO)
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Usuarios.Find(CODIGO);
        }
    }
}
