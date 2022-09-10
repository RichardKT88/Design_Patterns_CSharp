using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens2.Capitulo09
{
    class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return facade;
            }

        }
    }

    /* Solução da aula 09.05
    class Servico
    {

    }

    class ServicoSingleton
    {

        private static Servico servico = new Servico();

        public Servico Instancia
        {
            get
            {
                return servico;
            }

        }
    }

    */
}
