//Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números
//primos. 

using System;

class Program
{
    static void Main()
    {
        int num = 3; // Cambia este valor según tus necesidades
        if (EsPrimo(num))
        {
            Console.WriteLine("Es un número primo");
        }
        else
        {
            Console.WriteLine("No es un número primo");
        }
    }

    static bool EsPrimo(int numero)
    {
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
//Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//comienzan con una letra determinada

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> conjuntoDePalabras = new HashSet<string>
        {
            "manzana", "banana", "pera", "uva", "sandía", "limón"
        };

        char letraDeterminada = 'm'; // Cambia esta letra según tus necesidades

        HashSet<string> palabrasComienzanConLetra = FiltrarPalabrasPorLetra(conjuntoDePalabras, letraDeterminada);

        Console.WriteLine("Palabras que comienzan con la letra '{0}':", letraDeterminada);
        foreach (var palabra in palabrasComienzanConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPalabrasPorLetra(HashSet<string> palabras, char letra)
    {
        return palabras.Where(palabra => palabra.StartsWith(letra.ToString())).ToHashSet();
    }
}
//Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//son divisibles por un número determinado.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<int> numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int divisor = 3;

        HashSet<int> divisibles = ObtenerNumerosDivisibles(numeros, divisor);

        Console.WriteLine("Números divisibles por " + divisor + ": " + string.Join(", ", divisibles));
    }

    static HashSet<int> ObtenerNumerosDivisibles(HashSet<int> numeros, int divisor)
    {
        HashSet<int> numerosDivisibles = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (numero % divisor == 0)
            {
                numerosDivisibles.Add(numero);
            }
        }

        return numerosDivisibles;
    }
}
//Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
//están en ambos conjuntos.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> numerosEnAmbos = ObtenerNumerosEnAmbosConjuntos(conjunto1, conjunto2);

        Console.WriteLine("Números en ambos conjuntos: " + string.Join(", ", numerosEnAmbos));
    }

    static HashSet<int> ObtenerNumerosEnAmbosConjuntos(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        // La intersección de dos conjuntos se puede obtener directamente con el método IntersectWith
        HashSet<int> interseccion = new HashSet<int>(conjunto1);
        interseccion.IntersectWith(conjunto2);

        return interseccion;
    }
}

//Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
//están en el primer conjunto pero no en el segundo.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> diferencia = ObtenerDiferenciaExcepto(conjunto1, conjunto2);

        Console.WriteLine("Números en el primer conjunto pero no en el segundo: " + string.Join(", ", diferencia));
    }

    static HashSet<int> ObtenerDiferenciaExcepto(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        // La diferencia excepto se puede obtener directamente con el método ExceptWith
        HashSet<int> diferencia = new HashSet<int>(conjunto1);
        diferencia.ExceptWith(conjunto2);

        return diferencia;
    }
}

//6. Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que
//están en el segundo conjunto pero no en el primero.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> diferenciaSimetrica = ObtenerDiferenciaSimetrica(conjunto1, conjunto2);

        Console.WriteLine("Números en el segundo conjunto pero no en el primero: " + string.Join(", ", diferenciaSimetrica));
    }

    static HashSet<int> ObtenerDiferenciaSimetrica(HashSet<int> conjunto1, HashSet<int> conjunto2)
    {
        // La diferencia simétrica se puede obtener indirectamente combinando ExceptWith y UnionWith
        HashSet<int> diferenciaSimetrica = new HashSet<int>(conjunto2);
        diferenciaSimetrica.ExceptWith(conjunto1);

        return diferenciaSimetrica;
    }
}

//7. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son anagramas.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso
        HashSet<string> palabras = new HashSet<string> { "amor", "roma", "mora", "ramo", "hola", "aloh", "lama", "mala" };
        HashSet<string> anagramas = ObtenerAnagramas(palabras);
        foreach (var palabra in anagramas)
        {
            Console.WriteLine(palabra);
        }
        
