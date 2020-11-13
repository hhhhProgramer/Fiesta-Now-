const passport = require("passport")
const LocalStrategy = require('passport-local').Strategy
const helpres = require("./helpers")



passport.use('local', new LocalStrategy(
    function(Correo, Password, done) {
        User.findOne({ Correo: Correo }, function(err, user) {
            if (err) { return done(err); }
            if (!user) {
                return done(null, false, { message: 'Incorrect username.' });
            }
            if (!user.validPassword(Password)) {
                return done(null, false, { message: 'Incorrect Password.' });
            }
            return done(null, user);
        });
    }
));


passport.use('local.singup', new LocalStrategy({
    usermaneField: 'Correo',
    passwordField: 'Password',
    passReqToCallback: true
}, async(req, username, password, done) => {
    const newuser = {
        username,
        password
    }
    newuser.id = 1;
    newuser.password = await helpres.encryptPassword(password)
    return done(null, newuser);
    //almacenar bd const result
}))

passport.serializeUser((usr, done) => {
    done(null, user.id)
})


passport.deserializeUser(async(id, done) => {
    //const rows = fetch
    done(null, id)
})