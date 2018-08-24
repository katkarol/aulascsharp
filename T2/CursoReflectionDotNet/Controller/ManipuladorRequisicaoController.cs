using CursoReflectionDotNet.Infraestrutura.Binding;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CursoReflectionDotNet.Controller
{
    public class ManipuladorRequisicaoController
    {
        private readonly ActionBinder _actionBinder = new ActionBinder();

        public void Manipular(HttpListenerResponse resposta, string path)
        {
            var partes = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var controllerNome = partes[0];
            var actionNome = partes[1];
            Type type = Type.GetType("CursoReflectionDotNet");
            var controllerNomeCompleto = $"CursoReflectionDotNet.Controller.{controllerNome}Controller";
            var controllerWrapper = Activator.CreateInstance(type, controllerNomeCompleto, new object[0]);
            var controller = controllerWrapper.Unwrap();
            var methodInfo = _actionBinder.ObterMethodInfo(controller, path);
            //var methodInfo = controller.GetType().GetMethod(actionNome);
            methodInfo.Invoke(controller);

            var resultadoAction = (string)methodInfo.Invoke(controller, new object[0]);
        }
    }
}
