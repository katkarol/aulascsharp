using System;
using CursoReflectionDotNet.Infraestrutura;

namespace CursoReflectionDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prefixos = new string[] { "http://localhost:5341/" };
            WebApplication webApplication = new WebApplication(prefixos);
            webApplication.Iniciar();
        }
    }
}
