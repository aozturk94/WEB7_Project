// const notlar = 
// [50,60,70,0,90,100,90,80,70,40]

let notlar=[];
for(i=0; i<10; i++)
{
    notlar[i]=Math.trunc(Math.random()*100)
}
console.log(notlar);

let icerik=document.querySelector("div");

notlar.forEach( not => 
    {

        if(not>50)
        {
            icerik.innerHTML+=`<li class=basarili>${not}</li>`
        }
        else
        {
            icerik.innerHTML+=`<li class=basarisiz>${not}</li>`
        }
    })
