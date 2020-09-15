using System;

namespace oneintro
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("hotel word");

            Console.WriteLine("cantidad de huespedes");
            int huespedes = int.Parse(Console.ReadLine());
            Console.WriteLine("dias de estadia");
            int cant_dias = int.Parse(Console.ReadLine());
            Console.WriteLine("nombre  habitaciones");
            string nom_hab = Console.ReadLine();

            var hoteluno = new Gestionhotel(){
                   habitacion = nom_hab,
                   huesped = huespedes,
                   dias = cant_dias

            };
            hoteluno.cuentacobro();
             
            /*forma estructurada

            //Console.WriteLine("el numero es: " + numUno);
            //Console.WriteLine( $"el numero es: {numUno}");

            //int suma = numUno + numDos;
            //Console.WriteLine($"La suma de {numUno} y {numDos} es {suma}");

            Console.WriteLine($"La suma de {numUno} y {numDos} es {numUno + numDos}");
            */

            //forma orientada a objetos
            //instanciar la class Operaciones (un objeto de la class operaciones)
            
            //para instanciar  
            //primero se hace la class
            //despues objeto(distancia)
            // (= new) son palabras reservadas
            // el constructor de la clase()
            //Operaciones myOperacion = new Operaciones();
            //var myOperacion = new Operaciones(){
             //numeroUno = numUno,
             //numeroDos = numDos

            //};
            
            //verificar (mostrar) el valor que tiene almacenado la propiedad
            //Console.WriteLine( myOperacion.numeroUno);
            //llevar valor como parametro a un metodo
            //para hacer esto llamar el metodo de la clss
            //mediante un objeto

            //myOperacion.nuestraSuma(myOperacion.numeroUno, myOperacion.numeroDos);

        }
    }

    
}
