using System;
using System.Collections.Generic;
using System.IO;
using Programa.Modelss;

namespace Programa.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioViewModel BuscarPorEmailESenha(string email ,string senha){
            List<UsuarioViewModel> usuariosCadastrados = CarregarDoCSV();
            //percorro cada usuario da lista
            foreach (UsuarioViewModel  usuario in usuariosCadastrados)
            {
                if (usuario.Email == email && usuario.Senha == senha )
                {
                    return usuario;
                }
            }
            
            return null;
        }
        private List<UsuarioViewModel> CarregarDoCSV () {
            List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel> ();
            //Abre o stream de leitura do arquivo CSV
            string[] linhas = File.ReadAllLines ("usuarios.csv");
            //Lê cada registro 
            foreach (string linha in linhas) {
                //Separa os dados da linha
                string[] dados = linha.Split (";");
                //cria o objeto com os dados da linha
                UsuarioViewModel usuario = new UsuarioViewModel {
                    ID = int.Parse(dados[0]),
                    Nome = dados[1],
                    Email = dados[2],
                    Senha = dados[3],
                    DataCriacao = DateTime.Parse (dados[4]),
                };
                //Adicionando o usuario na linha
                lsUsuarios.Add (usuario);
            }
            return lsUsuarios;
        }
    }
}