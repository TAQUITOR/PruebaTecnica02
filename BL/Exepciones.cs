using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Exepciones
    {


        public ML.Result  IngresaNumero(dynamic NumeroEntero) {

            var result = new ML.Result();
            try
            {

                int valorEntero = NumeroEntero;

            }
            catch (Exception ex) {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.ex = ex;
            }


            return result;
        }




        [Serializable]
        public class SaldoInsuficienteException : Exception {

            public SaldoInsuficienteException()
            { }

            public SaldoInsuficienteException(string message)
                : base(message)
            { }

            public SaldoInsuficienteException(string message, Exception innerException)
                : base(message, innerException)
            { }
        }

    }
}
