using System;

namespace oneintro

{
    class Gestionhotel
    {
     public int habitacion { get; set; }
     public int huesped { get; set; }
     public int dias { get; set; }

        public int valorEstadia(int huesp,int cantid){
         int TINDIVIDUAL = 2500;
         int TDOBLE = 4600;
         int TFAMILIAR = 5200;

         int cobro =0;

         if(huesped == 1){
           cobro= cantid * TINDIVIDUAL;
         }
         else{
           if(huesped == 2){
            cobro=cantid * TDOBLE;
           }
         else{
           if(huesp >= 3){
           cobro= cantid * TFAMILIAR;
           }else{

           }
            
         }

         }

         return cobro;

        }
    
      public void cuentacobro(){

        int iva = 19;
        int preciosiniva = 0;
        int precioconiva = 0;
        preciosiniva= valorEstadia(huesped,dias);

        precioconiva = ((preciosiniva *iva) / 100) + preciosiniva;

        Console.WriteLine(precioconiva);



      }
        

      
      
}

}


