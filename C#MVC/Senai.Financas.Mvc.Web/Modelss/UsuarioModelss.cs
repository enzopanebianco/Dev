using System;

namespace Senai.Financas.Mvc.Web.Modelss
{
    public class UsuarioModelss
    {
         public int ID { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}