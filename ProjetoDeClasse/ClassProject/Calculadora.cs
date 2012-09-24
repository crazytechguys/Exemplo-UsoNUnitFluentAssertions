using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDeClasse
{
    public class Calculadora
    {
        
        public Calculadora()
        {
        
        }

        public decimal Soma(decimal primeiro, decimal segundo)
        {
            return primeiro + segundo;
        }
        public decimal Subtracao(decimal primeiro, decimal segundo)
        {
            return primeiro - segundo;
        }

        public decimal Divisao(decimal dividendo, decimal divisor)
        {
            return dividendo / divisor;
        }

        public decimal Sub(decimal first, decimal Second)
        {
            return first - Second; 
        }
    
    }
}
