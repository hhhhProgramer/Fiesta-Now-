const Classes = {};
const Horarios = require("./GestionHorario");


Classes.GetById = async function GetId(Id) {
    const fetch = require("node-fetch")
    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    try {
        let UrlGet = "https://localhost:5001/api/clase/" + Id;
        console.log(UrlGet);
        let response = await fetch(UrlGet, {
            agent,
            method: "GET"
        })
        let item = await response.json();

        return item.data;
    } catch (e) {
        console.log("Error", "color:red");
    }

    return;
}

Classes.Update = async function(Update) {
    const fetch = require("node-fetch")
    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    Update.Clase.horarios = Horarios.ToFormat(Update.Clase.NewHorairos);

    console.log(Update.Clase);
    await fetch("https://localhost:5001/api/clase/" + Update.Clase.id, {
            agent,
            method: "PUT",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(Update.Clase)
        })
        .then(response => response.json())
        .catch(error => console.log("error", error))
        .then(json => {
            console.log(json);
        });
}


module.exports = Classes;