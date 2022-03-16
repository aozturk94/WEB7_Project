const link = document.querySelector("a");
console.log(link);
console.log(link.getAttribute("href"));
link.setAttribute("href", "https://www.wissenakademie.com");
link.textContent="Wissen";

const paragraf = document.querySelector("p");
console.log(paragraf.getAttribute("class"));
paragraf.setAttribute("class", "hata");
console.log(paragraf.getAttribute("class"));
paragraf.setAttribute("style", "color:red");