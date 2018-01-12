using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public class Individuo
    {
        public string Nome, SobreNome;
        public double Peso, Altura;

        public Individuo(String pn, String sn, double p, double a)
        {
            this.Nome = pn;
            this.SobreNome = sn;
            this.Peso = p;
            this.Altura = a;
        }

        public double Imc()
        {
            return Peso / (Altura * Altura);
        }

    }

}
