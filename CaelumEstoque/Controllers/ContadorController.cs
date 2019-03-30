using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class ContadorController : Controller
    {
        // GET: Contador
        public ActionResult Index()
        {
            /*
             Cria uma Session que por sua vez funciona como se fosse um dicionário no qual você pode guardar qualquer coisa e retorna um elemento
             do tipo Object;
             
             Posteriormente essa session é convertida para inteiro, para que caso ela seja nula, retorne 0 e caso contrário retorne algum valor inteiro.
             após isso é realizada a incrementação de +1;
             
             Depois o contador é retornado para session após ser concatenado com ele mesmo;

             
             */

            object valorNaSession = Session["contador"]; 
            int contador = Convert.ToInt32(valorNaSession);
            contador++;
            Session["contador"] = contador;
            return View(contador);
        }
    }
}