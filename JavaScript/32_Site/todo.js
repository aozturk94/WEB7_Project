const newTaskButton = document.querySelector("#newTaskButton");
const newTaskTextBox = document.querySelector("#newTaskTextBox");
const taskList = document.querySelector("#taskList");
const ul = document.querySelector("#ul");
let html=``;

newTaskButton.addEventListener("click", newTask);

function newTask(){
    if(newTaskTextBox.value==""){
        alert("Açıklama kısmn boş bırakmayınız.");
    }
    else{
        html+=`<li>${newTaskTextBox.value}</li>`;
        ul.innerHTML=html;
    }
}
