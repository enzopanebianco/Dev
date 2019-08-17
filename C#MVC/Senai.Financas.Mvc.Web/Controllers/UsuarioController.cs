using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.Mvc.Web.Modelss;
using Senai.Financas.Mvc.Web.Repositorios;

namespace Senai.Financas.Mvc.Web.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]
        public ActionResult Cadastro () {
            return View ();

        }

        [HttpPost]
        public ActionResult Cadastro (IFormCollection form) {
            UsuarioModelss usuarioModel = new UsuarioModelss ();
            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.Senha = form["senha"];
            usuarioModel.DataNascimento = DateTime.Parse (form["dataNascimento"]);
            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {

                sw.WriteLine ($"{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.Senha};{usuarioModel.DataNascimento}");
            }
            ViewBag.Mensagem = "Usuario Cadastrado";
            return View ();
        }

        [HttpGet]
        public IActionResult Login () => View ();

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            UsuarioModelss usuarioModelss = new UsuarioModelss {
                Email = form["email"],
                Senha = form["senha"]
            };
            //Verificar se o usuário possui acesso para logar
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();
            if (usuarioRep.BuscarPorEmailESenha (usuarioModelss.Email, usuarioModelss.Senha) != null) {
                ViewBag.Mensagem = "Login Realizado";
            } else {

                ViewBag.Mensagem = "Acesso Negado";
            }
           
            return View ();

        }
    }
}