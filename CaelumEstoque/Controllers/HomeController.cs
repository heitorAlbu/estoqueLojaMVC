using CaelumEstoque.DAO;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [Route ("Home", Name="HomeIndice")]
        public ActionResult Index()
        {
            Produto p1 = new Produto();
            CategoriaDoProduto cat = new CategoriaDoProduto();

            ProdutosDAO dao = new ProdutosDAO();

            IList<Produto> produtos = dao.Lista();
            /*
            p1.Descricao = "caixa de fósforo muito boa";
            p1.CategoriaId = 2;
            p1.Nome = "caixa de fósforo OLHO";
            p1.Quantidade = 40;
            p1.Preco = 1;

            cat.Nome = "materias domésticos";
            cat.Id = 112;
            cat.Produto = produtos;

            dao.Adiciona(p1);
               */                    
            ViewBag.Produtos = produtos;

            return View();
        }
	}
}