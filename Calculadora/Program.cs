using Calculadora.Operacoes.Somar;

Somar c = new Somar();
{
List<double> resultados = new List<double>();
{

int num1 = 5;
int num2 = 10;
int num3 = 25;

Console.WriteLine($"{num1} + {num2} = {c.somar(num1,num2)}");

       double resultado1 = c.somar(num1, num2);
       resultados.Add(resultado1);
       double resultado2 = c.somar(num1, num2);
      resultados.Add(resultado2);
      double resultado3 = c.somar(num1, num3);
      resultados.Add(resultado3);
      double resultado4 = c.somar(num1, num3);
       resultados.Add(resultado4);
      
       Console.WriteLine("Resultados dos cálculos:");
       foreach (var resultado in resultados)
       {
           Console.WriteLine(resultado);
        }
    }    
}      