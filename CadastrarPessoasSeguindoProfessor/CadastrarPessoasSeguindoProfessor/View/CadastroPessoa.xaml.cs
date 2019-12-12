﻿using CadastrarPessoasSeguindoProfessor.Model;
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

namespace CadastrarPessoasSeguindoProfessor.View
{
    /// <summary>
    /// Lógica interna para CadastroPessoa.xaml
    /// </summary>
    public partial class CadastroPessoa : Window
    {
        public CadastroPessoa()
        {
            InitializeComponent();
        }

        public Pessoa Pessoa { get; set; }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            Pessoa = new Pessoa()
            {
                Nome = tbxNome.Text,
                Idade = int.Parse(tbxIdade.Text),
                Data = DateTime.Now
            };



            this.Close();
        }
    }
}
