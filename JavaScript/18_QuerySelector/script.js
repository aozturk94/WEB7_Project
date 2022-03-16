//const error = document.querySelector("p"); //Sadece ilk p'yi seçer.
//const error = document.querySelector(".hata");
//const error = document.querySelector("div.hata")
// const error = document.querySelector("#gulsah")
// console.log(error);

const paragraflar = document.querySelectorAll("p")
console.log(paragraflar);
console.log(paragraflar[2]);
paragraflar.forEach(p => console.log(p));