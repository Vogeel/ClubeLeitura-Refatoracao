using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ConsoleApp
{
    public class TelaCadastroAmigos
    {
        public Amigos[] amigos;
        public int numeroAmigos;
        public Notificador notificador;

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Amigos");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Inserir");
            Console.WriteLine("Digite 2 para Editar");
            Console.WriteLine("Digite 3 para Excluir");
            Console.WriteLine("Digite 4 para Visualizar");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirNovoAmigo()
        {
            MostrarTitulo("Inserindo novo Amigo");

            Amigos amigo = ObterAmigo();

            amigo.numero = ++numeroAmigos;

            int posicaoVazia = ObterPosicaoVazia();
            amigos[posicaoVazia] = amigo;

            notificador.ApresentarMensagem("Amigo Inserido com sucesso!", "Sucesso");
        }

        private Amigos ObterAmigo()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o nome do responsável: ");
            string responsavel = Console.ReadLine();

            Console.Write("Digite o numero do responsável: ");
            string numeroResponsavel = Console.ReadLine();

            Amigos amigo = new ();

            amigo.nome = nome;
            amigo.reponsavel = responsavel;
            amigo.numeroResponsavel = numeroResponsavel;


            return amigo;
        }

        public void EditarAmigo()
        {
            MostrarTitulo("Editando Amigo");

            VisualizarAmigo("Pesquisando");

            Console.Write("Digite o número do amigo que deseja editar: ");
            int numeroAmigo = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].numero == numeroAmigo)
                {
                    Amigos amigo = ObterAmigo();
                  
                    amigos[i] = amigo;
                    amigos[i].numero = numeroAmigo;

                    break;
                }
            }

            notificador.ApresentarMensagem("Amigo editado com sucesso", "Sucesso");
        }

        public void MostrarTitulo(string titulo)
        {
            Console.Clear();

            Console.WriteLine(titulo);

            Console.WriteLine();
        }

        public void ExcluirAmigo()
        {
            MostrarTitulo("Excluindo Amigo");

            VisualizarAmigo("Pesquisando");

            Console.Write("Digite o número do amigo que deseja excluir: ");
            int numeroAmigos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i].numero == numeroAmigos)
                {
                    amigos[i] = null;
                    break;
                }
            }

            notificador.ApresentarMensagem("Amigo excluído com sucesso", "Sucesso");
        }

        public void VisualizarAmigo(string tipo)
        {
            if (tipo == "Tela")
                MostrarTitulo("Visualização de Revistas");

            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    continue;

                Amigos a = amigos[i];

                Console.WriteLine("nome: " + a.nome);
                Console.WriteLine("responsável: " + a.reponsavel);
                Console.WriteLine("Numero do responsável: " + a.numeroResponsavel);

                Console.WriteLine();
            }
        }

        public int ObterPosicaoVazia()
        {
            for (int i = 0; i < amigos.Length; i++)
            {
                if (amigos[i] == null)
                    return i;
            }

            return -1;
        }


    }
}

