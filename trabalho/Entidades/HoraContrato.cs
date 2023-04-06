using System.Globalization;
using System;
using System.Collections.Generic;

namespace trabalho.Entidades
{
    internal class HoraContrato
    {
       public DateTime Data {get;set;}
       public double ValorDaHora { get; set; }
       public int Hora { get; set; }
       public HoraContrato() { }
        public HoraContrato(DateTime data, double valordahora, int hora) {
             Data = data;
             ValorDaHora = valordahora;
             Hora = hora;
        }

        public double TotalValor ()
        {
            return ValorDaHora * Hora;
        }

    }
}
