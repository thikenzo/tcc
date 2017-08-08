using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
   public class Instrum
    {
        public Int64 Id { get; set; }
        public String NomeEquip { get; set; }
        public String Classificacao { get; set; }
        public String Tipo { get; set; }
        public String valor { get; set; }
        public String Situacao { get; set; }





        public Instrum() { }

        public Instrum(Int64 pId, String pNomeEquip, String pClassificacao, String pTipo, String pValor, String pSituacao)


        {
            this.Id = pId;
            this.NomeEquip = pNomeEquip;
            this.Classificacao = pClassificacao;
            this.Tipo = pTipo;
            this.valor = pValor;
            this.Situacao = pSituacao;

        }
    }
    
    public class Instrum1
    {
        public String NomeEquip { get; set; }
        public String Tipo { get; set; }
        public String Valor { get; set; }






        public Instrum1() { }

        public Instrum1( String pNomeEquip, String pTipo, String pValor)


        {
            this.NomeEquip = pNomeEquip;
            this.Tipo = pTipo;
            this.Valor = pValor;
        }
    }

    public class Instrum2
    {
        public String NomeEquip { get; set; }
        public String Tipo { get; set; }
        public String Valor { get; set; }






        public Instrum2() { }

        public Instrum2(String pNomeEquip, String pTipo, String pValor)


        {
            this.NomeEquip = pNomeEquip;
            this.Tipo = pTipo;
            this.Valor = pValor;
        }
    }

    public class Instrum3
    {
        public Int64 Id { get; set; }
        public String NomeSala { get; set; }
        public String Identificacao { get; set; }
        public String Tamanho { get; set; }
        public String Valor { get; set; }
        public String Situacao { get; set; }





        public Instrum3() { }

        public Instrum3(Int64 pId, String pNomeSala, String pIdentificacao, String pTamanho, String pValor, String pSituacao)


        {
            this.Id = pId;
            this.NomeSala = pNomeSala;
            this.Identificacao = pIdentificacao;
            this.Tamanho = pTamanho;
            this.Valor = pValor;
            this.Situacao = pSituacao;
        }
    }


}
