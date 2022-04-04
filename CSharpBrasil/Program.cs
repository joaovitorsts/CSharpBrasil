// See https://aka.ms/new-console-template for more information
using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System.Diagnostics;

string cpf1 = "86288366757";
string cpf2 = "98745366797";
string cpf3 = "22222222222";

ValidarCPF(cpf1);
ValidarCPF(cpf2);
ValidarCPF(cpf3);

string cnpj1 = "36176230000153";
string cnpj2 = "07711011000127";

ValidarCNPJ(cnpj1);
ValidarCNPJ(cnpj2);

string titulo1 = "524025410906";
string titulo2 = "748581200904";

ValidarTitulo(titulo1);
ValidarTitulo(titulo2);

Debug.WriteLine(cpf1);
Debug.WriteLine(new CPFFormatter().Format(cpf1));
Debug.WriteLine(new CPFFormatter().Unformat(cpf1));

static void ValidarCPF(string cpf) {
    if(new CPFValidator().IsValid(cpf))
        Debug.WriteLine("CPF válido: " + cpf);
    else
        Debug.WriteLine("CPF inválido: " + cpf);
}

static void ValidarCNPJ(string cnpj)
{
    if (new CNPJValidator().IsValid(cnpj))
        Debug.WriteLine("CNPJ válido: " + cnpj);
    else
        Debug.WriteLine("CNPJ inválido: " + cnpj);
}

static void ValidarTitulo(string titulo)
{
    if (new TituloEleitoralValidator().IsValid(titulo))
        Debug.WriteLine("Título válido: " + titulo);
    else
        Debug.WriteLine("Título inválido: " + titulo);
}