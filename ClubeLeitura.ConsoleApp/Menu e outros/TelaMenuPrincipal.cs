﻿using System;

namespace ClubeLeitura.ConsoleApp
{
    public class TelaMenuPrincipal
    {
        private string opcaoSelecionada;

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Clube da Leitura 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para acessar Caixas");
            Console.WriteLine("Digite 2 para acessar os Amigos");
            Console.WriteLine("Digite 3 para acessar as revistas");
            Console.WriteLine("Digite 4 para acessar os Empréstimos");

            Console.WriteLine("Digite s para sair");

            opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }
    
    }
}