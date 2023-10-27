class Program
{
    static void Main(string[] args) // Roberto Carlos Iglesias Álvarez U20230727
    {
        int opciones;
        do
        {
            Console.WriteLine("\n\n************************* Eliga una opción *************************");
            Console.WriteLine("1. Programa que muestra los numeros de n al 1 de manera descendente");
            Console.WriteLine("2. Programa que muestra los numeros de 1 al 5 con while. ");
            Console.WriteLine("3. Programa que muestra el numero minimo en una lista");
            Console.WriteLine("4. Salir. ");
            
            Console.Write("Seleccione una opcion (1-4): ");
            
            if (int.TryParse(Console.ReadLine(), out opciones))
            {
                switch (opciones)
                {
                    case 1:
                        numerosDecententes();
                        break;
                    case 2:
                        NumerosWhile();
                        break;
                    case 3:
                        MinimoLista();
                        break;
                    case 4:
                        Console.WriteLine("\nSalida con exito =)\n");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nValor no valido, por favor ingrese un numero valido.\n");
            }
        } while (opciones != 4);
    }

    static void numerosDecententes()
    {
        Console.Write("\nIngrese un numero (n): ");
        int n=Convert.ToInt32(Console.ReadLine());

            if (n >= 1)
            {
                for (int i =n; i >= 1; i--)
                {
                    Console.WriteLine($"Número > {i}");
                }
            }
            else{
                Console.WriteLine("Ingrese un numero mayor a 1 ");
                }
    }//Fin de numeros decendentes

    static void NumerosWhile(){
        int contador = 1; 

            while (contador <= 5 )
            {
                {
                    Console.WriteLine($"Numero >>{contador}");
                    contador++;
                }
            }

    }//Fin de numeros while.

    static void MinimoLista(){
        List<int> numeros = new List <int> {24, 15, 45, 35, 14,10 };

        int minimo = numeros[0]; // Iniciador con valor de indice 0

            foreach(int numero1 in numeros)
            {
                if (numero1 < minimo){
                    minimo = numero1; //actualizar el valor minimo.
                }
            }
           Console.WriteLine("El numero más pequeño en la lista es >> " + minimo); 
    }//Fin de minimolista

}

