window.ShowSiiimpleFromCs = (toastType, position, message) => {
    siiimpleToast = siiimpleToast.setOptions({
        container: 'body',
        class: 'siiimpleToast',
        position: position,
        margin: 15,
        delay: 0,
        duration: 3000,
        style: {},
    });

    siiimpleToast[toastType](message);
};