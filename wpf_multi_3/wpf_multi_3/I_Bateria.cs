using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public interface I_Bateria
    {
        // Propriedades
        int Carga { get; set; }

        // Métodos
        void Carregar();
        void Descarregar();

        // Eventos
        event MensagemComInt CargaAlterada;
    }
}

