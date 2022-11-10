using CSharpFunctionalExtensions;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Practica2.Aplicacion.Errors;

namespace Practica2.Aplicacion.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BaseController : ControllerBase
    {
        private ISender? _mediator;

        protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();

        protected new IActionResult Ok()
        {
            return base.Ok(Envelope.Ok());
        }

        protected IActionResult Ok<T>(T resultado)
        {
            return base.Ok(Envelope.Ok(resultado));
        }

        protected IActionResult FromResult(Result<object, Error> resultado)
        {
            if (resultado.IsSuccess)
                return Ok();

            return BadRequest(Envelope.Error(resultado.Error));
        }
    }
}
