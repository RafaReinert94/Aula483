﻿using System;
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

namespace IniciandoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = ListaDeNomes;
        }

        List<string> ListaDeNomes = new List<string>
        {
            "Chael",
            "Rocneth",
            "Liamcyn",
            "Dicjohn",
            "Dahe",
            "Chellren",
            "Kimni",
            "Hadod",
            "Garnyahildi",
            "Reginisen",
            "Danmax",
            "Leysig",
            "Hesfastnath",
            "Jenba",
            "Marmaand",
            "Gorma",
            "Helm",
            "Isumlin",
            "Jenann",
            "Doegar"
        };

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;


            switch (cbxFiltro.SelectedIndex)
            {
                case 0:
                    OrdenarLista();
                    break;
                case 1:
                    FiltraPorLetras(tbxFiltro.Text);
                    break;
                case 2:
                    OrdenarMaiorParaMenor();
                    break;

            }
             //MessageBox.Show(tbxFiltro.Text);
             //MessageBox.Show("Olá WFP");
        }

        private void OrdenarLista()
        {
            dataGrid.ItemsSource = ListaDeNomes.OrderBy(x => x);
        }

        private void FiltraPorLetras(string parametro)
        {
            dataGrid.ItemsSource = ListaDeNomes.Where(x => x.Contains(parametro));
        }

        private void OrdenarMaiorParaMenor()
        {
            dataGrid.ItemsSource = ListaDeNomes.OrderByDescending(x => x.Length);
        }
    }
}
