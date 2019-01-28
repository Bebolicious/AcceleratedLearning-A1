//obj1();
//obj2();
//obj3();
obj4();
function obj1() {
    
    /*
        Skapa ett objekt "person" med uppgifter om Johan Rheborg: förnamn, efternamn, födelseår
        Skriv ut förnamnet
        Skriv ut hans fullständiga namn
    */

    var person = { firstName: "Johan", lastName: "Rheborg", birthYear: "1993" };
    console.log(person.firstName)
    console.log(person.firstName + person.lastName)

}

function obj2() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till ett par rollkaraktärer (Percy Nilegård, Farbror Barbro...)
       Lägg till adressuppgifter (street, city, country)
       Skriv ut info om Johan utifrån objektet "person":
            Johan är född år 1963
            Johan bor på gatan Kammakargatan 38 lgh 1401
            Johan har spelat 3 roller, bland annat Percy Nilegård
    */

    var person = {
        firstName: "Johan", lastName: "Rheborg", birthYear: "1963", street: "Kammargatan 38 lgh 1401", city: "Stockholm",
    country: "Sweden", roles: "Percy Nilegård", roles2: "Farbror Barbro"};
    console.log("Johan är född år " + person.birthYear)
    console.log("Johan bor på gatan " + person.street)
    console.log("Johan har spelat 3 roller, bland annat " + person.roles)

}


function obj3() {

    /*
       Skapa en array "paintings" med tre målningar (tre element)
       För varje målning finns info: namn, konstnär och året den blev målad
       Skriv ut antalet målningar: "Det finns XXXst målningar"
       Skriv ut den tredje målningen t.ex: "Pablo Picasso målade Guernica år 1937"
       Loopa igenom alla målningar med "for of" och skriv ut all info i tabellform
       Tips: använd "padEnd" för att skriva ut tabellen snyggt
    */

    var painting = [
        Painting1 = {
            name: "Mona Lisa", artist: "Leonardo da Vinci", year: "1797"},
        Painting2 = {
            name: "The Starry Night", artist: "Vincent van Gogh", year: "1889"},
        Painting3 = { name: "Guernica", artist: "Pablo Picasso", year: "1937" }]

    for (let art of painting) {
        console.log(art.artist + " målade " + art.name + " år " + art.year);

    }

 
}

function obj4() {

    /*
       Skapa ett objekt "skriet" (av Edvard Munch 1893). Lägg till den i paintingsarrayen mha "push".
       Skriv ut dess år mha variablen "paintings" 
       Använd "pop" för att plocka bort de tre sista målningarna
       Skriv ut antalet målningar i arrayen 
    */

    var painting = [
        Painting1 = {
            name: "Mona Lisa", artist: "Leonardo da Vinci", year: "1797"
        },
        Painting2 = {
            name: "The Starry Night", artist: "Vincent van Gogh", year: "1889"
        },
        Painting3 = { name: "Guernica", artist: "Pablo Picasso", year: "1937" }]

    painting.push(painting4 = { name: "Lugna bullar", artist: "Bebo", year: "2019" })

    painting.pop()
    painting.pop()
    painting.pop()

    for (let art of painting) {
        console.log(painting.length)

    }


}

// -------- EXTRA UPPGIFTER -----------------------------------------

function objExtra1() {

    /*
       Fortsätt bygg vidare på "person"
       Lägg till en metod "fullName" till person
       Lägg till en metod "numberOfRoles" till person

       Används sedan dessa för att skriva ut:
            Johan Rheborg
            Johan Rheborg har spelat i 3 roller
    */
}