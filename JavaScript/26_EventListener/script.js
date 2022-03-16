const buton = document.querySelector("button");
// buton.addEventListener("click",()=>{alert("Butona tıkladın")});
// const li = document.querySelector("li");
// li.addEventListener("click",()=>{alert("Reactı seçtin")});


//ul içindeki tüm li'leri dolaşacak ve her birine eventlistener ekleyecek.
function eventEkle()
{
    const liElemanlari = document.querySelectorAll("li");
    liElemanlari.forEach(li =>
    {
        li.addEventListener("click",(e)=>
        {
            e.target.remove();
        })
    })
};
eventEkle();

const ul = document.querySelector("ul");
buton.addEventListener("click",()=>
{
    let li = document.createElement("li");
    li.textContent="JavaScript";
    // ul.append(li); //Sona ekler.
    ul.prepend(li); //Başa ekler.
    eventEkle();
})