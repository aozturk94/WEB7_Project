$(document).ready(function () {
     
    $("ul li a").click(function (e) {
        $("ul li a").removeClass("activeEt");
        $(this).addClass("activeEt");
    })
})
