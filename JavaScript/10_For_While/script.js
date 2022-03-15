for (let i = 0; i < 10; i++) 
{
  console.log(i);  
}

let isimler=["Ali","Kemal","Sezen","Tarkan","Gülşen"];
console.log(isimler);

for(let i=0; i<isimler.length; i++)
{
  console.log("Merhaba " + " "+isimler[i]);
}

let notlar=[10,75,55,100,90,45];
for(let i=notlar.length-1;i>=0; i--)
{
  // console.log(i + 1 + ". not: " + notlar[i]);
  console.log(`${i+1}. not: ${notlar[i]}`);
}

let i=0;
while(i<isimler.length)
{
  console.log(isimler[i].toLocaleUpperCase());
  i++;
}