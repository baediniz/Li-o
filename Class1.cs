using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Calculadora
    {
        public double v1 { get; set; }  
        public double v2 { get; set; }

        public double resultado { get; set; }
        public char operacao { get; set; }

        public void Calcular()
        {
            switch (this.operacao)
            {
                case '+':
                    resultado = v1 + v2;
                    break;

                case '-':
                    resultado = v1 - v2;
                    break;

                case '*':
                    resultado = v1 * v2;
                    break;

                case '/':
                    resultado = v1 / v2;
                    break;
            }
           
            
            
            

        }

    }
}
