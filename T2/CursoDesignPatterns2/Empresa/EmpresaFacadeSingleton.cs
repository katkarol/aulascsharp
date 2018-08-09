using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Empresa
{
    class EmpresaFacadeSingleton
    {
        private static Servico instancia = new Servico();

        public Servico Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
