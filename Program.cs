namespace calculadora;
class Program
{
    static void Main(string[] args)
    {
        int numero1; //declaracion
        int numero2;
        int resultado;
        int opcion;

        Console.WriteLine ("señor usuario  ingresar numero para poder operar" );
        Console.WriteLine ("1.suma");
        Console.WriteLine ("2.resta");
        Console.WriteLine ("3.multiplicacion");
        Console.WriteLine ("4.divicion");
        opcion= Convert.ToInt32( Console.ReadLine());

        switch( opcion ){
            case 1:
                Console.WriteLine("señor ingrese un numero");
              
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("NUMERO2:");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 + numero2;
                System.Console.WriteLine("El resultado es:" +resultado);
            break;
            

            case 2:
                Console.WriteLine("NUMERO1:");
            
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("NUMERO2:");
                numero2 = int.Parse(Console.ReadLine());

                resultado = numero1 - numero2;
                System.Console.WriteLine("El resultado es:" + resultado);

            break;

             case 3:
                Console.WriteLine("señor ingrese un numero");
              
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("NUMERO2:");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 * numero2;
                System.Console.WriteLine("El resultado es:" +resultado);
            break;

             case4:
                Console.WriteLine("señor ingrese un numero");
              
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("NUMERO2:");
                numero2 = Convert.ToInt32(Console.ReadLine());
                resultado = numero1 / numero2;
                System.Console.WriteLine("El resultado es:" +resultado);
            break;

            //para multiplicar uso aterisco * 
            // para dividir uso /

        }

       
        
       

         
       
    }    
}
