$(function () {

    $("#FormLogin").validate({
        rules: {
            UserName: {
                required: true
            },
            PassWord: {
                required: true
            }
        },
        messages: {
            UserName: {
                required: "Không được trống !"
            },
            PassWord: {
                required: "Không được trống !"

            }

        }
    });




    $("#btnSubmit").off('click').on('click', function (e) {
        if (!$("#FormLogin").validate()) {
            e.preventDefault();
        }
    });
});