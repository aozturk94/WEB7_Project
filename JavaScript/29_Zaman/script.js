const clock = document.querySelector(".clock");

function tick()
{
    const zaman = new Date();
    const saat = zaman.getHours();
    const dakika = zaman.getMinutes();
    const saniye = zaman.getSeconds();
    const html = `<span>${saat}</span>:<span>${dakika}</span>:<span>${saniye}</span>`;
    clock.innerHTML=html;
}
setInterval(tick,1000)