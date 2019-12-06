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

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MostrarLista();
        }


        List<string> ListaDeFilme = new List<string>
        {
            "Avengers",
            "Transformes",
            "7 seens",
            "Hotel transilvania",
            "Incriveis"
        };

        private void FiltrarPeloTexto()
        {
            dataGrid.ItemsSource = ListaDeFilme.Where(x => x.Contains(tbxText.Text));
        }


        private void BtnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            switch (cbxFiltro.SelectedIndex)
            {
                
                case 0:
                    dataGrid.ItemsSource = ListaDeFilme.OrderBy(x => x);
                    break;
                case 1:
                    FiltrarPeloTexto();
                    break;
            }
            
        }

        private void BtnAdicionar_Click(object sender, RoutedEventArgs e)
        {
            AdicionarFilme();
            dataGrid.ItemsSource = null;
            MostrarLista();

        }

        private void AdicionarFilme()
        {
            ListaDeFilme.Add(tbxText.Text);
        }

        private void MostrarLista()
        {
            dataGrid.ItemsSource = ListaDeFilme;
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            ExcluirFilme(tbxText.Text);
            MostrarLista();
        }

        private void ExcluirFilme(string delete)
        {
            ListaDeFilme.Remove(delete);
        }
    }
}
