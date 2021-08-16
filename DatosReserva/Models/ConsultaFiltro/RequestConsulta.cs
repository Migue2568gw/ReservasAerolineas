using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatosReserva.Models.ConsultaFiltro
{
    public class RequestConsulta
    {
        public string AeropuertoDeOrigen { get; set; }
        public string AeropuertoDeLlegada { get; set; }
        public string Aerolinea { get; set; }
    }
}