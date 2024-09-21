namespace Calculadora.Operacoes.Somar

{
    public class Somar
    {
        private List<string>listahistorico;

        public Somar()
        {
            listahistorico = new List<string>();
            
        }

        public int somar(int num1 ,int num2) {

            int res = num1 + num2;
            listahistorico.Insert(0, "Res:" + res);
            return num1 + num2;

        }
    public List<string> historico()
    {
                
        listahistorico.RemoveRange(3, listahistorico.Count - 3);
        return listahistorico;
        
      }           
    }
}
