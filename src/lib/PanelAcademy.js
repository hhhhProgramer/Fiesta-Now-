const Panel = {}


Panel.GetHorario = async function GetHorarios(result) {
    const fetch = require("node-fetch")
    const https = require("https");
    var horarios = new Array();

    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    for (let i = 0; i < result.length; i++) {
        let response = await fetch(result[i].horarios, { agent });
        let data = await response.json();
        horarios.push({
            clase: result[i],
            horarios: data.data
        })
    }

    return horarios;
}


Panel.GetClass = async function(id) {
    const fetch = require("node-fetch")
    const https = require("https");

    const agent = new https.Agent({
        rejectUnauthorized: false
    });


    let resutl = await fetch("https://localhost:5001/api/clase/" + id, { agent })
        .then(response => response.json())
        .then(json => json)

    return resutl.data;
}

module.exports = Panel;