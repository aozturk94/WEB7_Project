const framework1 = "React";
const framework2 = "Angular";
const framework3 = "Vue";

let mesaj1 = "Most popular JS Frameworks: " + framework1 + ", " + framework2 + ", " + framework3;
console.log(mesaj1);

let mesaj2 = 'Most popular JS Frameworks: ' + framework1 + ', ' + framework2 + ', ' + framework3;
console.log(mesaj2);

let mesaj3 = `Most popular JS Frameworks: ${framework1}, ${framework2}, ${framework3}`;
console.log(mesaj3);

let html = `
<h1>${framework1}</h1>
<h1>${framework2}</h1>
<h1>${framework3}</h1>
`;

console.log(html);