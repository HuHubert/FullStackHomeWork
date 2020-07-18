$(document).ready(function () {
    move_div();

    //當視窗放大或縮小時呼叫move_div的函式
    //讓div1置中
    $(window).resize(move_div);

    function move_div() {
        let winHeight = $(this).height();
        let winWidth = $(this).width();

        let divHeight = $("#div1").height();
        let divWidth = $("#div1").width();

        let top = (winHeight - divHeight) / 2;
        let left = (winWidth - divWidth) / 2;

        let newwidth = left/760
        let newheigh = top/319


        
        
        $("#div1").css("top", top).css("left", left);
        $("#image1").css("width",newwidth*400).css("height",newheigh*300);
    }
});