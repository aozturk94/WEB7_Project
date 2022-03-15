// let yas=15;

// if (yas>18) 
// {
//     console.log("Ehliyet alabilir.");    
// }
// else
// {
//     console.log("Ehliyet alamaz.")
// }

// const sifre = "asdda!dsadsa";

// if (sifre.length>=12) 
// {
//     console.log("Çok güçlü şifre");
// } 
// else if(sifre.length>=8)
// {
//     console.log("Güçlü Şifre");
// }
// else
// {
//     console.log("Şifre geçersiz, lütfen yeni bir şifre belirleyiniz.")
// }

// if (sifre.length>=12 && sifre.includes("!")) 
// {
//     console.log("Çok Güçlü Şifre");  
// } 
// else if(sifre.length>=8 && sifre.includes("!")) 
// {
//     console.log("Güçlü Şifre")
// }
// else
// {
//     console.log("Şifre geçersiz, lütfen yeni bir şifre belirleyiniz.")
// }

// let ad="Gülşah";
// if (ad=="Abdullah" || ad=="Sevim") 
// {
//     console.log("Giriş Başarılı");
// } 
// else 
// {
//     console.log("Geçersiz Giriş İşlemi");
// }

let ad = "Gülşah";
let durum=null;
if (ad == "Abdullah" || ad == "Sevim") 
{
    durum = true;
}
else 
{
    durum = false;
}

if(!durum)
{
    console.log("Başarısız!");
}