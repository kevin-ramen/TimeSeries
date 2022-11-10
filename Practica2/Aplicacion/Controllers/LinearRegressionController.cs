using Microsoft.AspNetCore.Mvc;
using Practica2.Aplicacion.DTO;
using Practica2.Aplicacion.Interfaces;

namespace Practica2.Aplicacion.Controllers
{
    [ApiController]
    [Route("/trend")]
    public class LinearRegressionController : BaseController
    {
        [HttpPost("detrending/linear")]
        public async Task<IActionResult> PostLinear(URL dataUrl)
        {
            return Ok("");
        }
        [HttpPost("difference")]
        public async Task<IActionResult> PostDifference()
        {
            return Ok("");
        }
    }
}
