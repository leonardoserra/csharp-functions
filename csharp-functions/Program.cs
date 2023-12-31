﻿// See https://aka.ms/new-console-template for more information

//Programma

int[] numeri = { 2, 6, 7, 5, 3, 9 };
Console.Write("Array base: ");
StampaArray(numeri);

Console.Write("Array con elementi al quadrato: ");
StampaArray(ElevaArrayAlQuadrato(numeri));

Console.Write("Ristampa Array base non modificato: ");
StampaArray(numeri);

Console.Write("Stampa somma di tutti i numeri: ");
Console.WriteLine(sommaElementiArray(numeri));

Console.Write("Stampa somma di tutti i numeri elevati al quadrato: ");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(numeri)));





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
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

//      restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero) {
    return numero * numero;
}

/*
che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. 
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
 */

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[])array.Clone();
    for(int i = 0; i < arrayCopy.Length; i++)
    {
        arrayCopy[i] = Quadrato(arrayCopy[i]);
    }
    return arrayCopy;
}

// che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
int sommaElementiArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}