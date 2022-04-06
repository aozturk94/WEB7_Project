$(document).ready(function () {
    var pathName = window.location.pathname;
    console.log(pathName);
    /*    $("li a").removeClass("activeEt")*/
    $('ul  li  a[href="' + pathName + '"]').addClass("activeEt").siblings().removeClass("activeEt");
})