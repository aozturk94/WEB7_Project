let isimler = ["Ahmet", "Berna", "Ceylin"];
console.log(isimler);
console.log(isimler[1]);

let yaslar = [40, 34, 29];
console.log(yaslar[2]);

let bilgiler = ["Umay", "Begüm", 41, true, "765", 78];
console.log(bilgiler);

console.log(typeof (isimler));
console.log(typeof (yaslar));
console.log(typeof (bilgiler));

console.log(typeof (bilgiler[3]));
console.log(typeof (bilgiler[4]));
console.log(typeof (bilgiler[5]));
console.log(bilgiler.length);

console.log(bilgiler.join("-"));
console.log(bilgiler.indexOf(41));

let yeniIsimler = isimler.concat(["Halil", "Cemal", "Sevil"]);
console.log(yeniIsimler);

isimler.push("Elif");
console.log(isimler);
console.log(isimler.length);
isimler.pop();
console.log(isimler);
console.log(isimler.length);




