$(document).ready(function () {
    $("#menu-btn").click(function () {
        $(".nav-content").toggle("slow");
    })
})


var f = document.getElementById('foo');
document.addEventListener('click', function (ev) {
    f.style.transform = 'translateY(' + (ev.clientY - 25) + 'px)';
    f.style.transform += 'translateX(' + (ev.clientX - 25) + 'px)';
}, false);