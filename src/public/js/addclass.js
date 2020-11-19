document.getElementById("add-horario").addEventListener("click", function() {
    let rows = document.getElementsByName("row").length + 1;
    let rowid = "row-" + rows;

    document.getElementById("class").innerHTML +=
        "<tr id =" + rowid + " name='row'>\
        <th scope='row'>\
            <button type='button' onclick=RemoveClass('" + rowid + "')  name='rmv-class' class='btn btn-success btn-sm'> \
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
        <td><input name='Inicio' type='time' value='22:53'></td>\
        <td><input name='Cierre' type='time' value='22:53'></td>\
    </tr>\
    ";
})

function RemoveClass(del) {
    let row = document.getElementById(del);
    let padre = row.parentNode;
    padre.removeChild(row);
}