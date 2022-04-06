/*$(document).ready(function () {
    var pathName = window.location.pathname;
    console.log(pathName);
    $('ul  li  a[href="' + pathName + '"]').addClass("activeEt").siblings().removeClass("activeEt");
});*/ //Alttakinin sadesi sayılır?

$(document).ready(function () {
    $("li a").each(function () {
        if ($(this).attr("href") == window.location.pathname) {
            $(this).addClass("activeEt");
        }
    })
});
