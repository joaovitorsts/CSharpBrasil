using Caelum.Stella.CSharp.Http;
using System.Diagnostics;

string cep = "89215101";
string result = GetEndereco(cep);

Debug.WriteLine(result);

ViaCEP viaCep = new ViaCEP();
string enderecoJson = viaCep.GetEnderecoJson(cep);
Debug.WriteLine(enderecoJson);

string enderecoXml = viaCep.GetEnderecoXml(cep);
Debug.WriteLine(enderecoXml);

var task = viaCep.GetEnderecoJsonAsync(cep);
Debug.WriteLine(task.Result);

var endereco = viaCep.GetEndereco(cep);
Debug.WriteLine(string.Format("Logradouro: {0}, Bairro: {1}", endereco.Logradouro, endereco.Bairro));

static string GetEndereco(string cep)
{
    string url = "https://viacep.com.br/ws/" + cep + "/json/";
    string result = new HttpClient().GetStringAsync(url).Result;
    return result;
}