using Caelum.Stella.CSharp.Inwords;
using System.Diagnostics;

double valor = 75;
string extenso = new Numero(valor).Extenso();
Debug.WriteLine(extenso);

valor = 1532987;
extenso = new Numero(valor).Extenso();
Debug.WriteLine(extenso);

Debug.WriteLine(extenso + " reais");

string extensoBRL = new MoedaBRL(valor).Extenso();
Debug.WriteLine(extensoBRL);

valor = 1532987.89;
extensoBRL = new MoedaBRL(valor).Extenso();
Debug.WriteLine(extensoBRL);

valor = 1;
extensoBRL = new MoedaBRL(valor).Extenso();
Debug.WriteLine(extensoBRL);