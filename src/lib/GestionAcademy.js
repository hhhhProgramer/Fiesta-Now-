const Academy = {}

Academy.Add = async function(Academy) {
    const fetch = require("node-fetch")
    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });


    let obj = {
        Nombre: Academy.academy,
        Numero: Academy.number,
        Correo: Academy.correo,
        Password: Academy.password,
        Descripcion: Academy.descripcion,
        Direction: Academy.direccion,
        Longitud: 1992321512.42563,
        Latitud: 198728745872.123857129,
        Logo: Academy.photo,
        Rol: 1
    }
    console.log(obj);
    let response = await fetch("https://localhost:5001/api/academia", {
        agent,
        method: "POST",
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(obj)
    })
    let item = await response.json();

    return item.data;
}


Academy.Delete = async function(id) {
    const fetch = require("node-fetch")
    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    try {

        let UrlDelete = "https://localhost:5001/api/academia/" + id;
        console.log(UrlDelete);
        let response = await fetch(UrlDelete, {
            agent,
            method: "DELETE"
        })
    } catch (e) {
        console.log("Error", "color:red");
        return 0;
    }
    return 1;
}

Academy.GetById = async function(Id) {
    const fetch = require("node-fetch")
    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    try {

        let UrlGet = "https://localhost:5001/api/academia/" + Id;
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


module.exports = Academy;