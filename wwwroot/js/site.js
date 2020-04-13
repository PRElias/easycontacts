// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// const text = await navigator.clipboard.readText();

// function trypaste() {
//     document.getElementById("new-chat").text = text;
// }

// Opções padrão para todas as datatables
$.extend( $.fn.dataTable.defaults, {
    pageLength: 50,
    ordering: true,
    responsive: true,
    language: {
        lengthMenu: "Exibe _MENU_ Registros por página",
        search: "",
        paginate: { "previous": "Retorna", "next" : "Avança"},
        zeroRecords: "Nada foi encontrado",
        loadingRecords: "<span class='fa-stack fa-lg'><i class='fa fa-spinner fa-spin fa-stack-1x fa-fw'></i></span>",
        info: "Exibindo página _PAGE_ de _PAGES_",
        infoEmpty: "",
        infoFiltered: "(filtrado de _MAX_ regitros totais)"
    },
    dom: 'Bfrtip',
    buttons: [{
        extend: "excelHtml5",
        text: "Download em Excel",
        className: "btn btn-primary",
        init: function(api, node, config) {
            $(node).removeClass('dt-button buttons-excel buttons-html5')
        }
    }]
} );

$.fn.dataTable.render.multi = function (renderArray) {
    return function (d, type, row, meta) {
        for (var r = 0; r < renderArray.length; r++) {
            d = renderArray[r](d, type, row, meta);
        }
        return d;
    }
}

$(document).ready(function () {
    $('.dataTables_filter input[type="search"]').
    attr('placeholder','Digite aqui para procurar em todos os campos').
    css({'width':'360px','display':'inline-block'});
});