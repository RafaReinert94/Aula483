using ListaDeNotas.Classe;
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

namespace ListaDeNotas
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Notas;
        }
        List<Nota> Notas = new List<Nota>
        {
            new Nota
            {
                Materia = "Matemática",
                NotaDaMateria = (decimal)8.7
            },
            new Nota
            {
                Materia = "Ciências",
                NotaDaMateria = (decimal)6.8
            },
            new Nota
            {
                Materia = "Português",
                NotaDaMateria = (decimal)9.1
            },
            new Nota
            {
                Materia = "Educação Física",
                NotaDaMateria = (decimal)10.0
            },
            new Nota
            {
                Materia = "História",
                NotaDaMateria = (decimal)5.5
            },
            new Nota
            {
                Materia = "Geografia",
                NotaDaMateria = (decimal)8.1
            }

        };

        private void BtnSituacao_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Você está" + (Notas.Average(x => x.NotaDaMateria) >= 7? " Aprovado":" Reprovado"));

    
        }
    }
}
