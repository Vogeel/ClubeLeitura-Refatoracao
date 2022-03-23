/**
 * O sistema deve permirtir o usuário escolher qual opção ele deseja
 *  -Para acessar o cadastro de caixas, ele deve digitar "1"
 *  -Para acessar o cadastro de revistas, ele deve digitar "2"
 *  -Para acessar o cadastro de amigquinhos, ele deve digitar "3"
 *  
 *  -Para gerenciar emprestimos, ele deve digitar "4"
 *  
 *  -Para sair, usuário deve digitar "s"
 */
using System;

namespace ClubeLeitura.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TelaMenuPrincipal menuPrincipal = new ();
            TelaCadastroCaixa telaCadastroCaixa = new ();
            TelaCadastroAmigos telaCadastroAmigos = new ();

            telaCadastroCaixa.caixas = new Caixa[10];
            telaCadastroAmigos.amigos = new Amigos[10];
            telaCadastroCaixa.notificador = new Notificador();

             telaCadastroCaixa.repositorioCaixa = RepositorioCaixa; 
            telaCadastroAmigos.repositorioAmigos = RepositorioAmigos; 

            Notificador notificador = new Notificador();
            telaCadastroCaixa.notificador = notificador;
            while (true)
            {                
                string opcaoMenuPrincipal = menuPrincipal.MostrarOpcoes();

                if (opcaoMenuPrincipal == "1")
                {
                    string opcao = telaCadastroCaixa.MostrarOpcoes();

                    if (opcao == "1")
                    {
                        telaCadastroCaixa.InserirNovaCaixa();
                    }
                    else if (opcao == "2")
                    {
                        telaCadastroCaixa.EditarCaixa();
                    }
                    else if (opcao == "3")
                    {
                        telaCadastroCaixa.ExcluirCaixa();
                    }
                    else if (opcao == "4")
                    {
                        bool temCaixaCadastrada = telaCadastroCaixa.VisualizarCaixas("Tela");
                        if (temCaixaCadastrada == false)
                        {
                            notificador.ApresentarMensagem("Nenhuma caixa cadastrada", "Atencao");
                        }
                        Console.ReadLine();  
                    }
                }

                 if (opcaoMenuPrincipal == "2")
                {
                    string opcao = telaCadastroAmigos.MostrarOpcoes();

                    if (opcao == "1")
                    {
                        telaCadastroAmigos.InserirNovoAmigo();
                    }
                    else if (opcao == "2")
                    {
                        telaCadastroAmigos.EditarAmigo();
                    }
                    else if (opcao == "3")
                    {
                        telaCadastroAmigos.ExcluirAmigo();
                    }
                    else if (opcao == "4")
                    {
                        bool temAmigoCadastrado = telaCadastroAmigos.VisualizarCaixas("Tela");
                        if (temAmigoCadastrado == false)
                        {
                            notificador.ApresentarMensagem("Nenhum amigo cadastrada", "Atencao");
                        }
                        Console.ReadLine();  
                    }
                }
            }
        }       
    }
}
