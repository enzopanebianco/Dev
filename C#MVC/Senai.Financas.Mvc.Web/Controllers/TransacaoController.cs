using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.Mvc.Web.Modelss;

namespace Senai.Financas.Mvc.Web.Controllers {
    public class TransacaoController : Controller {
        [HttpGet]
        public IActionResult Cadastrar () {

            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar (IFormCollection Form) {
            TransacaoModel transacaoModel = new TransacaoModel();
            transacaoModel.Id = 1;
            transacaoModel.Descricao = Form["descricao"];
            transacaoModel.Valor = decimal.Parse(Form["valor"]);
            transacaoModel.Tipo = Form["tipo"];
            transacaoModel.DataTransacao = DateTime.Parse(Form["dataTransacao"]);
            
            using (StreamWriter sw = new StreamWriter("transacao.csv",true) )
            {
                sw.WriteLine($"{transacaoModel.Id};{transacaoModel.Descricao};{transacaoModel.Valor};{transacaoModel.Tipo};{transacaoModel.DataTransacao}");
                
            }
            ViewBag.Mensagem = "Transação Cadastrada";

            return View ();
        }
    }
}