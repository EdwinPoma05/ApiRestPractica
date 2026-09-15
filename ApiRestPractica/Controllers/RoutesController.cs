using ApiRestPractica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiRestPractica.Controllers
{
    public class RoutesController : ApiController
    {
        public List<Route> Get()
        {
            Route nuevaRuta = new Route
            {
                Id = 1,
                Nombre = "201"
            };

            List<Route> rutas = new List<Route>();

            rutas.Add(nuevaRuta);

            return rutas;
        }

        //public Route Get(int id)
        //{
        //    List<Route> listaRutas = new List<Route>();

        //    Route ruta1 = new Route
        //    {
        //        Id = 1,
        //        Nombre = "201"
        //    };

        //    Route ruta2 = new Route
        //    {
        //        Id = 2,
        //        Nombre = "202"
        //    };

        //    Route ruta3 = new Route
        //    {
        //        Id = 3,
        //        Nombre = "203"
        //    };

        //    listaRutas.Add(ruta1);
        //    listaRutas.Add(ruta2);
        //    listaRutas.Add(ruta3);

        //    Route rutaEncontrada=listaRutas.FirstOrDefault(ruta => ruta.Id == id);

        //    return rutaEncontrada;  
        //}


        public IHttpActionResult Get(int id)
        {
            List<Route> listaRutas = new List<Route>();

            Route ruta1 = new Route
            {
                Id = 1,
                Nombre = "201"
            };

            Route ruta2 = new Route
            {
                Id = 2,
                Nombre = "202"
            };

            Route ruta3 = new Route
            {
                Id = 3,
                Nombre = "203"
            };

            listaRutas.Add(ruta1);
            listaRutas.Add(ruta2);
            listaRutas.Add(ruta3);

            Route rutaEncontrada = listaRutas.FirstOrDefault(ruta => ruta.Id == id);


            if (rutaEncontrada != null)
            {
                return Ok(rutaEncontrada);
            }
            else
            {
                return NotFound();
            }

            
        }
    }
}
