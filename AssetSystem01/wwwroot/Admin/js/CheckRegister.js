

$(function () {

    $("#FormRegister").validate({
        rules: {
            UserName: {
                required: true,
                email: true
                


            },
            PassWord: {
                required: true,
                minlength: 8,
            },
            ConfirmPassWord: {
                required: true,
                equalTo: "#PassWord"
            }
        },
        messages: {
            UserName: {
                required: "Không được trống !",
                email: "Bạn phải nhập đúng định dạng email !"
                


            },
            PassWord: {
                required: "Không được trống !",
                minlength: "Mật khẩu phải ít nhất 8 ký tự !"
            },
            ConfirmPassWord: {
                required: "Không được để trống !",
                equalTo: "Phải giống mật khẩu !"
            }
        }
    });

    $("#btnSubmit").off('click').on('click', function (e) {
        if (!$("#FormRegister").validate()) {
            e.preventDefault();
        }
    });


});




 
