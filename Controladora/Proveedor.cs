using Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class Proveedor
    {
        private static Proveedor _instancia;

        private Proveedor() { }

        public static Proveedor obtener_instancia()
        {
            if (_instancia == null)
            {
                _instancia = new Proveedor();
            }
            return _instancia;
        }

        public List<Contexto.Proveedores> Listar_Usuarios()
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Proveedores.ToList();
        }

        public void Agregar_Proveedor(Contexto.Proveedores proveedores)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Proveedores.Add(proveedores);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public void Eliminar_Proveedor(Contexto.Proveedores proveedores)
        {
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.Proveedores.Remove(proveedores);
            Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
        }
        public Contexto.Proveedores Obtener_Proveedor(int CODIGO)
        {
            return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Proveedores.Find(CODIGO);
        }
    }
}