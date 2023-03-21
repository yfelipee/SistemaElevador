namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador(500, 5);

            Pessoa pessoa = new Pessoa("Giovanna", 64);
            Pessoa pessoa1 = new Pessoa("Gui", 100);
            Pessoa pessoa2 = new Pessoa("Lipe", 63);
            Pessoa pessoa3 = new Pessoa("Erick", 1);
            Pessoa pessoa4 = new Pessoa("Silva", 55);
            
            
            elevador.AdicionarPessoa(pessoa);
            elevador.AdicionarPessoa(pessoa1);
            elevador.AdicionarPessoa(pessoa2);
            elevador.AdicionarPessoa(pessoa3);
            elevador.AdicionarPessoa(pessoa4);

            elevador.FecharPorta();
            elevador.Subir();

            elevador.AndarAtual();
            elevador.Subir();
           
            elevador.AndarAtual();
            elevador.Subir();
            
            elevador.AndarAtual();
            elevador.Subir();
            
            elevador.AndarAtual();
            elevador.Subir();
            elevador.AndarAtual();

            elevador.Subir();
            elevador.AndarAtual();

            elevador.Descer();
            elevador.AndarAtual();



        }
    }
}