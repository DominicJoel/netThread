using System;

namespace Thread
{
    class Program
    {
        //El hilo es un proceso que se ejecuta (Static void main) es el hilo principal
        //Los hilos funciona para compartir trabajo osea trabajar de forma paralela y ahorrar tiempo
        //Siempre que hagamos procesos que necesiten trabajo con paralelo como enviar 100 correos (Que tarden 1 min cada uno), podemos tener 6 hios que estéen enviado correos.
        // Debo tener cuidado porque demasiado hilos afectaria. 
       
        
        public static void Cantinero1Atiende() 
        {
            for(int i = 0; i<100; i++)
            {
                Console.WriteLine("Cantinero 1 Sirve:"+ i +"cerveza" );
            }
            
        }

        public static void Cantinero2Atiende()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Cantinero 2 Sirve:" + i + "cerveza");
            }
        }

        static void Main(string[] args)
        {
            //* Sin hilos *//
            // Al solo manejar un hilo el proceso funciona en secuencia , primero el cantinero 1 y luego el 2
           // Cantinero1Atiende(); // Cuando lo ejecutamos es parte del proceso principal porque no hay mas otros hilos, siempre lo ejecutará en el principal
           // Cantinero2Atiende();

            /* Con hilos */
            // Al controlar los hilos se peuden hacer procesos de manera simultanea
            System.Threading.Thread cantinero1 = new System.Threading.Thread(new System.Threading.ThreadStart(Cantinero1Atiende));
            System.Threading.Thread cantinero2 = new System.Threading.Thread(new System.Threading.ThreadStart(Cantinero2Atiende));


            cantinero1.Start(); //Aqui inica los hilos
            cantinero2.Start();

        }
    }
}
