using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Programa.Modelss;
using Programa.Repositorio;

namespace Programa.Controllers {
    public class UsuarioController : Controller {
        [HttpGet]
        public IActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel {
                Nome = form["nome"],
                Email = form["email"],
                Senha = form["senha"],
                DataCriacao = DateTime.Now
            };
            if (System.IO.File.Exists ("usuarios.csv")) {

                //Aplicando o ID
                usuarioViewModel.ID = System.IO.File.ReadAllLines ("usuarios.csv").Length + 1;
            } else {
                usuarioViewModel.ID = 1;

            }
            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuarioViewModel.ID};{usuarioViewModel.Nome};{usuarioViewModel.Email};{usuarioViewModel.Senha};{usuarioViewModel.DataCriacao};");
            }
            ViewBag.Mensagem = "Usuario Cadastrado";
            return View ();
        }

        [HttpGet]
        public IActionResult Logar () {
            return View ();
        }

        [HttpPost]
        public IActionResult Logar (IFormCollection form) {
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel {
                Email = form["email"],
                Senha = form["senha"]
            };
            UsuarioRepositorio usuarioRep = new UsuarioRepositorio ();

            if (usuarioRep.BuscarPorEmailESenha (usuarioViewModel.Email, usuarioViewModel.Senha) != null) {
                ViewBag.Mensagem = "Login Realizado";
            } else {

                ViewBag.Mensagem = "Acesso Negado";
            }

            return View ();
        }
    }
}