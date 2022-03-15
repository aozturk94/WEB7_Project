let ogrenciler=["Ali", "Veli", "Cemal", "Celal"];
ogrenciler.forEach
(
    function()
    {
        console.log("Selam");
    }
)

ogrenciler.forEach
(
    ogrenci => 
    {
        console.log(ogrenci);
    }
)