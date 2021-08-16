using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatosReserva.Models;
using DatosReserva.Models.ConsultaFiltro;
using DatosReserva.Models.Create;

namespace DatosReserva.Mapper
{
    public class mapeo
    {
        private ReservasAereasEntities1 db = new ReservasAereasEntities1();
        public List<DatosReservas> modeltorequet(List<SP_TraerData_Result> datosReserva)
        {
            List<DatosReservas> model = new List<DatosReservas>();
            foreach (var item in datosReserva)
            {
                var presio = (from e in db.PrecioTP select e).Where(x => x.IdTipoPasajero == item.TipoPasajero).FirstOrDefault();
                DatosReservas mod = new DatosReservas();
                mod.IdReserva = item.IdReserva;
                mod.AeropuertoDeOrigen = item.AeropuertoDeOrigen;
                mod.HoraSalida = item.HoraSalida;
                mod.AeropuertoDeLlegada = item.AeropuertoDeLlegada;
                mod.Aerolinea = item.Aerolinea;
                mod.NumeroVuelo = item.NumeroVuelo;
                mod.PreTipoPasajero = Convert.ToString(presio.PrecioTP1);
                mod.HoraLlegada = item.HoraLlegada;
                mod.FechaViaje = item.FechaViaje;

                model.Add(mod);
            }
            return model;
        }
        public DatosReserva requestToModel(RequestCreate model)
        {
            DatosReserva Data = new DatosReserva();
            Data.AeropuertoDeOrigen = model.AeropuertoDeOrigen;
            Data.HoraSalida = model.HoraSalida;
            Data.AeropuertoDeLlegada = model.AeropuertoDeLlegada;
            Data.Aerolinea = model.Aerolinea;
            Data.NumeroVuelo = model.NumeroVuelo;
            Data.TipoPasajero = model.TipoPasajero;
            Data.HoraLlegada = model.HoraLlegada;
            Data.FechaViaje = model.FechaViaje;
            return Data;
        }
    }
}