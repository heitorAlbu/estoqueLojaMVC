using CaelumEstoque.DAO;
using CaelumEstoque.Filtros;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    [AutorizacaoFilterAtribute]
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            CategoriasDAO catdao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = catdao.Lista();
            ViewBag.Categorias = categorias;

            return View();
        }
        public ActionResult Form()
        {
            return View();
        }

        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            CategoriasDAO catdao = new CategoriasDAO();
            catdao.Adiciona(categoria);
            return RedirectToAction("Index", "Categoria");

        }

    }
}