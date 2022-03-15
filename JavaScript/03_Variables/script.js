let gun = 14;
let ay = 3;
let yil = 2021; //JavaScript sayılar için sadece NUMBER tipini kullanır.

console.log(typeof(gun));

console.log(typeof(3));

console.log(gun,ay,yil);
gun=25;
let tarih1="Bugünün Tarihi: " + gun + "/" + ay + "/" + yil;
let tarih2='Bugünün Tarihi: ' + gun + '/' + ay + '/' + yil;
let tarih3=`Bugünün Tarihi: ${gun}/${ay}/${yil}`;

console.log(tarih1);
console.log(tarih2);
console.log(tarih3);

const ogrenciSayisi = 14;
console.log("Öğrenci Sayısı: "+ogrenciSayisi);