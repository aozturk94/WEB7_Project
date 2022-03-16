const section = document.querySelector("section");
console.log(section.children);
console.log(Array.from(section.children));

Array.from(section.children).forEach(child =>
    {
        child.classList.add("section_child");
    })

const ul = document.querySelector("ul");
console.log(ul.parentElement);
console.log(ul.parentElement.parentElement);
console.log(ul.children);
console.log(ul.nextElementSibling);
console.log(ul.previousElementSibling);
