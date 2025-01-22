

window.showToastr = function (type, message) {
    if (type == "success") {
        toastr.success(message);
    }
    if (type == "error") {
        toastr.error(message);
    }
}

window.displaySwal = function (type, message) {
    if (type == "success") {
        Swal.fire({
            title: "Drag me!",
            icon: "success",
            draggable: true
        });

    }
    if (type == "error") {
        Swal.fire({
            title: 'Error!',
            text: 'Do you want to continue',
            icon: 'error',
            confirmButtonText: 'Cool'
        });
    }
}