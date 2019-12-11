using Boletim.Classe;
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

namespace Boletim
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Materias;
        }
        List<Materia> Materias = new List<Materia>
        {
           new Materia
           {
                Nome = "Matemática",
                 Nota1 =(decimal)5.0,
                 Nota2 = (decimal)6.4,
                 Nota3 = (decimal)9.4
           },
           new Materia
           {
                Nome = "Português",
                 Nota1 =(decimal)8.1,
                 Nota2 = (decimal)6.4,
                 Nota3 = (decimal)9.4
           },
           new Materia
           {
                Nome = "Ciências",
                 Nota1 =(decimal)3.5,
                 Nota2 = (decimal)6.4,
                 Nota3 = (decimal)9.4
           },
           new Materia
           {
                Nome = "Geografia",
                 Nota1 =(decimal)5.7,
                 Nota2 = (decimal)6.4,
                 Nota3 = (decimal)9.4
           },
           new Materia
           {
                Nome = "História",
                 Nota1 =(decimal)3.1,
                 Nota2 = (decimal)6.4,
                 Nota3 = (decimal)3.5
           },

        };

        private void BtnSituacaoGeral_Click(object sender, RoutedEventArgs e)
        {

            
            lblSituacaoGeral.Content = "";
        }   
    }
}
