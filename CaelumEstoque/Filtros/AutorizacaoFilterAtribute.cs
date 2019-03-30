using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CaelumEstoque.Filtros
{
    public class AutorizacaoFilterAtribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext) //diferentemente do OnActionExecuted, que verifica depois que o usuario realiza o login
        {//filterContext - Acessar a Session de login do Usuario;
         //HttpContext  - guarda os dados da requisição atual que o ASP.Net MVC está tratando;
         //Session - Session em questão;   
         // Result - é um actionResult que vc quer devolver para o usuario;
         // RedirectToRouteResult - redireciona para a tela de Login;
         // RouteValueDictionary - Dicionário que rece as informações do objeto RedirectToRouteResult;


            object usuario =  filterContext.HttpContext.Session["usuarioLogado"];
            if (usuario == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new {controller = "Login", action="Index"}
                        )
                    );
                
            }
        }

    }
}