using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutosDAO pdao = new ProdutosDAO();
            IList<Produto> produtos = pdao.Lista();
            ViewBag.Produtos = produtos;
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        [HttpPostAttribute]
        public ActionResult Adiciona(Produto produto)
        {

            ProdutosDAO dao = new ProdutosDAO();
            dao.Adiciona(produto);
            return RedirectToAction("Index");
        }
    }
}