using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    internal class Pessoa
    {
       public string nomePessoa;
       public double pesoPessoa;
        

        public Pessoa (string nomePessoa, double peso)
        {
            this.nomePessoa= nomePessoa;
            this.pesoPessoa = peso;
        }


    }
}
