﻿using System;

//In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrato
//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
//Rieseguire il programma con l’input preso esternamente dall’utente.



// preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]

void StampaArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}


// funzione che vi restituisca il quadrato del numero passato come parametro

int Quadrato(int numero)
{
    Console.WriteLine($"Il quadrato di {numero} é {Math.Pow(numero, 2)}");
    return numero;
}


// preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = new int[array.Length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i]* array[i];
    }
    Console.WriteLine("Il nuovo array di numeri al quadrato é: [{0}]", string.Join(", ", newArray));
    return newArray;
}


// preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array

int sommaElementiArray(int[] array)
{
    int sum = 0;
    foreach (int elm in array)
    {
        sum += elm;
    }
    Console.WriteLine($"La somma dei numeri nel tuo array é {sum}");
    return sum;
}


//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:

int[] arrayOfNumbers = { 2, 6, 7, 5, 3, 9 };

//Stampare l’array di numeri fornito a video

Console.WriteLine("Stampare l’array di numeri fornito a video: ");
StampaArray(arrayOfNumbers);

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

int[] powArray = ElevaArrayAlQuadrato(arrayOfNumbers);

//Stampare la somma di tutti i numeri

sommaElementiArray(arrayOfNumbers);

//Stampare la somma di tutti i numeri elevati al quadrato

Console.WriteLine("*Tutti i numeri vengono elevati al quadrato*");
sommaElementiArray(powArray);

//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente.
