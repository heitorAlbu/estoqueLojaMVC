using CaelumEstoque.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) //coleção de filtros globais do ASP.Net MVC
        {
           // filters.Add(new AutorizacaoFilterAtribute());//adicionar um filtro global passando uma instância de filtro global
                                                        // é necessário avisar nao ASP.Net MVC que ele precisa realizar os filtros Globais
                                                        // para isso é necessário implementar o arquivo Global.asax que já vem no projeto 
                                                        //e que o mesmo faz as configurações globais da aplicação
        }
    }
}