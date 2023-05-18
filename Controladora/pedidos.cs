using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ventas
    {
        private static ventas _instancia;

        private ventas() { }

        public static ventas obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ventas();
            }
            return _instancia;
        }

        public List<Contexto.Ventas> Listar_Ventas()
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Ventas.ToList();
        }

        public void Agregar_Ventas(Contexto.Ventas ventas)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Ventas.Add(ventas);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Ventas(Contexto.Ventas ventas)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Ventas.Remove(ventas);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public Contexto.Ventas Obtener_Ventas(int CODIGO)
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Ventas.Find(CODIGO);
        }
    }
}
