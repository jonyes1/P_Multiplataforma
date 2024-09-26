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

namespace wpf_multi_1
{
    /// <summary>
    /// Interação lógica para SecondaryWindow.xam
    /// </summary>
    public partial class SecondaryWindow : Window
    {
        public String FiguraEscolhida { get; private set; }
        public SecondaryWindow()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            if (cbFiguras.SelectedIndex >= 0)
            {
                switch (cbFiguras.SelectedIndex)
                {
                    case 0:
                        FiguraEscolhida = "quadrado";
                        break;
                    case 1:
                        FiguraEscolhida = "retangulo";
                        break;
                    case 2:
                        FiguraEscolhida = "circulo";
                        break;
                }
                //FiguraEscolhida = cbFiguras.Items[cbFiguras.SelectedIndex].ToString();
                this.DialogResult = true;
            }
        }
    }
}
