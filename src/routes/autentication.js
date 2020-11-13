const express = require('express');
const router = express.Router();
const fetch = require("node-fetch")

async function ExistAcademy(account) {
    const fetch = require("node-fetch")
    const https = require("https");

    const agent = new https.Agent({
        rejectUnauthorized: false
    });

    let academy;
    let url = "https://localhost:5001/api/cuenta/" + account.Correo + "/" + account.Password;
    let result = await fetch(url, {
        agent,
        headers: {
            'Content-Type': 'application/json'
        }
    })
    let respose = await result.json();



    if (respose) {
        url = "https://localhost:5001/api/academia/Accout/" + respose.data.id;
        console.log(url);
        var queryAcademy = await fetch(url, {
            agent,
            headers: {
                'Content-Type': 'application/json'
            }
        })

        academy = await queryAcademy.json();
        console.log(academy);
    }


    return academy.data;
}

router.get('/signin', (req, res) => {
    res.render("auth/signin")
})

router.post("/signin", async(req, res) => {
    let redirect = "/links/PanelAcademia";
    const Academy = await ExistAcademy(req.body);

    if (Academy)
        req.session.AcademyId = Academy.id;
    else {
        req.flash('failLogin', 'No se encontro ninguna cuenta con esos datos registrada, favor de verificar los datos');
        redirect = "/signin";
    }
    res.redirect(redirect);
})




module.exports = router;