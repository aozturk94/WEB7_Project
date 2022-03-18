const form = document.querySelector("form");
const text = document.querySelector("textarea");
const deger = text.value;
const mesaj = document.querySelector(".mesaj");

form.addEventListener("submit", (e) => {
    e.preventDefault();
    const userName = form.userName.value;
    const userNamePattern = /^[a-zA-Z0-9öğüışçÖÇŞĞİÜ]{6,10}$/gm;
    if (userNamePattern.test(userName)) {
 
            e.preventDefault();
            mesaj.innerHTML = `Sayın ${text.value} hoşgeldiniz.`
            text.setAttribute("class", "textareatrue");
            // alert(`Sayın ${text.value} hoşgeldiniz.`)
        }
        else {
            e.preventDefault();
            mesaj.innerHTML = "Please enter a valid username!";
            // alert("Please enter a valid username!")
            text.setAttribute("class", "textareafalse");
        }
    
});