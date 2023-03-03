class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese un número entero positivo mayor que cero
        Console.Write("Ingrese un número entero positivo mayor que cero: ");
        int n = int.Parse(Console.ReadLine());

        // Calcular el cuadrado de los números enteros positivos menores o iguales que N y almacenar cada resultado en un arreglo
        int[] cuadrados = new int[n];
        for (int i = 1; i <= n; i++)
        {
            cuadrados[i - 1] = i * i;
        }

        // Imprimir en la pantalla todos los números enteros positivos menores o iguales que N que sean primos
        Console.Write("Los números primos menores o iguales que {0} son: ", n);
        for (int i = 2; i <= n; i++)
        {
            bool esPrimo = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
            if (esPrimo)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();

        // Imprimir en la pantalla todos los números enteros positivos menores o iguales que N que sean múltiplos de 4
        Console.Write("Los múltiplos de 4 menores o iguales que {0} son: ", n);
        for (int i = 4; i <= n; i += 4)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();

        // Imprimir en la pantalla la secuencia de números enteros positivos que comienzan en 1 y se incrementan en 3 hasta que se alcance un valor mayor que N
        Console.Write("La secuencia de números enteros que comienzan en 1 y se incrementan en 3 hasta alcanzar un valor mayor que {0} es: ", n);
        int x = 1;
        while (x <= n)
        {
            Console.Write(x + ",");
            x += 3;

        }
        Console.Write(x);

        // Imprimir en la pantalla todos los valores del arreglo que contiene los cuadrados de los números enteros menores o iguales que N
        Console.Write("\nLos cuadrados de los números enteros menores o iguales que {0} son: ", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", cuadrados[i]);
        }
        Console.WriteLine();
    }
}
