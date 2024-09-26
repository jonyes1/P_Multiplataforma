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

namespace wpfmulti2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Figura> _lista = new List<Figura>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WindowAdicionar janela = new WindowAdicionar();

            //janela.Show();
            if (janela.ShowDialog() == true)
            {
                // guardar a figura inserida

                _lista.Add(janela.FiguraNova);

                //.Items.Add(janela.FiguraNova.Nome);
                lbfiguras.Items.Add(janela.FiguraNova);

            }

        }

        private void lbfiguras_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbfiguras.SelectedItem != null)
            {
                Figura selecionada = lbfiguras.SelectedItem as Figura;

                sbiDimensoes.Content = "Largura = " + selecionada.Largura + "Altura = " + selecionada.Altura;
            }
            else
            {

                sbiDimensoes.Content = "Largura = ? Altura = ?";
            }
        }
    }
}
