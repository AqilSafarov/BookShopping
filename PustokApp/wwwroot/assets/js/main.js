$(document).ready(function () {
    $(document).on("click", "#myTab li", function () {
        //$.ajax({
        //    url: "Home/GetSliderBooks?type="+$(this).data("type"),
        //    type: "GET",
        //    success: function (result) {
        //        console.log(result.length)
        //        for (var i = 0; i < result.length; i++) {

        //            console.log(card)

        //        }
        //    }
        //})
        var slider;
        if ($(this).data("type") == "0") {
            slider = $("#new .sb-slick-slider");
        }
        else if ($(this).data("type") == "1") {
            slider = $("#discounted .sb-slick-slider");

        }
        else {
            slider = $("#all .sb-slick-slider");
        }
        console.log($(slider));

            $.ajax({
                url: "Home/BookSliderCardPartial?type="+$(this).data("type"),
                type: "GET",
                success: function (result) {

                    $(slider).slick('removeSlide', null, null, true);
                    $(slider).slick('slickAdd', result);

               
                }
        })


    })

})