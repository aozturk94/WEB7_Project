// const icerik = document.querySelector("p");
// console.log(icerik.classList);
// icerik.classList.add("deneme");
// icerik.classList.add("baslik");
// console.log(icerik.classList);
// icerik.classList.remove("deneme")
// console.log(icerik.classList);

const paragraflar = document.querySelectorAll("p");
paragraflar.forEach(p =>
    {
        if (p.textContent.includes("error")) 
        {
            p.classList.add("error");    
        }
        if (p.textContent.includes("success")) 
        {
            p.classList.add("success");    
        }
    })