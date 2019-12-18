using SistemaControleEstoque.Controller;
using SistemaControleEstoque.Model;
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

namespace SistemaControleEstoque.Views
{
    /// <summary>
    /// Lógica interna para VisualizarEstoque.xaml
    /// </summary>
    public partial class VisualizarEstoque : Window
    {
        
        public VisualizarEstoque()
        {
            InitializeComponent();

            var estoque = Estoque.GetEstoques();
            var usuarios = Usuario.GetUsuarios();


            dataGrid.ItemsSource = (from est in estoque
                                    join usu in usuarios on est.UsuarioCriacao equals usu.Id
                                    join usuAlt in usuarios on est.UsuarioAlteracao equals usuAlt.Id
                                    select new
                                     {
                                        UsuarioInc = usu.Login,
                                        Produto = est.Produto,
                                      Quantidade = est.Quantidade,
                                      Valor = est.Valor.ToString("C"),
                                      
                                      UsuarioAlt = usuAlt.Login
                                     }).ToList();
        }

        EstoqueController Estoque = new EstoqueController();
        UsuarioController Usuario = new UsuarioController();

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
