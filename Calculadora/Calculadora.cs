using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_TP
{
    class Calculadora
    {
      double numero1;
      double numero2;

        //getters e setters
        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }

         public double Soma()
        {
          double resultado = Numero1 + Numero2;
          return (resultado);
        }
        
        public double Subtrai()
        {
          double resultado = this.Numero1 - this.Numero2;
            return (resultado);  
        }

        public double Multiplica()
        {
            double resultado = this.Numero1 * this.Numero2;
            return (resultado);
        }

        public double Div()
        {
            double resultado = this.Numero1 / this.Numero2;
            return (resultado);
        }

        public double Expo()
        {
            double resultado = Math.Pow(this.Numero1, this.Numero2);
            return (resultado);
        }
    }
}
