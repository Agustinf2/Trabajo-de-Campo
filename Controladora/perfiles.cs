using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class perfiles
    {
        private static perfiles _instancia;

        private perfiles() { }

        public static perfiles obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new perfiles();
            }
            return _instancia;
        }

        public List<Contexto.Perfil> Listar_Perfiles()
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Perfiles.ToList();
        }

        public void Llenar_Lista_Perfiles(List<Contexto.Perfil> perfiles)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Perfiles.AddRange(perfiles);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
    }
}
