using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unifacisa.si.dotnet.app.dados;

namespace NegociosApp
{
    public class GerenteDePessoas
    {
        public void Adiciona(Pessoa pessoa)
        {
            pessoa.cpf = "123456";
            string var = pessoa.cpf;
        }
    }
}
