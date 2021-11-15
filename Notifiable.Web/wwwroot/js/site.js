function success(data) {

    var response = data.responseJSON;

    if (response.success === true) {
        toastr.success(response.message, "Alerta de sucesso")
    }
    else {
        response.errors.forEach(function (error) {
            toastr.error(error.message)
        })
    }
}
