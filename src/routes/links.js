const express = require('express');
const router = express.Router();


const fetch = require("node-fetch")
const PanelAcademi = require('./../lib/PanelAcademy');
const Academy = require('./../lib/GestionAcademy');


function GenerateHorario(clase) {
    let newshorarios = new Array();


    if (Array.isArray(clase.Inicio)) {
        let horariosInicio = clase.Inicio;
        let horariosCierre = clase.Cierre;
        let Dias = clase.days;
        let row = 0;

        horariosInicio.forEach(horario => (
            newshorarios.push({
                Apertura: "2019-07-26T" + horario,
                Cierre: "2019-07-26T" + horariosCierre[row],
                Dia: Dias[row++]
            })
        ));
    } else
        newshorarios.push({
            Apertura: "2019-07-26T" + clase.Inicio,
            Cierre: "2019-07-26T" + clase.Cierre,
            Dia: clase.days
        })




    newshorarios.forEach(x => console.log(x));
    return newshorarios;
}


async function RegisterClass(clase) {

    const https = require("https");
    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    clase.horarios = GenerateHorario(clase.horarios);

    console.log(clase)
    await fetch("https://localhost:5001/api/clase", {
            agent,
            method: "POST",
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(clase)
        })
        .then(response => response.json())
        .catch(error => console.log("error", error))
        .then(json => {
            console.log(json);
        });
}

router.get('/add', (req, res) => {
    res.render('links/add');
})


router.post('/add', async(req, res) => {
    let obj = {
        "Nombre": req.body.aula,
        "alumnosMax": parseInt(req.body.alumnos),
        "codigoBaileID": parseInt(req.body.Tipos),
        "academiaId": parseInt(req.session.AcademyId),
        "horarios": req.body
    }

    await RegisterClass(obj);
    req.flash('success', 'Clase guardada exitosamente');
    res.redirect("/links/PanelAcademia");
})


router.get('/PanelAcademia', async(req, res) => {
    const panel = await PanelAcademi.GetClass(req.session.AcademyId);
    const horarios = await PanelAcademi.GetHorario(panel);

    //console.log(horarios)
    res.render('links/AcademiaPanel', { horarios: horarios });
})



router.get('/AcademySignup', (req, res) => {
    //console.log(horarios)
    res.render('links/AcademySignup');
})


router.post('/AcademySignup', async(req, res) => {
    let academy = await Academy.Add(req.body);
    req.session.AcademyId = academy.id;

    res.redirect("/links/PanelAcademia");
})

router.get('/type', (req, res) => {
    //console.log(horarios)
    res.render('links/type');
})



module.exports = router;