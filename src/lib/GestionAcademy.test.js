const rewire = require("rewire")
const GestionAcademy = rewire("./GestionAcademy")
const Get = GestionAcademy.__get__("Get")
// @ponicode
describe("Get", () => {
    test("0", async () => {
        let result = await Get(1)
        expect(result).toEqual({ "id": 1, "nombre": "asdasd", "numero": "123123", "descripcion": "asdasd", "direction": "asdasd", "longitud": 1.9923215E+09, "latitud": 1.9872874E+11, "logo": "", "cuentaID": 1 })
    })
})
