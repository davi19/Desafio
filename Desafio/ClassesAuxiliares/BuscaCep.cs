using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Net;

namespace Desafio.Classes
{
    class BuscaCep
    {
        public Address Localizar(string Cep)
        {
                Address endereco = SearchZip.GetAddress(Cep);
                if (endereco == null)
                {
                    return null;
                }
                else
                {
                    return endereco;
                }
            
        }
    }
}
