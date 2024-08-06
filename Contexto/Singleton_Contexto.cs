using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contexto
{
    public class Singleton_Contexto
    {
        private static Singleton_Contexto _instancia;
        private static readonly object _lock = new object();
        private static ContextoContainer _contexto;

        private Singleton_Contexto() { }

        public static Singleton_Contexto obtener_instancia()
        {
            if (_instancia == null)
            {
                lock (_lock)
                {
                    if (_instancia == null)
                    {
                        _instancia = new Singleton_Contexto();
                        _contexto = new ContextoContainer();
                    }
                }
            }
            return _instancia;
        }

        public ContextoContainer Contexto
        {
            get { return _contexto; }
        }
    }
}
