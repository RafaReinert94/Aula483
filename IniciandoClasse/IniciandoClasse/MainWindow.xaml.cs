﻿using IniciandoClasse.Classes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IniciandoClasse
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Criancas;
        }

        List<Crianca> Criancas = new List<Crianca>
        {
            new Crianca()
            {
                 Nome = "Peppa Pig",
                Idade = 4
            },
            new Crianca()
            {
                 Nome = "Ben",
                 Idade = 10
            },
            new Crianca()
            {
                 Nome = "Mestre dos Magos",
                 Idade = 101
            }
            
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Criancas.ForEach(x => MessageBox.Show($"Nome: {x.Nome} Idade: {x.Idade}"));
        }
    }
}
