// See https://aka.ms/new-console-template for more information

//Utility Functions

/*      preso un array di numeri interi,
        stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.
        Potete prendere quella fatta in classe questa mattina
*/
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


// restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero) {
    return numero * numero;
}