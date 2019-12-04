﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroCivilDeNomes
{
    class Program
    {

        //static, qualquer parte da aplicação 
        static List<string> ListaDeNomes = new List<string>();
        static void Main(string[] args)
        {
            MensagemInicial();

            var menuEscolhido = "0";

            while (menuEscolhido != "5")
            {
                menuEscolhido = MostrarMenu();

                switch (menuEscolhido)
                {
                    case "1":
                        RegistrarNome();
                        break;
                    case "2":
                        MostrarLista();
                        break;
                    default:
                        Console.WriteLine("Menu Inválido");
                        Console.ReadKey(true);
                        break;
                }

                Console.Clear();
            }

            Console.ReadKey(true);
        }

        private static void MensagemInicial()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("***Sistema de Registro***");
            Console.WriteLine("*************************");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        static void RegistrarNome()
        {
            Console.WriteLine("Registro de Nome Selecionado");
            Console.WriteLine("Informe um Nome:");
            var nomeInformado = Console.ReadLine();

            ListaDeNomes.Add(nomeInformado);

            Console.WriteLine("Nome Informado com sucesso");
            Console.ReadKey(true);
        }

        static void MostrarLista()
        {
            Console.WriteLine("Listagem de Nome Selecionado");

            ListaDeNomes.ForEach(x => Console.WriteLine($"Nome:^{x}"));

            Console.WriteLine("Listagem de nomes finalizada.");
            Console.ReadKey(true);
        }

        static string MostrarMenu()
        {
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("1 - Registrar Nome");
            Console.WriteLine("2 - Listar Nomes");
            Console.WriteLine("3 - Editar Um Nome");
            Console.WriteLine("4 - Excluir Nomes");
            Console.WriteLine("5 - Sair do Sistema");
            return Console.ReadLine();
        }

    }
}
