using System; 

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaOrigem = new ContaInvestimento(10);

            var a = ConverteConta<ContaInvestimento, ContaCorrente>(contaOrigem);

            Console.ReadLine();
            
        }

        public static G ConverteConta<T, G>(T contaOrigem) where T : Conta where G : Conta
        {
            var b = Activator.CreateInstance<G>();
            b.Numero = contaOrigem.Numero;
            b.Saldo = contaOrigem.Saldo;
            b.Agencia = contaOrigem.Agencia;

            return b;
            
        }

    }
}
