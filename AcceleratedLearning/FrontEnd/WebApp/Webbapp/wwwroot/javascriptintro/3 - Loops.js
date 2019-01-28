
//loop1();
//loop2();
//loop3();
//loop4();
//loop5();
//loop6();
loop7();


function loop1() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 5 och 18
    */
    for (var i = 5; i <= 18; i++) {

        console.log(i);

    }

}

function loop2() {

    /*
        Använd en for-loop för att skriva ut alla siffror mellan 0 och 9
    */

    for (var i = 0; i < 10; i++) {

        console.log(i);
    }

}

function loop3() {

    /*
        Använd en forloop för att skriva ut:
            "Siffran 4 är tjusig". 
            "Siffran 5 är tjusig"
            "Siffran 6 är tjusig"
            "Siffran 7 är tjusig"
            "Siffran 8 är tjusig"
    */

    for (var i = 4; i < 9; i++) {
        console.log("Siffran " + i + " är tjusig.")
    }

}

function loop4() {

    /*
        Lös föregående uppgift men använd en while-loop
    */
    let i = 4;
    let max = 9;
    while (true)

    {
        console.log(i);
        i++;
        if (i == max) {
            break;
        }
    }

}

function loop5() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
        Använd "for of" för att skriva ut alla årtal
    */
    var importantYears = [1492, 1789, 1859, 1929];
    for (let years of importantYears) {
        years += 1;
        console.log(years)
    }

}

function loop6() {

    /*
	    Skapa en array "importantYears" med årtalen 1492, 1789, 1859, 1929
	    Använd "for of" för att skriva ut alla årtal med en siffra till vänster:
	    1) 1492
	    2) 1789
	    3) 1859
	    4) 1929
    */
    let counter = 1;
    var importantYears = [1492, 1789, 1859, 1929];
    for (let years of importantYears) {
        years += 1;

        console.log(counter + ") " + years)
        counter++;
    }


}

function loop7() {

    /*
	    Samma som sist men avbryt loopen om årtalet är högre än 1800. Ska alltså ge:
	    1) 1492
	    2) 1789
    */
    let counter = 1;
    var importantYears = [1492, 1789, 1859, 1929];
    for (let years of importantYears) {
        years += 1;
        if (years > 1800) {

            break;
        }
        
        console.log(counter + ") " + years)
        counter++;
    }

}
