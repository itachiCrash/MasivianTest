using MasivianTest.Models;
using MasivianTest.Negocio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Http;


namespace MasivianTest.Controllers
{
    public class ArbolController : ApiController
    {
        Arbol arbolEjecutor = new Arbol();

        [HttpGet]
        public object CrearYDevolverArbol([FromUri]int[] valores)
        {
            return arbolEjecutor.CrearArbol(valores);
        }

        [HttpGet]
        public int ObtenerAncestroComunMasBajo([FromUri]string arbol, int nodo1, int nodo2)
        {
            ArbolBinario arbolGenerado = JsonConvert.DeserializeObject<ArbolBinario>(arbol);
            return arbolEjecutor.EncontrarAncestroComunMasBajo(arbolGenerado, nodo1, nodo2);
        }
    }
}
