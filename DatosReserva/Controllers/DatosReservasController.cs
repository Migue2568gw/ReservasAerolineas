using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DatosReserva.Models.ConsultaFiltro;
using DatosReserva.Mapper;
using DatosReserva.Models;
using DatosReserva.Models.Create;

namespace DatosReserva.Controllers
{
    public class DatosReservasController : ApiController
    {
        public ReservasAereasEntities1 db = new ReservasAereasEntities1();
        private mapeo map = new mapeo();

        // GET: api/DatosReservas/5
        [ResponseType(typeof(DatosReserva))]
        [HttpGet]
        public IHttpActionResult ConsultaByID(int id)
        {
            DatosReserva datosReserva = db.DatosReserva.Find(id);
            if (datosReserva == null)
            {
                return NotFound();
            }

            return Ok(datosReserva);
        }

        // POST: api/ConsultaPorFiltro
        [ResponseType(typeof(ResponseConsulta))]
        public IHttpActionResult ConsultaPorFiltro(RequestConsulta datosReserva)
        {
            if (datosReserva.AeropuertoDeOrigen == null && datosReserva.AeropuertoDeLlegada == null && datosReserva.Aerolinea == null)
            {
                return BadRequest("Hay Campos Vacios Validar");
            }
            DatosReservas model = new DatosReservas(); model.listado = new List<DatosReservas>();
            var data = db.SP_TraerData(datosReserva.AeropuertoDeOrigen, datosReserva.AeropuertoDeLlegada, datosReserva.Aerolinea).ToList(); ;
            if (data.Count > 0)
            {
                model.listado = map.modeltorequet(data);
            }

            return Ok(model.listado);
        }

        // POST: api/CrearReserva
        [ResponseType(typeof(ResponseCreate))]
        public IHttpActionResult CrearReserva(RequestCreate datosReserva)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var mapeo = map.requestToModel(datosReserva);
                db.DatosReserva.Add(mapeo);
                db.SaveChanges();
                return Ok("Datos de Reserva Registrados");
            }
            catch (Exception e)
            {
                return Ok(e.Message);
            }
        }
    }
}