// See https://aka.ms/new-console-template for more information







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