//8. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son palíndromos.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<string> palabras = new HashSet<string> { "radar", "somos", "palindromo", "reconocer", "oso" };

        HashSet<string> palindromos = ObtenerPalindromos(palabras);

        Console.WriteLine("Palíndromos encontrados: " + string.Join(", ", palindromos));
    }

    static HashSet<string> ObtenerPalindromos(HashSet<string> palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        return palindromos;
    }

    static bool EsPalindromo(string palabra)
    {
        int i = 0;
        int j = palabra.Length - 1;

        while (i < j)
        {
            if (palabra[i] != palabra[j])
            {
                return false;
            }

            i++;
            j--;
        }

        return true;
    }
}

//9. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//tienen una longitud determinada.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso
        HashSet<int> numeros = new HashSet<int> { 5, 3, 9, 1, 7, 2, 8, 4, 6, 0 };
        List<int> resultado = ObtenerNumerosOrdenados(numeros);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
        // Salida esperada: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
    }

    public static List<int> ObtenerN

//10. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//contienen una letra determinada.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<string> palabras = new HashSet<string> { "hola", "mundo", "programación", "casa", "barco" };
        char letraBuscada = 'a';

        HashSet<string> palabrasConLetra = ObtenerPalabrasConLetra(palabras, letraBuscada);

        Console.WriteLine("Palabras que contienen la letra 'a': " + string.Join(", ", palabrasConLetra));
    }

    static HashSet<string> ObtenerPalabrasConLetra(HashSet<string> palabras, char letra)
    {
        HashSet<string> palabrasConLetra = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasConLetra.Add(palabra);
            }
        }

        return palabrasConLetra;
    }
}

//11. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están ordenados de menor a mayor.
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso
        HashSet<int> numeros = new HashSet<int> { 5, 3, 9, 1, 7, 2, 8, 4, 6, 0 };
        List<int> resultado = ObtenerNumerosOrdenados(numeros);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
        // Salida esperada: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
    }

    public static List<int> ObtenerN


//12. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están ordenados de mayor a menor.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        HashSet<int> numeros = new HashSet<int> { 3, 1, 4, 2, 5 };

        HashSet<int> numerosOrdenados = ObtenerConjuntoOrdenadoMayorAMenor(numeros);

        Console.WriteLine("Números ordenados de mayor a menor: " + string.Join(", ", numerosOrdenados));
    }

    static HashSet<int> ObtenerConjuntoOrdenadoMayorAMenor(HashSet<int> conjunto)
    {
        // Convertir el conjunto a una lista para poder ordenarla
        List<int> listaNumeros = new List<int>(conjunto);

        // Ordenar la lista de mayor a menor
        listaNumeros.Sort((a, b) => b.CompareTo(a));

        // Convertir la lista ordenada de nuevo a un conjunto
        HashSet<int> conjuntoOrdenado = new HashSet<int>(listaNumeros);

        return conjuntoOrdenado;
    }
}

//13. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están duplicados.
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 3, 6, 7, 2, 8, 9, 0, 1 };
        HashSet<int> duplicados = ObtenerNumerosDuplicados(numeros);
        foreach (var numero in duplicados)
        {
            Console.WriteLine(numero);
        }
        // Salida esperada: 1, 2, 3
    }

    public static HashSet<int> ObtenerNumerosDup;


//14. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//no están duplicados.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ejemplo de uso con una lista que puede contener duplicados
        List<int> numerosConDuplicados = new List<int> { 1, 2, 2, 3, 4, 4, 5, 5, 5 };

        HashSet<int> numerosSinDuplicados = ObtenerConjuntoSinDuplicados(numerosConDuplicados);

        Console.WriteLine("Números sin duplicados: " + string.Join(", ", numerosSinDuplicados));
    }

    static HashSet<int> ObtenerConjuntoSinDuplicados(List<int> listaNumeros)
    {
        HashSet<int> conjuntoSinDuplicados = new HashSet<int>(listaNumeros);
        return conjuntoSinDuplicados;
    }
}


//15. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//son primos y están ordenados de menor a mayor.

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso
        HashSet<int> numeros = new HashSet<int> { 29, 1, 15, 3, 22, 5, 17, 6, 8, 23, 19, 11, 13 };
        List<int> primosOrdenados = ObtenerPrimosOrdenados(numeros);
        foreach (var numero in primosOrdenados)
        {
            Console.WriteLine(numero);
        }
        // Salida esperada: 3, 5, 11, 13, 17, 19, 23, 29
    }

}

