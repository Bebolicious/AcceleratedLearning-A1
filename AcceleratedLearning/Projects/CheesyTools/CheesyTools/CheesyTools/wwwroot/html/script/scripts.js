let txt = "";
let xxx = document.getElementById("ButtonA");
if (xxx) 
    document.getElementById("ButtonA").addEventListener("click", colorGenerator);

document.getElementById("nrbt").addEventListener("click", genNum);

function colorGenerator() {
    var randomcolor = "";
    var hexkod = "0123456789ABCDEF";
    for (var i = 0; i < 6; i++) {
        randomcolor += hexkod[Math.floor(Math.random() * 16)];
    }

    document.body.style.backgroundColor = "#" + randomcolor;
    txt = "Your #code:  " + randomcolor;

    document.getElementById("colorToUser").innerHTML = txt;
}


/*    Randum number gen-AZ */
function genNum() {

    let min = parseInt(document.getElementById('min').value);
    let max = parseInt(document.getElementById('max').value);
    

    let result = generateRandomNumber(min, max);
    let text = `<br/><h1>${result}</h1>`;

    document.getElementById("result").innerHTML = text;
}


function generateRandomNumber(max, min) {
    let parachute = "Please fill in a minimum and maximum value";

    if (max === NaN || min === NaN) {
        return parachute;
    }

    return Math.floor(Math.random() * (min - max+1))+ max;
} 

