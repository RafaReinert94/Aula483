using PessoaExercicio.Classes;
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

namespace PessoaExercicio
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Pessoas;
        }

        List<Pessoa> Pessoas = new List<Pessoa>
        {
            new Pessoa
            {
                Nome = "Dejair",
                DataDeNascimento = DateTime.Parse("21/09/1987")
            },
            new Pessoa
            {
                Nome = "João do Caminhão",
                DataDeNascimento = DateTime.Parse("21/09/1984")
            },
            new Pessoa
            {
                Nome = "Cleiton",
                DataDeNascimento = DateTime.Parse("21/09/2005")
            },
        };
    }
}
