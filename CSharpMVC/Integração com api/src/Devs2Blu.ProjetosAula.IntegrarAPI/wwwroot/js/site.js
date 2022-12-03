// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const search = () => {
    let nameInput = document.getElementById("input-search").value;
    
    window.location.href = `search/${nameInput}`

    /*$.ajax({
        url: `/Food/search/${nameInput}`,
        dataType: 'html',
        success: (htmlPartialView) => {
            $('#content-list').html(htmlPartialView);
        }
    });*/
    

}