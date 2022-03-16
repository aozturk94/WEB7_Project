const tikla = document.querySelector("button");
const mainPopup = document.querySelector(".main-popup");
const close = document.querySelector(".close-popup");

tikla.addEventListener("click", ()=>{
    mainPopup.style.display="block";
})

// close.addEventListener("click",()=>{
//     mainPopup.style.display="none";
// })

mainPopup.addEventListener("click", (e)=>{
    if(e.target.className=="main-popup" || e.target.className=="close-popup")
    {
        mainPopup.style.display="none";
    }

})