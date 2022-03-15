// function mesajYaz() 
// {
//     console.log("Merhaba, hoş geldiniz.")
// }

// mesajYaz();

// function mesajYaz(mesaj) 
// {
//     console.log(mesaj)
// }

// mesajYaz("Merhaba, bu özelleştirilmiş bir mesajdır.");
// mesajYaz("Bu bizim JS Function deneyimimiz.");

// function topla(sayi1,sayi2)
// {
//     return sayi1 + sayi2;
// }

// console.log("Toplam: " + topla(60,40));

//Birden fazla parametreli function
const topla = function(sayi1,sayi2)
{
    return sayi1 + sayi2;
}
console.log(topla(100,85));

//Tek parametreli function
const ikiKati = sayi =>
{
    return sayi*2;
}
console.log(ikiKati(25));

//Parametresiz function
const mesajYaz = () => 
{
    console.log("Selam");
}
mesajYaz();