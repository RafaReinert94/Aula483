using CadastrarTelefone.Model;
using CadastrarTelefone.View;
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

namespace CadastrarTelefone
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
            dataGrid.ItemsSource = Contex.Telefones.ToList<Telefone>();
        }

        TelefoneContex Contex = new TelefoneContex();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();

            cadastro.ShowDialog();

            Contex.Telefones.Add(cadastro.Telefone);
            Contex.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Contex.Telefones.ToList<Telefone>();
            

        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var index = ((System.Windows.Controls.Primitives.Selector)sender).SelectedIndex;

            Contex.Telefones.Remove((Telefone)dataGrid.Items[index]);
            Contex.SaveChanges();

            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = Contex.Telefones.ToList<Telefone>();
        }
    }
}
