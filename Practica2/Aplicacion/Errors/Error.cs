using CSharpFunctionalExtensions;

namespace Practica2.Aplicacion.Errors
{
    public sealed class Error : ValueObject
    {
        public string Codigo { get; }
        public string Mensaje { get; }

        internal Error(string codigo, string mensaje)
        {
            Codigo = codigo;
            Mensaje = mensaje;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Codigo;
            yield return Mensaje;
        }
    }
}
