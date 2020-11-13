function GenerateHorario(clase) {
    let newshorarios = new Array();

    let horariosInicio = Array.from(clase.Inicio);
    let horariosCierre = Array.from(clase.Cierre);
    let Dias = Array.from(clase.days);
    let row = 0;

    horariosInicio.forEach(horario => (
        newshorarios.push({
            Apertura: "2019-07-26T" + horario,
            Cierre: "2019-07-26T" + horariosCierre[row],
            Dia: Dias[row++]
        })
    ));

    newshorarios.forEach(x => console.log(x));
    return newshorarios;
}


function RegisterClass(clase) {
    const fetch = require("node-fetch")
    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    let obj = {
        "Nombre": clase.aula,
        "alumnosMax": parseInt(clase.alumnos),
        "codigoBaileID": parseInt(clase.Tipos),
        "horarios": GenerateHorario(clase)
    }
    console.log(obj);
    fetch("https://localhost:5001/api/clase", {
            agent,
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(obj)
        })
        .then(response => response.json())
        .catch(error => console.log("error", error))
        .then(json => {
            //location.href = "./Login.html"
        });
}