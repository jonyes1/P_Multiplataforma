using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class ModelBateria : I_Bateria
    {
        private int _carga = 0;
        public int Carga { 

                get { return _carga;  }
                set {
                _carga = value;
                CargaAlterada?.Invoke(_carga);
            
                }
        
        }

        public event MensagemComInt CargaAlterada;

        public void Carregar()
        {
            if(_carga < 100)
            {
                Carga +=10;

            }
            else
            {
                throw new OperacaoInvalidaException("BATERIA CHEIA");
            }
        }

        public void Descarregar()
        {
            if (_carga > 0)
            {
                Carga -=10;

            }
            else
            {
                throw new OperacaoInvalidaException("BATERIA VAZIA");
            }
        }
    }
}
