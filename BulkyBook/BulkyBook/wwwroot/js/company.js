﻿var dataTable;

$(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        'ajax': {
            'url': '/Admin/Company/GetAll'
        },
        'columns': [
            { 'data': 'name', 'width': '15%' },
            { 'data': 'streetAddress', 'width': '15%' },
            { 'data': 'city', 'width': '15%' },
            { 'data': 'state', 'width': '15%' },
            { 'data': 'phoneNumber', 'width': '15%' },
            {
                'data': 'isAuthorizedCompany',
                'render': function(data) {
                    if (data) {
                        return '<input type="checkbox" disabled checked/>';
                    } else {
                        return '<input type="checkbox" disabled/>';
                    }
                }, 'width': '10%'
            },
            {
                'data': 'id',
                'render': function (data) {
                    return `<div class="text-center">
                                <a href="/Admin/Company/Upsert/${data}" class="btn btn-success text-white" style="cursor: pointer"><i class="fas fa-edit"></i></a>
                                <a onclick=Delete("/Admin/Company/Delete/${data}") class="btn btn-danger text-white" style="cursor: pointer"><i class="fas fa-trash-alt"></i></a>
                        </div>`;
                },
                'width': '15%'
            },
        ]
    });
}

function Delete(url) {
    swal({
        title: 'Are yoy sure you want to delete?',
        text: 'You will not be able to restore the data!',
        icon: 'warning',
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: 'DELETE',
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}