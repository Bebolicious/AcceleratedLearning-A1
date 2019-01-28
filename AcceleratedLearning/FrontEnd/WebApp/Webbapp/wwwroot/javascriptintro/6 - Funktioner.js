//fun1();
//fun2();
//fun3();
//fun4();
//extraFun1();
//extraFun2();
extraFun3();



function fun1() {

    /*
        Gör en metod "sayHi". Anropa den två gånger
    
        sayHi()
        sayHi()

    Detta ska skrivas ut:

    --------
    -------- VÄLKOMMEN 
    --------

    --------
    -------- VÄLKOMMEN 
    --------

    */
    SayHi();
    SayHi();


}

function SayHi() {

    console.log(" --------\n--------VÄLKOMMEN\n --------")
}

function fun2() {

    /*
    Liknande som sist men gör en metod sayHiTo() som tar ett namn som inparameter.

    Ex sayHiTo("Oscar") ska skriva ut:

    --------
    -------- VÄLKOMMEN OSCAR
    --------

    */

    SayHiTo("Alex");

}

function SayHiTo(input)
{
    console.log(" --------\n--------VÄLKOMMEN " + input + " \n --------")
}

function fun3() {

    /*
    Gör en metod "myndig" med två parameterar "name" och "age". Anropa den tre gånger
    
        myndig("Peter", 16);
        myndig("Lisa", 26);
        myndig("Ragnar", 15);

    Detta ska skrivas ut:

        Obs! Peter är inte myndig!
        Lisa är myndig
        Obs! Ragnar är inte myndig!
    */
    myndig("Peter", 16);
    myndig("Lisa", 26);
    myndig("Ragnar", 18);


}

function myndig(name, age) {

    if (age < 18) {
        console.log("OBS! " + name + " är inte myndig!")
    }
    else if(age > 17) {
        
        console.log(name + " är myndig.")

    }
}


function fun4() {

    /*
    Gör en metoden "skrivUtMoms" som tar "price" som inparameter.
    Om du t.ex anropas metoden såhär:

        skrivUtMoms(1000)

    ...så ska detta skrivas ut:

        Momsen för varan är 250kr

    */
    let price = 1000;

    skrivUtMoms(1000);
}

function skrivUtMoms(moms)
{
    let momsout = moms * 0.25;
    console.log("Momsen för varan är: " + momsout)
}

// -------- EXTRA UPPGIFTER -----------------------------------------

function extraFun1() {

    /*
    Gör en metod "inkopslista" med en parameter "stuff". Anropa den:
    
        inkopslista(["Skruv", "Hammare", "Vattenpass"]);
        inkopslista(["Penna", "Luktsuddigum"]);

    Detta ska skrivas ut:

        ATT KÖPA:
        * SKRUV
        * HAMMARE
        * VATTENPASS

        ATT KÖPA:
        * PENNA
        * LUKTSUDDIGUM
    */

    inkopslista(["Skruv", "Hammare", "Vattenpass"]);
    inkopslista(["Penna", "Luktsuddigum"]);
}

function inkopslista(inkopslista, inkopslista2) {

    let counter = 0;
    console.log(`Att köpa:`.toUpperCase());
    for (let item of inkopslista) {
        console.log(`*  ${inkopslista[counter]}`)
        counter++;
    }
    
    

}

function extraFun2() {

    /*

    Gör en metod "recept" med en parameter "recipeName" och "ingredients". Anropa den:
    
        recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
        recept("Rotmos", ["Potatis", "Kålrot"]);

    Detta ska skrivas ut:

        FÖR ATT GÖRA ÄPPLEKAKA BEHÖVS:
        * ÄPPLE
        * MJÖL
        * KANEL

        FÖR ATT GÖRA ROTMOS BEHÖVS:
        * POTATIS
        * KÅLROT
    */
    recept("Äpplekaka", ["Äpple", "Mjöl", "Kanel"]);
    recept("Rotmos", ["Potatis", "Kålrot"]);
}


function recept(bakelse, inkopslista2) {

    let counter = 0;
    console.log(`För att göra ${bakelse} behövs:`.toUpperCase());

    for (let item of inkopslista2) {
        console.log(`*  ${inkopslista2[counter]}`)
        counter++;
    }



}

function extraFun3() {

    /*

    I sverige finns tre momssatser: 25%, 12% och 6%. Se här:
    https://www.verksamt.se/starta/skatter-och-avgifter/moms/olika-momssatser

    Skriv en metod "skrivUtMoms" som beräknar moms på en vara utifrån vilken typ av vara det är

    Dessa anrop:

        skrivUtMoms("tidning", 1000);
        skrivUtMoms("restaurangbesök", 1000);
        skrivUtMoms("flyg", 1000);
        skrivUtMoms("falafel", 1000);
        skrivUtMoms("hipsteröl", 1000);

    Ska ge svaren:

        Momsen för en/ett tidning som kostar 1000kr är 60kr
        Momsen för en/ett restaurangbesök som kostar 1000kr är 120kr
        Momsen för en/ett flyg som kostar 1000kr är 60kr
        Momsen för en/ett falafel som kostar 1000kr är 250kr
        Momsen för en/ett hipsteröl som kostar 1000kr är 250kr

    */

    skrivUtMoms("tidning", 1000);
    skrivUtMoms("restaurangbesök", 1000);
    skrivUtMoms("flyg", 1000);
    skrivUtMoms("falafel", 1000);
    skrivUtMoms("hipsteröl", 1000);

}

function skrivUtMoms(name, price) {

    let lågmoms = 0.06;
    let medelmoms = 0.12;
    let högmoms = 0.25;
    let tot = price;

    switch (name) {

        case "tidning":
            tot = price * lågmoms;
            
        case "restaurangbesök":
            tot = price * medelmoms;

        case "flyg":
            tot = price * 0.06;

        case "falafel":
            tot = price * medelmoms;

        case "hipsteröl":
            tot = price * högmoms;

        default:
    }

    console.log(`Momsen för en/ett ${name} som kostar ${price} är ${tot} `)


}

function extraFun4() {

    /*

    Modifiera "skrivUtMoms" så det går att ange "en" eller "ett".

    Dessa anrop:

        skrivUtMoms("en", "tidning", 1000);
        skrivUtMoms("ett", "restaurangbesök", 1000);
        skrivUtMoms("ett", "flyg", 1000);
        skrivUtMoms("en", "falafel", 1000);
        skrivUtMoms("en", "hipsteröl", 1000);

    Ska ge svaret:

        Momsen för en tidning som kostar 1000kr är 60kr
        Momsen för ett restaurangbesök som kostar 1000kr är 120kr
        Momsen för ett flyg som kostar 1000kr är 60kr
        Momsen för en falafel som kostar 1000kr är 250kr
        Momsen för en hipsteröl som kostar 1000kr är 250kr

    */

}
