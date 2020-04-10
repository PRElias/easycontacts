// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const text = await navigator.clipboard.readText();

function trypaste() {
    document.getElementById("new-chat").text = text;
}

$(document).ready( function () {
    $('#contactsTable').DataTable({
        pageLength: 50,
        drawCallback: function(){
            $("img.lazy").Lazy();
       }
        // https://datatables.net/reference/option/
    });
} );