const rewire = require("rewire")
const links = rewire("../src/routes/links")
const test = links.__get__("test")
    // @ponicode
describe("test", () => {
    test("0", () => {
        test(1)


    })
})