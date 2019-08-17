using System;
using System.Collections.Generic;
using System.IO;
using Senai.Financas.Mvc.Web.Modelss;

namespace Senai.Financas.Mvc.Web.Repositorios {
    public class UsuarioRepositorio {
        public UsuarioModelss BuscarPorEmailESenha(string email ,string senha){
            List<UsuarioModelss> usuariosCadastrados = CarregarDoCSV();
            //percorro cada usuario da lista
            foreach (UsuarioModelss  usuario in usuariosCadastrados)
            {
                if (usuario.Email == email && usuario.Senha == senha )
                {
                    return usuario;
                }
            }
            //Caso o sistema não encontre nenhuma combinação de email
            //retorna nulo
            return null;
        }

        //Carrega lista no CSV
        private List<UsuarioModelss> CarregarDoCSV () {
            List<UsuarioModelss> lsUsuarios = new List<UsuarioModelss> ();
            //Abre o stream de leitura do arquivo CSV
            string[] linhas = File.ReadAllLines ("usuarios.csv");
            //Lê cada registro 
            foreach (string linha in linhas) {
                //Separa os dados da linha
                string[] dados = linha.Split (";");
                //cria o objeto com os dados da linha
                UsuarioModelss usuario = new UsuarioModelss {
                    Nome = dados[0],
                    Email = dados[1],
                    Senha = dados[2],
                    DataNascimento = DateTime.Parse (dados[3]),
                };
                //Adicionando o usuario na linha
                lsUsuarios.Add (usuario);
            }
            return lsUsuarios;
        }
    }
}