﻿using CaelumEstoque.DAO;
using CaelumEstoque.Filtros;
using CaelumEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.Controllers
{
    public class LoginController : Controller
    {
       
        
        // GET: Login
      
        public ActionResult Index()
        {
                return View();
        }

        public ActionResult Autentica(String login, String senha)
        {
            UsuariosDAO dao = new UsuariosDAO();
            Usuario usuario = dao.Busca(login, senha);
            
            if (usuario!=null)
            {
                Session["usuarioLogado"] = usuario;
                
                return RedirectToAction("Index", "Home");
                
            }
            else
            {
               return RedirectToAction("Index");
            }

        }
        [AutorizacaoFilterAtribute]
        public ActionResult UserTela()
        {
            var userlog = ((Usuario)Session["usuarioLogado"]);
            UsuariosDAO dao = new UsuariosDAO();
            ViewBag.Usuario = userlog;
            return View();
        }
    }
}