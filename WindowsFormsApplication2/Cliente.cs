using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// GRID PEGA DADOS QUE ESTÃO AQUI NO CONSULTA CLIENTE
/// </summary>


namespace WindowsFormsApplication2
{
    public class Cliente
    {
        public Int64 Id { get; set; }
        public String Nome { get; set; }

        public String Telefone { get; set; }
        public String Celular { get; set; }
        public String Email { get; set; }
        public String Endereco { get; set; }
        public String N { get; set; }
        public String Bairro { get; set; }
        public String Rg { get; set; }
        public String Cpf { get; set; }
        public String NivelAcesso { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }





        public Cliente() { }

        public Cliente(Int64 pId, String pNome, String pTelefone, String pCelular,
            String pEmail, String pEndereco, String pN, String pBairro, String pRg,
            String pCpf, String pLogin, String pSenha, String pNivelAcesso)


        {
            this.Id = pId;
            this.Nome = pNome;
            this.Telefone = pTelefone;
            this.Celular = pCelular;
            this.Email = pEmail;
            this.Endereco = pEndereco;
            this.N = pN;
            this.Bairro = pBairro;
            this.Rg = pRg;
            this.Cpf = pCpf;
            this.NivelAcesso = pNivelAcesso;
            this.Login = pLogin;
            this.Senha = pSenha;




        }
    }

}

