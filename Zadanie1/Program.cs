using System;
//Zadanie już przerobione zgodnie z poleceniem z zadania 3
class Program
{
    static void Main()
    {
        int arraySize;
        bool validSize = false;

        do
        {
            Console.Write("Podaj rozmiar tablicy: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out arraySize) && arraySize > 0)
            {
                validSize = true;
            }
            else
            {
                Console.WriteLine("Nieprawidłowy rozmiar tablicy. Podaj dodatnią liczbę całkowitą.");
            }
        } while (!validSize);

        int[,] array = new int[arraySize, arraySize];
        int number = 1;

        for (int row = 0; row < arraySize; row++)
        {
            if (row % 2 == 0) //parzyste wiersze
            {
                for (int column = 0; column < arraySize; column++)
                {
                    array[row, column] = number;
                    number++;
                }
            }
            else //nieparzyste wiersze
            {
                for (int column = arraySize - 1; column >= 0; column--)
                {
                    array[row, column] = number;
                    number++;
                }
            }
        }

     
        for (int row = 0; row < arraySize; row++)
        {
            for (int column = 0; column < arraySize; column++)
            {
                Console.Write(array[row, column] + "\t");
            }
            Console.WriteLine();
        }
    }
}
