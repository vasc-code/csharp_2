using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor
            object caixa = numero;

            try
            {
                int unboxed = (int)caixa;
                Console.WriteLine(unboxed);

                System.Console.WriteLine("Unboxing Ok.");

            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Erro: unboxing incorreto.", e);
            
            }
        }
    }
}
