using CursoReflectionDotNetService.Cambio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CursoReflectionDotNet.Controller
{
    public class CambioController
    {
        private ICambioService _cambioService;

        public CambioController()
        {
            _cambioService = new CambioTesteService();
        }

        public string MXN()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);
            var nomeCompletoResource = "T2.CursoReflectionDotNet.View.Cambio.MXN.html";
            var assembly = Assembly.GetExecutingAssembly();

            var streamRecurso = assembly.GetManifestResourceStream(nomeCompletoResource);

            var streamLeitura = new StreamReader(streamRecurso);
            var textoPagina = streamLeitura.ReadToEnd();
            var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());
            return textoResultado;

        }
        public string USD()
        {
            var valorFinal = _cambioService.Calcular("USD", "BRL", 1);
            var nomeCompletoResource = "ByteBank.Portal.View.Cambio.MXN.html";
            var assembly = Assembly.GetExecutingAssembly();

            var streamRecurso = assembly.GetManifestResourceStream(nomeCompletoResource);

            var streamLeitura = new StreamReader(streamRecurso);
            var textoPagina = streamLeitura.ReadToEnd();

            var textoResultado = textoPagina.Replace("VALOR_EM_REAIS", valorFinal.ToString());

            return textoResultado;
        }
    }
}
