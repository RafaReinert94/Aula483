using CadastrarPessoasSeguindoProfessor.Model;
using CadastrarPessoasSeguindoProfessor.View;
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

namespace CadastrarPessoasSeguindoProfessor
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Contex.Pessoas.ToList<Pessoa>();
        }

        CadastroContex Contex = new CadastroContex();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa();

            cadastroPessoa.ShowDialog();

            Contex.Pessoas.Add(cadastroPessoa.Pessoa);
            Contex.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Contex.Pessoas.ToList<Pessoa>();

        }
    }
}
