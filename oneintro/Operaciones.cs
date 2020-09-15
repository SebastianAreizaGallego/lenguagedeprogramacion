using System;

namespace ejemplointro1
{
     class Operaciones
     {
        //atributos (propiedades)
        public   int numeroUno { get; set; }
        //public es el modificador de acceso
        // int es el tipo de dato 
        // numeroUno nombre propiedad (atributo)
        // { get; set; } metodo para recibir (set) y pra entregar (get)
        public int numeroDos {get; set;}


        //metodos (funciones)
        // public void nuestraSuma(int n1, int n2)
         /*{

        //public es el modificador de acceso
        // tiene tipo de retorno
        //nombre metodo
        // va tener (argu o param)
           int suma = n1 + n2;
           Console.WriteLine( $"La suma de {n1} y {n2} es {suma}");
         }*/

         //separar responsabilidades en los metodos
         
         public int calcularSuma(int n1, int n2)
         {
            int resultadoSuma = 0;
            resultadoSuma = n1 + n2;
            return resultadoSuma;

         }
       public void imprimirSuma(){

           Console.WriteLine(
            "la suma es " +
            calcularSuma(numeroUno, numeroDos)
           );
       }

     }
}