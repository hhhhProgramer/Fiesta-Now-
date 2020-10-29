document.getElementById("add-student").addEventListener("click", function() {
    let rows = document.getElementsByName("row").length + 1;
    let rowid = "row-" + rows;

    document.getElementById("class").innerHTML +=
        "<tr id =" + rowid + " name='row'>\
        <th scope='row'>\
            <button type='button' onclick=RemoveClass('" + rowid + "') id='add-student' name='rmv-class' class='btn btn-success btn-sm'> \
            <span class='glyphicon glyphicon-erase'></span> \
            </button> \
        </th> \
        <td><select name='days' id='day'>\
            <option>Lunes</option>\
            <option>Martes</option>\
            <option>Miercoles</option>\
            <option>Jueves</option>\
            <option>Viernes</option>\
            <option>Sabado</option>\
            <option>Domingo</option>\
        </select></td>\
        <td><input type='time'></td>\
        <td><input type='time'></td>\
    </tr>\
    ";
})

function RemoveClass(del) {
    let row = document.getElementById(del);
    let padre = row.parentNode;
    padre.removeChild(row);
}