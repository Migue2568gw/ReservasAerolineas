using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace DatosReserva.Models.Create
{
    public class RequestCreate
    {
        public int IdReserva { get; set; }
        [Required]
        public string AeropuertoDeOrigen { get; set; }
        [Required]
        public string HoraSalida { get; set; }
        [Required]
        public string AeropuertoDeLlegada { get; set; }
        [Required]
        public string Aerolinea { get; set; }
        [Required]
        public int NumeroVuelo { get; set; }
        [Required]
        [Range(1,2,ErrorMessage ="Tipo de pasajeros 1.Adultos // 2.Niños")]
        public int TipoPasajero { get; set; }
        [Required]
        public string HoraLlegada { get; set; }
        [Required]
        public DateTime FechaViaje { get; set; }
    }
}