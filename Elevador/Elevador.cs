using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Elevador
{
    internal class Elevador
    {
        public bool portaAberta;
        public double pesoElevador;
        public int andarAtual;
        public int pesoMax;
        public int andarMax;
        public Elevador( int pesoMax, int andarMax)
        {
            
            this.pesoMax = pesoMax;
            this .andarMax = andarMax;
             portaAberta = true;
             pesoElevador = 0;
             andarAtual = 0;


        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"{pessoa.nomePessoa} Entrou!");
            pesoElevador += pessoa.pesoPessoa;
        }


        public void Subir()
        {
            if (portaAberta == false && pesoElevador <= pesoMax && andarAtual < andarMax) 
            {
                andarAtual ++;
                Console.WriteLine("O Elevador Subiu!!");

            }
            else
            {
                Console.WriteLine("O Elevador Não Subiu!");
            }
            
        }

        public  void Descer()
        {
            if (portaAberta == false && pesoElevador <= pesoMax && andarAtual <= andarMax) 

            {
                andarAtual--;
                Console.WriteLine("O Elevador Desceu!");
            }

        }

        public void PortaAberta()
        {
            if (portaAberta == true)
            {
                Console.WriteLine("A Porta do Elevador Está Aberta");
            }
        }
        public void PortaFechada()
        {
            if (!portaAberta) 
            {
                Console.WriteLine("A porta do Elevador Está Fechada");
            }
        }

        public void AndarAtual()
        {
            Console.WriteLine($"O Andar Atual é:{andarAtual} ");
        }

       
        public void FecharPorta()
        {
            
            Console.WriteLine("A Porta Foi Fechada!");
            portaAberta= false;
        }
    }


   
}
