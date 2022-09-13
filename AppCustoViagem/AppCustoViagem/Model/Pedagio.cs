using System;
using System.Collections.Generic;
using System.Text;

namespace AppCustoViagem.Model
{
    public class Pedagio
    {

        string _localização;
        double _valor;

        public string Localização
        {
            get => _localização;
            set
            {
                if (value == null)
                    throw new Exception("Coloque a sua Localização");
                        _localização = value;

            }
        }
        public double Valor
        {
            get => _valor;
            set
            {
                if (value == 0)
                    throw new Exception("Coloque o valor");
                _valor = value;
            }
        }

        public string Localizacao { get; internal set; }
    }
}
