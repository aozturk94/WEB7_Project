$(document).ready(function () {
    var pathName = window.location.pathname;
    $("li a").removeClass("activeEt")
    $('ul  li  a[href="' + pathName + '"]').toggleClass("activeEt")
})