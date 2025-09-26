using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CuentaBancaria
    {

        private decimal Saldo { get; set; }


        public void Depositar(decimal monto) { 

            Saldo += monto;

        }

        public void Consultar() {

            Console.WriteLine(Saldo);
        }

        public void Retirar(decimal monto) {

            if (monto > Saldo)
            {
                throw new BL.Exepciones.SaldoInsuficienteException("Tu sueldo es insuficiente");
            }
            else {
                Saldo -= monto;
                Console.WriteLine(Saldo);

            }

               
        }




    }
}
