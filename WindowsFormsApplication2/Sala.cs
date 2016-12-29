using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Sala
    {
        public Int64 Id { get; set; }
        public String NomeSala { get; set; }
        public String Identificacao { get; set; }
        public String Tamanho { get; set; }
        public String Valor { get; set; }
        public String Situacao { get; set; }





        public Sala() { }

        public Sala(Int64 pId, String pNomeSala, String pIdentificacao, String pTamanho, String pValor, String pSituacao)


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
