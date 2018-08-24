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
            {
                throw new ArgumentNullException(nameof(prefixos));
            }
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
            var path = requisicao.Url.PathAndQuery;

            if (Utilidades.EhArquivo(path))
            {
                var manipulador = new ManipuladorRequisicaoController();
                manipulador.Manipular(resposta, path);





            }
            else
            {
                var manipulador = new ManipuladorRequisicaoController();
                manipulador.Manipular(resposta, path);
            }

            httpListener.Stop();

        }
    }
}
