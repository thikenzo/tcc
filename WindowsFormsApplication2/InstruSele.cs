using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class InstruSele
    {
        public String Data { get; set; }
        public String Nome { get; set; }

        public InstruSele() { }

        public InstruSele(String pData, String pNome)

        {
            this.Data = pData;
            this.Nome = pNome;
        }


    }
}
