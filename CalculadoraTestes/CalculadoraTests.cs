using Calculadora.Operacoes.Multiplicacao;
using Calculadora.Operacoes.Subtracao;
using Calculadora.Operacoes.Somar;
using System.ComponentModel;

namespace CalculadoraTestes;

public class CalculadoraTests{
    
      private Multiplicar _calcmultiplicar;
      private Subtrair _calcsubtracao;
      private Somar _calcsomar;      
      

    public CalculadoraTests()
        {        
         _calcmultiplicar = new Multiplicar();
         _calcsubtracao = new Subtrair();
         _calcsomar = new Somar();         
         
        }  

         [Fact]
        public void DeveSomar5Com10ERetornar15()
        {

        int valor1 = 5;
        int valor2 = 10;
        
        int resultado = _calcsomar.somar(valor1, valor2);        

        Assert.Equal(15, resultado);
    }     

        [Fact]
        public void DeveSubtrais5VDe10eRetornar5()
    {

        int valor1 = 10;
        int valor2 = 5;

        int resultado = _calcsubtracao.subtracao(valor1, valor2);

        Assert.Equal(5, resultado);
    }  


         [Fact]
        public void DeveMultiplicar5Vezes10eRetornar50()
    {

        int valor1 = 5;
        int valor2 = 10;

        int resultado = _calcmultiplicar.multiplicacao(valor1, valor2);

        Assert.Equal(50, resultado);
    }    

     [Fact]
        public void Historico3UltimosRegistros()
    {        
        //var lista = _calcsomar.historico();

        _calcsomar.somar(700,1);
        _calcsomar.somar(2050,1);
        _calcsomar.somar(7,1);
        _calcsomar.somar(22,1); 
        _calcsomar.somar(7,1);
        _calcsomar.somar(22,1);     

        var lista = _calcsomar.historico();    
        // Log
        Console.WriteLine($"Resultado da soma: {lista}");

        Assert.NotEmpty(_calcsomar.historico());
        Assert.Equal(3, lista.Count);
        
        
    }   
}