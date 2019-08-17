using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Programa.Modelss;

namespace Programa.Controllers
{
    public class TarefaController:Controller
    {
        [HttpGet]
        public IActionResult Listar(){
            return View();
        }
        [HttpPost]
        public IActionResult Listar(IFormCollection form){
            TarefaViewModel tarefaViewModel = new TarefaViewModel{
                Nome = form["nome"],
                Descricao = form["descricao"],
                Tipo = form["tipo"],
                DataCriacao = DateTime.Now
            };
            using (StreamWriter sw = new StreamWriter("tarefas.csv",true))
            {
                sw.WriteLine($"{tarefaViewModel.Nome};{tarefaViewModel.Descricao};{tarefaViewModel.Tipo};{tarefaViewModel.DataCriacao}");
            }
            ViewBag.Mensagem = "Tarefa Enviada";
            return View();
        }
    }
}