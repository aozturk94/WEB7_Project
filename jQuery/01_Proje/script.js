let sliderIndex = 0;
let allSlides = $(".slide").toArray();
let allDots = $(".dot").toArray();

$("#prevSlide").click(function(){
    if(sliderIndex==0){
        sliderIndex = allSlides.length
    }
    showSlide(--sliderIndex);
})
$("#nextSlide").click(function(){
    if(sliderIndex==allSlides.length-1){
        sliderIndex = -1;
    }
    showSlide(++sliderIndex)
})
$(".dot").click(function(){
    sliderIndex=$(this).index()
    showSlide(sliderIndex);
})

function showSlide(n) {
    for (let i = 0; i < allSlides.length; i++) {
        allSlides[i].style.display = "none";
        // $(".slide").eq(i).hide("")
        allDots[i].classList.remove("active");
    }
    // allSlides[n].style.display = "block";
    $(".slide").eq(n).fadeTo(1500,1);
    allDots[n].classList.add("active");


}
showSlide(sliderIndex);

$(document).ready(function(){
    $(".films").hide();
    $("#incele").click(function(){
        $(".films").show();
        $(document).scrollTop($(document).height());
        var yazi= $("#card-text1").text();
        $("#filmName").text(yazi);
        var filmYazi = $("#film-text1").html();
        $("h5").html(filmYazi);
    })
    $("#biletAl").click(function(){
        $(".main-popup").css("display","block")
    })
    $(".close-popup").click(function(){
        $(".main-popup").css("display","none")
    })
    $(".seat").click(function(){
        $(this).css("background-color","white")
    })
    $(".seat").dblclick(function(){
        $(this).css("background-color","#444451")
    })
    $("#bannerAc").click(function(){
        $("#banner1").css("display","block");
    })
    $("#bannerAc").dblclick(function(){
        $("#banner1").css("display","none");
    })
})
