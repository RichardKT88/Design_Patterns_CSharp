using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ISS : TemplateDeImpostoCondicional
    {
        public ISS(Imposto outroImposto) : base(outroImposto)
        {
        }

        public ISS() : base()
        {
        }

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return true;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            throw new NotImplementedException();
        }
    }
}
