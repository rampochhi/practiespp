var dtable;

$(document).ready(function () {
    dtable = $('#myTable').DataTable({
        
        "ajax": {
         "url":"/Customer/AllCustomers"
        },
        "columns": [
                
                { "data": "name" },
                { "data": "address" },
                { "data": "number" },
                { "data": "email" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                      <a href="/Customer/Edit?id=${data}" > <i class="bi bi-pencil-square"></i>Edit</a >
                      <a href="/Customer/Delete?id=${data}"><i class="bi bi-trash-fill">Delete</i>`
                      

                }



            }

        ]
     });
});