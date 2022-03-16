const baslik = document.getElementById("baslik");
console.log(baslik)

const hatalar = document.getElementsByClassName("hata"); 
//Bu metodun dönüş tipi HTML Collection'tır. 
//HTML Collection'ın içinde Foreach ile dönülmez.
console.log(hatalar);

const paragraflar = document.getElementsByTagName("p");
console.log(paragraflar);