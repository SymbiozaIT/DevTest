using System;
using System.Collections.Generic;
using TESTS.Helpers;
using TESTS.Model;

namespace TESTS
{
    class Program
    {
        static void Main(string[] args)
        {
            // ZADANIE 1 //////////////////////////////////////////////////////////////
            // Dlaczego kod się nie kompiluje? /////////////////////////
            // Podaj możliwe rozwiązanie

            // 1.a)
            bool a = false;
            int? b = a == true ? 1 : null;
            Console.WriteLine(b);

            // 1.b)
            int i = 0;
            double d = 123.24M;
            i = d; // dlaczego takie przypisanie wartości nie jest możliwe?
            d = i;


            // ZADANIE 2 //////////////////////////////////////////////////////////////
            // Co zostanie wypisane na ekran?
            // Dodać opcję pomijania liczenia białych znaków (spacja)

            var text = "Ala ma kota...";
            var result = Basic.CountLetters(text);
            foreach (var keyValue in result)
                Console.WriteLine($"Znak: {keyValue.Key} Ilość wystąpień: {keyValue.Value}");



            // ZADANIE 3 //////////////////////////////////////////////////////////////
            // (operacje na kolekcjach / LinQ)
            //Wypisz posortowaną listę
            //Każda liczba powinna zostać wypisana w konsoli tylko raz! 

            List<int> numList = new List<int>
            {
                4,13,5,1,75,2,23,25,67,745,23,264,75,2,23,5,1,75,2,23,25,67,745,
                23,264,7,5,1,75,2,23,25,67,745,232,23,5,1,75,2,23,25,67,745,2,2,
                264,75,2,23,5,1,75,2,23,22,75,2,23,5,1,75,2,23,264,75,2,235,2,2
            };

            foreach (var number in numList)
                Console.WriteLine(number);


            // Zadanie 4 //////////////////////////////////////////////////////////////
            // Napisz funkcję getNumber(int[] Tab) w klasie Basic przestrzeni nazw Helpers,
            // która jako parametr przyjmuje tablicę Tab liczb całkowitych 
            // i zwraca najmniejszą dodatnią liczbę całkowitą N (dla N>0) 
            // która nie występuje w podanej tablicy Tab

            ///PRZYKŁAD: 
            /// Tab = [0, 1, 2] - funkcja zwraca 3
            /// Tab = [-1, -2] - funkcja zwraca 1

            //przykładowe wejście
            int[] Tab = { -2, -1, -6, 1, 4, 2, 3, 5, 7 };

            //wypisanie wyniku
            Console.WriteLine($"Najmniejsza liczba całkowita w podanej tablicy to: {Basic.getNumber(Tab)}");

            Console.ReadKey(true);
        }

        


    }
}
