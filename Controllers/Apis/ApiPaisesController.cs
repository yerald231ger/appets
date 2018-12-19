using System.Collections.Generic;
using System.Linq;
using ApPets.Services;
using Microsoft.AspNetCore.Mvc;

    [Route("api")]
    public class ApiPaisesController : Controller
    {
        [HttpGet]
        [Route("Pais")]

        public ICollection<KeyValuePair<int, string>> Paises()
        {
            return _paisRepository.Read().Select(p => new KeyValuePair<int, string>(p.Id, p.Name)).ToList();
        }

        [HttpGet]
        [Route("Pais/{i:int}/Estados")]
        public ICollection<KeyValuePair<int, string>> ObtenerEstadosPais(int i)
        {
            return _paisRepository.GetEstados(i).Select(e => new KeyValuePair<int, string>(e.Id, e.Name)).ToList();
        }

        private IPaisRepository _paisRepository;

        public ApiPaisesController(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }
    }  