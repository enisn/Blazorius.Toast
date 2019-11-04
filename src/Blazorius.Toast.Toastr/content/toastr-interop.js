window.ShowToastrFromCs = (toastType, positionClass, message) => {
    toastr.options = {
        "debug": false,
        "positionClass": positionClass,
        "onclick": null,
        "fadeIn": 300,
        "fadeOut": 1000,
        "timeOut": 5000,
        "extendedTimeOut": 1000
    };

    toastr[toastType](message);
};