//16. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son palíndromos y están ordenadas de menor a mayor.

using System;
using System.Linq;
using System.Collections.Generic;

namespace PalindromeChecker
{
    class Program
    {
        public static bool IsPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }

        static void Main(string[] args)
        {
            string[] words = { "racecar", "hello", "madam", "world" };
            var palindromes = new SortedSet<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine("Palíndromos ordenados:");
            foreach (var palindrome in palindromes)
            {
                Console.WriteLine(palindrome);
            }
        }
    }
}


//17. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//tienen una longitud determinada y están ordenadas de menor a mayor.
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Ejemplo de uso
        HashSet<string> palabras = new HashSet<string> { "amor", "roma", "mora", "ramo", "hola", "aloh", "lama", "mala", "casa", "perro", "sol", "día" };
        int longitud = 4;
        List<string> resultado = ObtenerPalabrasConLongitudOrdenadas(palabras, longitud);
        foreach (var palabra in resultado)
        {
            Console.Writ
//18. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//contienen una letra determinada y están ordenadas de mayor a menor.
using System;
using System.Collections.Generic;
using System.Linq;

namespace PalabrasConLetra
{
    class Program
    {
        public static HashSet<string> PalabrasConLetra(IEnumerable<string> palabras, char letra)
        {
            var resultado = new HashSet<string>();

            foreach (var palabra in palabras)
            {
                if (palabra.Contains(letra))
                {
                    resultado.Add(palabra);
                }
            }

            return resultado.OrderByDescending(p => p.Length).ToHashSet();
        }

        static void Main(string[] args)
        {
            var palabras = new List<string>
            {
                "casa",
                "perro",
                "gato",
                "elefante",
                "ratón"
            };

            char letraBuscada = 'a'; // Cambia la letra según tus necesidades

            var palabrasFiltradas = PalabrasConLetra(palabras, letraBuscada);

            Console.WriteLine($"Palabras con la letra '{letraBuscada}':");
            foreach (var palabra in palabrasFiltradas)
            {
                Console.WriteLine(palabra);
            }
        }
    }
}


//19. Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que
//están ordenados de menor a mayor y que no están duplicados.

using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdenarNumeros
{
    class Program
    {
        public static SortedSet<int> OrdenarSinDuplicados(IEnumerable<int> numeros)
        {
            return new SortedSet<int>(numeros.Distinct());
        }

        static void Main(string[] args)
        {
            var numeros = new List<int> { 7, 2, 4, 8, 3, 9, 1, 5, 10, 6 };

            var numerosOrdenados = OrdenarSinDuplicados(numeros);

            Console.WriteLine("Números ordenados sin duplicados:");
            foreach (var numero in numerosOrdenados)
            {
                Console.WriteLine(numero);
            }
        }
    }
}



//20. Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que
//son palíndromos, tienen una longitud determinada y están ordenadas de menor a mayor.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromos
{
    class Program
    {
        public static bool EsPalindromo(string palabra)
        {
            string palabraReversa = new string(palabra.Reverse().ToArray());
            return palabra == palabraReversa;
        }

        public static SortedSet<string> FiltrarPalindromosPorLongitud(IEnumerable<string> palabras, int longitud)
        {
            var palindromosFiltrados = new SortedSet<string>();

            foreach (var palabra in palabras)
            {
                if (EsPalindromo(palabra) && palabra.Length == longitud)
                {
                    palindromosFiltrados.Add(palabra);
                }
            }

            return palindromosFiltrados;
        }

        static void Main(string[] args)
        {
            var palabras = new List<string>
            {
                "reconocer",
                "salas",
                "oso",
                "anilina",
                "radar"
            };

            int longitudDeseada = 5; // Cambia la longitud según tus necesidades

            var palindromosOrdenados = FiltrarPalindromosPorLongitud(palabras, longitudDeseada);

            Console.WriteLine($"Palíndromos de longitud {longitudDeseada} ordenados:");
            foreach (var palindromo in palindromosOrdenados)
            {
                Console.WriteLine(palindromo);
            }
        }
    }
}
