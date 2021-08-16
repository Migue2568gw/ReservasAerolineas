using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatosReserva.Models.ConsultaFiltro
{
    public class ResponseConsulta
    {
        public int IdReserva { get; set; }
        public string AeropuertoDeOrigen { get; set; }
        public string HoraSalida { get; set; }
        public string AeropuertoDeLlegada { get; set; }
        public string Aerolinea { get; set; }
        public Nullable<int> NumeroVuelo { get; set; }
        public string PreTipoPasajero { get; set; }
        public string HoraLlegada { get; set; }
        public Nullable<System.DateTime> FechaViaje { get; set; }
    }
}