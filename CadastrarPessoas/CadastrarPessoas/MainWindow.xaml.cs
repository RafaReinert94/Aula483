using CadastrarPessoas.Model;
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

namespace CadastrarPessoas
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

        CadastroUniversalDePessoasContex Contex = new CadastroUniversalDePessoasContex();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contex.Pessoas.Add(new Pessoa
            {
                Nome = tbxNome.Text,
                Idade = int.Parse(tbxIdade.Text),
                Date = DateTime.Now
            }) ;
            Contex.SaveChanges();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Contex.Pessoas.ToList<Pessoa>();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {

            var pessoa = (Pessoa)((System.Windows.FrameworkElement)sender).DataContext;
            var pessoaremovor = Contex.Pessoas.FirstOrDefault(x => x.Id == pessoa.Id);

            Contex.Pessoas.Remove(pessoaremovor);

            Contex.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Contex.Pessoas.ToList<Pessoa>();
            }
            catch
            {
                MessageBox.Show("Item nao pode ser excluido");
            }
        }
    }
}
