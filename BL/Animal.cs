using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Animal
    {

        public virtual void HacerSonido() {
            Console.WriteLine("El animal hace un sonido");
        }

    }


    public class Perro : Animal
    {
        public  override void HacerSonido() {
            Console.WriteLine("El perro ladra");
        }
    }

    public class Gato : Animal
    {
        public override void HacerSonido() {
            Console.WriteLine("El gato maulla");
        }
    }

}
