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

namespace wpfmulti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void adicionarfiguras_Click(object sender, RoutedEventArgs e)
        {
            SecondaryWindow Janela = new SecondaryWindow();

            if (Janela.ShowDialog() == true)
            {
                //MessageBox.Show(Janela.FiguraEscolhida);

                lbfiguras.Items.Add(Janela.FiguraEscolhida);
                //atualiza o Canvas
                switch (Janela.FiguraEscolhida)
                {
                    case "quadrado":
                        Rectangle quad = new Rectangle();
                        quad.Width = 75;
                        quad.Height = 75;
                        quad.Stroke = Brushes.Red;

                        cCanvas.Children.Add(quad);
                        break;
                    case "retangulo":
                        Rectangle rect = new Rectangle();
                        rect.Width = 100;
                        rect.Height = 50;
                        rect.Stroke = Brushes.Yellow;

                        cCanvas.Children.Add(rect);
                        break;
                    case "circulo":
                        Ellipse elip = new Ellipse();
                        elip.Width = 75;
                        elip.Height = 75;
                        elip.Stroke = Brushes.Blue;

                        cCanvas.Children.Add(elip);
                        break;
                }
            }

        }

        private void figurasair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}