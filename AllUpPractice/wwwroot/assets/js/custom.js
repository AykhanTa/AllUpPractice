$(document).ready(function () {

    $(document).on("keyup", "#searchInput", function () {
        let searchValue = $(this).val();
        let categoryId = $("#selectSearch").find(":selected").val();
        axios.get("/product/searchProduct?categoryId="+categoryId+"&search="+searchValue)

            .then(function (datas) {
                $("#searchList").html(datas.data)
            })

    })

    //modal
    $(".productModal").click(function (ev) {
        ev.preventDefault();
        let url = $(this).attr("href");
        axios.get(url)
            .then(function (response) {
                // handle success
                //console.log(response.data);
                $(".modal-body").html(response.data);

                $('.quick-view-image').slick({
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    dots: false,
                    fade: true,
                    asNavFor: '.quick-view-thumb',
                    speed: 400,
                });

                $('.quick-view-thumb').slick({
                    slidesToShow: 4,
                    slidesToScroll: 1,
                    asNavFor: '.quick-view-image',
                    dots: false,
                    arrows: false,
                    focusOnSelect: true,
                    speed: 400,
                });
            })
    })
})