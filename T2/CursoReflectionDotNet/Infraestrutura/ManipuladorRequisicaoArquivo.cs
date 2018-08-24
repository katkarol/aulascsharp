using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace CursoReflectionDotNet.Infraestrutura
{
    public class ManipuladorRequisicaoArquivo
    {
        public void Manipular(HttpListenerResponse resposta, string path)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var nomeResource = Utilidades.ConverterPathParaNomeAssembly(path);

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

                resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
                resposta.StatusCode = 200;
                resposta.ContentLength64 = resourceStream.Length;

                resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);

                resposta.OutputStream.Close();
            }

            using (resourceStream)
            {
                var bytesResource = new byte[resourceStream.Length];

                resourceStream.Read(bytesResource, 0, (int)resourceStream.Length);

                resposta.ContentType = Utilidades.ObterTipoDeConteudo(path);
                resposta.StatusCode = 200;
                resposta.ContentLength64 = resourceStream.Length;

                resposta.OutputStream.Write(bytesResource, 0, bytesResource.Length);

                resposta.OutputStream.Close();
                resourceStream.Read(bytesResource, 0, (int)resourceStream.Length);


            }

        }
    }
}
