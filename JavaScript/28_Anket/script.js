const correctAnswers = ["E","E","E","E","E","E","E","E"];
const form = document.querySelector("form");
const result = document.querySelector(".result");

form.addEventListener("submit", (e) => {
    e.preventDefault(); //Bu formun submit olayı sonrasında sayfanın reflesh edilmesini durdurur, engeller.
    const userAnswers = [form.q1.value,form.q2.value,form.q3.value,form.q4.value,form.q5.value,form.q6.value,form.q7.value,form.q8.value];
    let score=0;
    for(let i=0; i<correctAnswers.length; i++)
    {
        if (userAnswers[i]==correctAnswers[i]) score+=12.5;
    }
    
    result.classList.remove("result-none");
    result.innerHTML=`%${score} ofise dönmek istiyorsunuz.`
})

form.addEventListener("reset", ()=>{
    result.classList.add("result-none");
})

