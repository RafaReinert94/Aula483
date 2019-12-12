﻿using CadastrarTelefone.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CadastrarTelefone.View
{
    /// <summary>
    /// Lógica interna para Cadastro.xaml
    /// </summary>
    public partial class Cadastro : Window
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public Telefone Telefone { get; set;}
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Telefone = new Telefone
            {
                Nome = tbxNome.Text,
                Numero = int.Parse(tbxNumero.Text)
            };

            this.Close();

        }
    }
}
