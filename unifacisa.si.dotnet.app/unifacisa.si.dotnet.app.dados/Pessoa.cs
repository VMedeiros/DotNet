using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unifacisa.si.dotnet.app.dados
{
    public class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public List<Telefone> Telefones { get; set; }

}
}
