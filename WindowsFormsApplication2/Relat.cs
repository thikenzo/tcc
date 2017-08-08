using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Relat
    {
        public Int64 Id { get; set; }
        public String Data { get; set; }
        public String Hora { get; set; }
        public String Cliente { get; set; }
        public String Projeto { get; set; }
        public String Servico { get; set; }
        public String Sala { get; set; }
        public String Descricao { get; set; }





        public Relat() { }

        public Relat(Int64 pId, String pData, String pHora, String pCliente, String pProjeto, String pServico, String pSala, String pDescricao)


        {
            this.Id = pId;
            this.Data = pData;
            this.Hora = pHora;
            this.Cliente = pCliente;
            this.Projeto = pProjeto;
            this.Servico = pServico;
            this.Sala = pSala;
            this.Descricao = pDescricao;


        }
    }
}
    
