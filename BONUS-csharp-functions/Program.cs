// See https://aka.ms/new-console-template for more information

//Programma
using System;

Console.WriteLine("Versione BONUS");
Console.WriteLine();
bool programStarting = true;
while (programStarting)
{
    Console.Write("Ciao Carissimo, digita un numero intero per decidere di quanti elementi è composto il nostro array: ");
    bool intCheck = int.TryParse(Console.ReadLine(), out int dimensioneArray);
    //Type intCheck = dimensioneArray.GetType();
    Type acceptedTypeInt = typeof(int);

    if (intCheck)
        {
        int[] usedArray = new int[dimensioneArray];

        Console.WriteLine();
        Console.WriteLine("Bene adesso inserisci i numeri interi che verranno allocati in ogni cella dell' array! ");
        Console.WriteLine();

        for (int i = 0; i < usedArray.Length; i++)
        {
            Console.Write($"Restano ancora {usedArray.Length - i} celle da riempire, digita il numero: ");
            //bool isNotInteger = false;
            bool retryAllocation = true;
            while (retryAllocation)
            {
                bool isInteger = int.TryParse(Console.ReadLine(), out int numInserito);
                
                if (isInteger)
                {
                    usedArray[i] = numInserito;
                    retryAllocation = false;
                }
                else
                {
                    Console.Write($"Inserire solo numeri interi... riprova. Restano ancora {usedArray.Length - i} celle da riempire, digita il numero: ");
                    //continue;
                }
            }
        }

        Console.WriteLine();
        Console.Write("Array base: ");
        StampaArray(usedArray);

        Console.Write("Array con elementi al quadrato: ");
        StampaArray(ElevaArrayAlQuadrato(usedArray));

        Console.Write("Ristampa Array base non modificato: ");
        StampaArray(usedArray);

        Console.WriteLine();
        Console.Write("Stampa somma di tutti i numeri: ");
        Console.WriteLine(sommaElementiArray(usedArray));

        Console.Write("Stampa somma di tutti i numeri elevati al quadrato: ");
        Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(usedArray)));
        Console.WriteLine("Chiudere il programma? Si | No");
        string answer = Console.ReadLine().ToLower();
        if (answer == "si" || answer == "yes" || answer == "s" || answer == "y")
        {
            programStarting = false;
        }
        else if (answer == "no" || answer == "n")
        {
            Console.WriteLine("Ripristino...");
            Console.WriteLine("...........");
            Console.WriteLine(".......");
            Console.WriteLine("....");
            Console.WriteLine("...");
            Console.WriteLine("..");
            Console.WriteLine("Completo!");
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Input non valido mascalzone, chiusura in corso");
            programStarting = false;
        }

    }
    else
    {
        Console.WriteLine("Inserisci solo numeri interi please... riprova");
        continue;
    }

}
//credits
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Made by Leonardo Serra aka daruma_beats classe-07");
Console.WriteLine();
Console.WriteLine();


//Utility Functions

//preso un array di numeri interi,stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

//      restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    return numero * numero;
}

/*
che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. 
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
 */

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();
    for (int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }
    return arrayCopy;
}

// che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int sommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}