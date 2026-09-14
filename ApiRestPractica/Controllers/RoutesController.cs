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
    }
}
