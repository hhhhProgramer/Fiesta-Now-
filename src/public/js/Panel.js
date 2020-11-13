function CreateCard(Target) {

    if (Target.index % 3 == 0 && Target.index != 0) {
        document.getElementById("AllClass").innerHTML += "<div id='row-" + row + "' class='row ml-1 mr-1 mt-5'></div>";
    }

    card = "\
        <div class='col'> \
        <div class='card'> \
            <div class='card-header text-center'>\
                <div class='d-flex justify-content-between'>\
                    <div class='bd-highlight'></div>\
                    <div class='bd-highlight'>" + Target.clase.nombre + "</div>\
                    <div class='bd-highlight'>\
                    <div class = 'dropdown'>\
                        <span class='fas fa-bars'><svg width='1em' height='1em' viewBox='0 0 16 16' class='bi bi-caret-down-fill' fill='currentColor' xmlns='http://www.w3.org/2000/svg'>\
                            <path d='M7.247 11.14L2.451 5.658C1.885 5.013 2.345 4 3.204 4h9.592a1 1 0 0 1 .753 1.659l-4.796 5.48a1 1 0 0 1-1.506 0z'/>\
                        </svg>\
                        <div class='dropdown-content'>\
                        <p>\
                        Editar\
                        </p>\
                        <p>\
                        Eliminar\
                        </p>\
                        </span>\
                        </div>\
                    </div>\
                    </div>\
                </div>\
            </div>\
            <div class='card-body'>\
                <p class='card-text'>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>\
                <div id='horario' class='overflow' style='height: 180px;'>"
    Target.horario.forEach(horario => {
        card += "<spam> " + horario.dia + ": " + horario.apertura + "-" + horario.cierre + "</spam>" + "<br>"
    })
    card += "</div>\
            </div>\
        </div>\
    </div>";


    document.getElementById("row-" + Target.row).innerHTML += card;
}

fetch("https://localhost:5001/api/clase")
    .then(response => response.json())
    .then(json => {
        let row = 1;
        let index = 0;

        json.data.forEach(element => {
            let url = "https://localhost:5001/api/horario/" + element.id;
            fetch(url)
                .then(response => response.json())
                .then(json => {
                    if (index % 3 == 0 && index != 0) { row++ }
                    CreateCard({
                        clase: element,
                        horario: json.data,
                        index: index++,
                        row: row
                    })
                })
        })
    });