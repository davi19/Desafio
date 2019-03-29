using System;
using System.Net.Http;
using System.Threading.Tasks;
using Desafio.Model;
using Newtonsoft.Json.Linq;

namespace Desafio.ClassesAuxiliares
{
    class BuscaCep
    {
        public async Task<Endereco> Localizar(string cep)
        {
               
                Endereco enderecoBuscado = new Endereco();
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress= new Uri("https://viacep.com.br/ws/"+cep+"/json/");
                var resposta =   cliente.GetAsync(cliente.BaseAddress).Result;
                var stringJson = await resposta.Content.ReadAsStringAsync();
                var enderecoJson = JObject.Parse(stringJson) ;

                enderecoBuscado.Cidade = enderecoJson["localidade"].ToString();
                enderecoBuscado.Rua = enderecoJson["logradouro"].ToString();
                enderecoBuscado.Bairro = enderecoJson["bairro"].ToString();
                enderecoBuscado.Estado = enderecoJson["uf"].ToString();
                return enderecoBuscado;
        }
    }
}
