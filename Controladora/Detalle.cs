using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Controladora
{
    public class Detalle
    {
            private static Detalle _instancia;

            private Detalle() { }

            public static Detalle obtener_instancia()
            {
                if (_instancia == null)
                {
                    _instancia = new Detalle();
                }
                return _instancia;
            }

            public List<Contexto.Detalle_ventas> Listar_Detalle()
            {
                return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.ToList();
            }

            public void Agregar_Detalle(Contexto.Detalle_ventas detalle)
            {
                Contexto.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.Add(detalle);
                Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
            }
            public void Eliminar_Ventas(Contexto.Detalle_ventas detalle)
            {
                Contexto.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.Remove(detalle);
                Contexto.Singleton_Contexto.obtener_instancia().Contexto.SaveChanges();
            }
            public Contexto.Detalle_ventas Obtener_Detalle(int CODIGO)
            {
                return Contexto.Singleton_Contexto.obtener_instancia().Contexto.Detalle_ventas.Find(CODIGO);
            }
        }
}
