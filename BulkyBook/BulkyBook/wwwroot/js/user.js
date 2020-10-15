var dataTable;

$(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        'ajax': {
            'url': '/Admin/User/GetAll'
        },
        'columns': [
            { 'data': 'name', 'width': '20%' },
            { 'data': 'email', 'width': '20%' },
            { 'data': 'phoneNumber', 'width': '15%' },
            { 'data': 'company.name', 'width': '15%' },
            { 'data': 'role', 'width': '15%' },
            {
                'data': { id: 'id', lockoutEnd: 'lockoutEnd' },
                'render': function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();
                    if (lockout > today) {
                        // User is locked
                        return `<div class="text-center">
                                <a onclick=LockUnlock("${data.id
                            }") class="btn btn-danger text-white" style="cursor: pointer"><i class="fas fa-lock-open"></i> Unlock</a>
                        </div>`;
                    } else {
                        return `<div class="text-center">
                                <a onclick=LockUnlock("${data.id}") class="btn btn-success text-white" style="cursor: pointer"><i class="fas fa-lock"></i> Lock</a>
                        </div>`;
                    }
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
                success: function(data) {
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