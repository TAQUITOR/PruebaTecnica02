// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");







BL.Animal miAnimal = new BL.Animal();
miAnimal.HacerSonido();

Console.WriteLine("-----");
BL.Animal animalPerro = new BL.Perro();
animalPerro.HacerSonido();


BL.Perro perro = new BL.Perro();
perro.HacerSonido();

BL.Gato gato = new BL.Gato();
gato.HacerSonido();

// Polimorfismo
//Lista de animales

List<BL.Animal> animales = new List<BL.Animal>();
animales.Add(new BL.Perro());
animales.Add(new BL.Gato());

animales.ForEach(a => a.HacerSonido());

//Console.WriteLine("------------");
//Console.WriteLine("Ingresa un numero entero");
//var input = Console.ReadLine();
//BL.Exepciones exepciones = new BL.Exepciones();
//var result = exepciones.IngresaNumero(input);
//if (result.Correct)
//{
//    Console.WriteLine("Gracias por seguir las instrucciones");
//}
//else {
//    Console.WriteLine(result.ErrorMessage);
//    Console.WriteLine(result.ex);
//    Console.WriteLine("TESTTTTT");
//}


BL.CuentaBancaria cuenta = new BL.CuentaBancaria();
cuenta.Depositar(10);
cuenta.Consultar();
cuenta.Retirar(11);