//cond1();
//cond2();
//cond3();
//cond4();
//cond5();
//cond6();
//cond7();
//cond8();
cond9();

function cond1() {

    /*
	    Skapa en variabel shoeMaria och sätt till 36
	    Skapa en variabel shoeAli och sätt till 42
	    Skriv en if-sats som kollar om de har samma skostorlek (skriv ut olika texter)
	    Experimentera med att ändra värden på "shoeMaria" och "shoeAli"
    */
    let shoeMaria = 36;
    let shoeAli = 36;

    if (shoeAli == shoeMaria) {

        console.log("Maria and Ali have the same shoe size.")
    }
    else if (shoeMaria < shoeAli) {
        console.log("Ali's feet are bigger than Maria's.")
    }
    else if (shoeMaria > shoeAli) {
        console.log("Marias feet are bigger than Ali's.")
    }

}

function cond2() {


    // ^ Lösning i cond1();

    /*
	    Kolla om Ali har större skostolek än Maria
	    Skriv ut lämpligt meddelande
    */
}

function cond3() {

    // ^ Lösning i cond1();
    /*
	    Samma som sist, men kolla även om de har samma skostorlek
    */
       


}

function cond4() {

    /*
	    Lägg till en till variabel "bigFoot" med skostorlek 52
	    Skriv en if-sats som kolla om bigFoot har större skostorlek än både Ali och Maria
    */
    let bigFoot = 52;
    let shoeMaria = 36;
    let shoeAli = 36;

    if (bigFoot > shoeAli && shoeAli) {

        console.log("Bigfoot has the biggest feet");
    }

    else {
        console.log("Math is hard.");
    }


}

function cond5() {

    /*
	    Skriv en ifsats som kollar om någon av de tre har en skostorlek som är större än 50
    */
    let bigFoot = 52;
    let shoeMaria = 36;
    let shoeAli = 50;
    

    if (bigFoot > 50 || shoeAli > 50 || shoeMaria > 50) {

        console.log("One or more people have a shoe size bigger than 50");
    }


}

function cond6() {

    /*
	    Skapa en variabel "favoriteVegetable" och sätt den till "kålrot"
	    Använd en switch-sats för att kolla värdet på "favoriteVegetable" och svara på olika sätt
	    Om t.ex värdet av "favoriteVegetable" är "majrova" skriv "Passar till falafel"
    */

    let favoriteVegetable = "gurka";

    switch (favoriteVegetable) {
        case "kålrot":
            console.log("Vad använder man en " + favoriteVegetable + " till egentligen");
            break;
        case "majs":
            console.log(favoriteVegetable + " Funkar väldigt bra till tacos!")

            break;
        default:
            console.log("Det finns inga recept för " + favoriteVegetable);
        
    }

}

function cond7() {

    /*
	    Samma som sist men skapa först en variabel "answer"
	    Istället för att använda "console.log" inuti switch-satsen så sätt variabel "answer"
	    Använd tillslut "console.log" för att skriva ut värdet av "answer"
    */

    let favoriteVegetable = "gurka";
    let answer;
    switch (favoriteVegetable) {
        case "kålrot":
            answer = "Vad använder man en " + favoriteVegetable + " till egentligen";
            break;
        case "majs":
            answer = favoriteVegetable + " Funkar väldigt bra till tacos!";

            break;
        default:
            answer = "Det finns inga recept för " + favoriteVegetable;

    }
    console.log(answer)
}

function cond8() {


    /*
	    Jämför == och === i en ifsats
	    Testa med en ifsats om 3=="3" är sant
	    Testa med en ifsats om 3==="3" är sant
    */

    let torf;

    //if (3 == "3") {

    //    torf = true;
    //}
    if (3 === "3") {
        torf = false;
    }
   
    console.log(torf)
}

function cond9() {

    /*
	    Övning i "ternary operator"
	    Skapa en variabel a och sätt den till 13*13
	    Skapa en variabel b och sätt den till 169
	    Använd "ternary operator" för att kolla om de är lika. Lägg svaret (strängen "lika" eller "olika") i en variabel "result"
	    Skriv ut result
    */
    let a = 13 * 13;
    let b = 162;
    let result;

    if (a === b) {
        result = "Talen är lika";
    }
    else {
        result = "Talen är olika";
    }

    console.log(result)

}