using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Web.Models;

namespace Senai.Web.Controllers {
    public class TransacaoController : Controller {
        [HttpGet]
        public ActionResult Cadastrar () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastrar(IFormCollection form) {
            TransacaoModel transacaoModel = new TransacaoModel();
            transacaoModel.Tipo = form["tipo"];
            transacaoModel.Descricao = form["descricao"];
            transacaoModel.DataTransacao= DateTime.Parse(form["dataTransacao"]);
            transacaoModel.Valor = Double.Parse(form["valor"]);
            using (StreamWriter sw = new StreamWriter("transacao.csv",true))
            {
                sw.WriteLine($"{transacaoModel.Tipo};{transacaoModel.Descricao};{transacaoModel.DataTransacao};{transacaoModel.Valor}");
            }
            return View ();
        }

    }
}