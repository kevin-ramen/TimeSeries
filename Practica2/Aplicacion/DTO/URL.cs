using CSharpFunctionalExtensions;
using Practica2.Aplicacion.Errors;
using System.Text.RegularExpressions;
namespace Practica2.Aplicacion.DTO
{
    public class URL
    {

        public string url { get; set; } = string.Empty!;
        internal URL()
        {
        }
        private URL(string url)
        {
            this.url = url;
        }
        public static Result<URL,Error> Crear(string url)
        {
            //Validaciones
            if (url == null)
                return Result.Failure<URL, Error>(Errores.URL.StringNulo());
            if (Regex.IsMatch(url, @"[(http(s)?):\/\/(www\.)?a-zA-Z0-9@:%._\+~#=]{2,256}\.[a-z]{2,6}\b([-a-zA-Z0-9@:%_\+.~#?&//=]*)"))
                return Result.Failure<URL, Error>(Errores.URL.StringFormat());
            //Success
            return Result.Success<URL, Error>(new URL(url));
        }
    }
}
