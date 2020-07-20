$(function () {
    let slideNum = 0;
    let slideCount = $(".slides li").length;
    let lastIndex = slideCount - 1;
    console.log(slideCount);

    // console.log($(".dot li"));

    $(".dot li").eq(0).css("background", "#fff");
    $(".dot li").mouseenter(function () {
        // console.log($(this).css("background-color"));
        // console.log($(this).css("background"));

        slideNum = $(this).index();
        console.log(slideNum);

        // $(this).css("background-color","white")
        // .siblings().css("background-color","transparent");

        // $(".dot li").eq(slideNum).css("background-color","white")
        // .siblings().css("background-color","transparent");                

        // let move=0-800*slideNum;
        // $("ul.slides").css("left",move);

        show();
    });

    function show() {
        $(".dot li").eq(slideNum).css("background-color", "white")
            .siblings().css("background-color", "transparent");

        let move = 0 - 800 * slideNum;
        $("ul.slides").css("left", move);
    }
    $("#prevSlide").click(function () {
        slideNum--;
        if (slideNum < 0) slideNum = lastIndex;

        show();
    });

    $("#nextSlide").click(function () {
        slideNum++;
        if (slideNum > lastIndex) slideNum = 0;
        show();
    })


    var t = setInterval(function () {
        slideNum++;
        if (slideNum > lastIndex) slideNum = 0;
        show();
        $(".wrapper img").show()






    }, 3000);







    $(".wrapper").mouseenter(function () { clearInterval(t) })



    $(".wrapper").mouseleave(function () {

        t = setInterval(function () {
            slideNum++;
            if (slideNum > lastIndex) slideNum = 0;
            show();
            $(".wrapper img").show()



        }, 3000);
    })


















});