using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        private App _app;

        public MainWindow()
        {
            InitializeComponent();
            _app = App.Current as App;

            _app.M_Bateria.CargaAlterada += M_Bateria_CargaAlterada;

        }
        private void M_Bateria_CargaAlterada(int valor)
        {
            pbBateria.Value = valor;
            this.Title = "Gestor de Bateria - " + valor +"%";

        }

        private void btnCarregar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                _app.M_Bateria.Carregar();
            }
            catch (OperacaoInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
                
        private void btnDescarregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _app.M_Bateria.Descarregar();
            }
            catch (OperacaoInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}