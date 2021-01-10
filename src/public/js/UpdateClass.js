document.getElementById("add-horario").addEventListener("click", function() {
    let rows = (document.getElementsByName("row").length * -1) - 1;
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


function Restaurar(del) {

    document.getElementById("day" + "-" + del).setAttribute("name", "UpdateDay");
    document.getElementById("Inicio" + "-" + del).setAttribute("name", "UpdateInicio");
    document.getElementById("Cierre" + "-" + del).setAttribute("name", "UpdateCierre");
    document.getElementById("id" + "-" + del).setAttribute("name", "Updateid");

    let row = document.getElementById(del);
    let padre = row.parentNode;

    var destination = document.getElementById('class');
    var copy = row.cloneNode(true);
    padre.removeChild(row);
    copy.getElementsByTagName("button")[0].setAttribute("onclick", "RemoveClass('" + del + "')");
    destination.appendChild(copy);
}


function RemoveClass(del) {
    let row = document.getElementById(del);
    let padre = row.parentNode;

    if (del.indexOf("--") == -1) {

        //cambiar los nombre 
        document.getElementById("day" + "-" + del).setAttribute("name", "DeleteDay");
        document.getElementById("Inicio" + "-" + del).setAttribute("name", "DeleteInicio");
        document.getElementById("Cierre" + "-" + del).setAttribute("name", "DeleteCierre");
        document.getElementById("id" + "-" + del).setAttribute("name", "Deleteid");


        let copy = row.cloneNode(true);
        let destination = document.getElementById('trash');
        let button = copy.getElementsByTagName("button")[0];


        destination.appendChild(copy)
        button.setAttribute("onclick", "Restaurar('" + del + "')")
    }


    padre.removeChild(row);
}


function setDay(id, day) {
    let select = document.getElementById(id);
    select.value = day;
    alert("Image is loaded");
}