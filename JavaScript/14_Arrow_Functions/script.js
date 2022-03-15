// const topla = (sayi1,sayi2) => sayi1 + sayi2;
// console.log(topla(60,55));

// const kareAlan = kenar => kenar**2;
// console.log(kareAlan(8));

// const mesajYaz = () => console.log("Merhaba!");
// mesajYaz();

/*Dışarıdan ürün fiyat bilgilerini ve uygulanacak vergi oranını alan 
ve bu bilgilere göre her ürünün vergili fiyatı ve toplam fiyatı hesaplayıp 
konsola yazan functionı hazırlayın.*/

const fatura = (urunFiyatlari, vergiOrani) =>
{
    let toplam = 0;
    for(let i=0; i < urunFiyatlari.length; i++)
    {
        let vergiDahilUrunFiyati = urunFiyatlari[i]*(1+vergiOrani);
        console.log(`${i+1}. Ürün: ${vergiDahilUrunFiyati}`)
        toplam += vergiDahilUrunFiyati;
    }
    return toplam;
}

console.log(fatura([10,20,30,60,40],0.2));