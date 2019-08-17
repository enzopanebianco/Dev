using System;

namespace Senai.Web.Models
{
    public class TransacaoModel
    {
        public string Tipo  { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTransacao { get; set; }
        public double Valor { get; set; }
    }
}