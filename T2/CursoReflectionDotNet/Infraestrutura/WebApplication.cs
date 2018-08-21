using CursoReflectionDotNet.Controller;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace CursoReflectionDotNet.Infraestrutura
{
    public class WebApplication
    {
        private readonly string[] _prefixos;

        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
                throw new ArgumentNullException(nameof(prefixos));
            _prefixos = prefixos;
        }
        public void Iniciar()
        {
            while (true)
            {
                ManipularRequisicao();
            }

        }

        private void ManipularRequisicao()
        {
            HttpListener httpListener = new HttpListener();

            foreach (string prefixo in _prefixos)
            {

                httpListener.Prefixes.Add(prefixo);
            }

            httpListener.Start();
            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;
            var path = requisicao.Url.AbsolutePath;

            if (Utilidade.EhArquivo(path))
            {
                var assembly = Assembly.GetExecutingAssembly();

                var nomeResource = Utilidade.ConverterPathParaNomeAssembly(path);

                var resourceStream = assembly.GetManifestResourceStream(nomeResource);
                if (resourceStream == null)
                {
                    resposta.StatusCode = 404;
                    resposta.OutputStream.Close();

                }
                else
                {
                    var bytesResource = new byte[resourceStream.Length];

                    resourceStream.Read(bytesResource, 0, (int)resourceStream.Length);
                    resposta.ContentType = Utilidade.ObterTipoDeConteudo(path);
                    resposta.StatusCode = 200;
                    resposta.ContentLength64 = resourceStream.Length;

                    resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);
                    resposta.OutputStream.Close();
                }





            }
            else if (path == "/Cambio/MXN")
            {
                var controller = new CambioController();
                var paginaConteudo = controller.MXN();
                var bufferArquivo = Encoding.UTF8.GetBytes(paginaConteudo);
                resposta.StatusCode = 200;
                resposta.ContentType = "text/html; charset=uft-8";
                resposta.ContentLength64 = bufferArquiivo.Length;

                resposta.OutputStream.Write(bufferArquivo, 0, bufferArquivo.Lenght);
                resposta.OutputStrem.Close();
            }

            httpListener.Stop();

        }
    }
}
