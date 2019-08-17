using System;

namespace Senai.Financas.Mvc.Web.Modelss
{
    public class TransacaoModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public DateTime  DataTransacao { get; set; }
    }
}