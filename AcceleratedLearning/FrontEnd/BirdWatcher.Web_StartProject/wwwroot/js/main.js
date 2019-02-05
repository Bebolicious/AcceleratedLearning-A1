
async function recreateDatabase() {
    document.getElementById("recreateButton").style.display = "none";
    document.body.style.backgroundColor = "blue";
    let response = await fetch("/observation/recreate", {
        method: "POST"
    });

    if (response.status === 200) {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "green";
        
    } else {
        document.getElementById("recreateButton").style.display = "block";
        document.body.style.backgroundColor = "red";

    }

}

async function AddBird() {

    let species = document.getElementById('addbird').value;
    let birdname;

    switch (species) {
        case "1":
            birdname = "Kungsfiskare"
            break;
        case "2":
            birdname = "Tornfalk"
            break;
        case "3":
            birdname = "Skäggdopping"
            break;
    }


    let response = await fetch("observation", {
        method: "POST",
        body: JSON.stringify(
            {
                Species: `${birdname}`,
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });


    console.log('Post added')

}

async function ShowAll() {

    let response = await fetch(`observation`, { method: "get" });
    let result = await response.json();
    console.log(result)

     let html = "";

        for (let b of result) {
            html += `<p>${b.species}</p>`;
        }
        document.getElementById("birdList").innerHTML = html;
}