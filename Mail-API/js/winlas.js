$(document).ready(function () {
    console.log("ready!");

    var mailStatuses = ["Unsent", "Sent", "Error", "Opened"];
    var statusColor = ["table-warning", "table-info", "table-danger", "table-success"];

    var table = $("#mailTable").DataTable({
        dom: "<'row'<'col-sm-3'l>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        order: [[0, "desc"]],
        pageLength: 50,
        processing: true,
        serverSide: true,
        ordering: false,
        searchDelay: 350,
        ajax: {
            type: "POST",
            url: "/Logging/LoadData",
            dataType: "json"
        },
        columns: [
            { data: "id" },
            {
                data: "status",
                render: function(data) {
                    return mailStatuses[data];
                }
            },
            { data: "sentTime"},
            { data: "receiver"},
            { data: "sender"},
            { data: "subject"},
            {
                data: null, render: function (data, type, row, meta) {
                    return "<td><button id='expand-" + row.id + "' class='btn btn-primary expand'>Visa hela meddelandet</button></td>";
                }
            }
        ],
        language: {
            processing: "Loading Data...",
            zeroRecords: "No matching records found"
        },
        createdRow: function(row, data, index) {
            $(row).addClass(statusColor[data.status]);
        }
    });

    $("#searchField").on("keyup", function () {
        table.search(this.value).draw();
    });
    $('body').on('click', '.expand', function () {
        var id = $(this).attr('id').substr(7);
        $(this).closest('tr').after("<tr><td colspan='7' id='td_" + id + "'>Test</td></tr>");
        console.log("We Click");
        $.ajax({
            context: this,
            url: '/api/mail/'+id,
            type: 'GET',
            error: function (error) {
                console.log(error, "Error in ajax request");
            },
            success: function (data) {
                console.log("Success of ajax request");
                console.log(data.body);
                $(this).replaceWith("<button id='contract_" + id + "' class='btn btn-danger contract'>Dölj meddelandet</button>");
                $('#td_' + id).html(data.body);
            }
        });
    });

    $("body").on("click", ".contract", function () {
        var id = $(this).attr('id').substr(9);
        $("#td_" + id).parent().remove();
        $(this).replaceWith("<button id='expand_" + id + "' class='btn btn-primary expand'>Visa hela meddelandet</button>");
    });
});
