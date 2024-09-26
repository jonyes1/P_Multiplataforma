using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Models

        public ModelBateria M_Bateria { get; private set; }

        public App()
        {
            M_Bateria= new ModelBateria();
        }

    }

}
