$(() => {
    
    $("#btn_load").on('click',() => {
        $.ajax({
            url: "/About/Load",
            type: "GET",
            success: function (res) {
                $(".for_append").append(res);
                console.log(res);
            },
            error: function (error) {
                console.log(error);
            }
        });
    });


})