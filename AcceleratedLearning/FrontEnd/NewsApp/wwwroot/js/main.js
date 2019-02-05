console.log("Moi Mukulat!");

async function clickSeed() {

    await fetch(`api/news/seed`, { method: "post" });

    console.log("Seed done!");
}

async function clickStatArea() {



    let response = await fetch(`api/news/count`, { method: "get" });
    let result = await response.json();
    document.getElementById("statArea").innerText = "There are " + result + " posts.";
}

async function ShowAll() {


    var x = document.getElementById("newsList");
    if (x.style.display === "none") {
        x.style.display = "block";
    }

    else {
        x.style.display = "none";
    }

    let response = await fetch("api/News", {
        method: "GET"
    });



    let allNews = await response.json();
    console.log("allNews", allNews);

    let html = "";

    for (let n of allNews) {
        html += `<p>Id: ${n.id} Rubrik: ${n.header}</p>`;
    }
    document.getElementById("newsList").innerHTML = html;



    let response = await fetch(`api/news/`, { method: "get" });
    let result = await response.json();
    console.log(result)

    let mynode = document.getelementbyid("newslist")

    for (var i = 0; i < result.length; i++) {

        let obj = result[i]
        let para = document.createElement('p');
        let t = document.createtextnode("id: " + obj.id + "  header: " + obj.header)
        para.appendchild(t)
        document.getelementbyid("newslist").appendchild(para)
    }
}

async function clickRecreate() {

    let response = await fetch(`api/news/recreate`, { method: "post" });

    if (response.status === 204) {
        console.log("Database reinitialized")
    }
    else {
        console.log("Failed to reinitialized")
    }


}

async function clickShowAddNews() {

    var x = document.getElementById("addArea");
    if (x.style.display === "none") {
        x.style.display = "block";
    }

    else {
        x.style.display = "none";
    }
}


async function ShowAllInTable() {

    var x = document.getElementById("newsList");
    if (x.style.display === "none") {
        x.style.display = "block";
    }

    else {
        x.style.display = "none";
    }

    let response = await fetch("api/News", {
        method: "GET"
    });

    if (response.status === 200) {

        let allNews = await response.json();
        console.log("allNews", allNews);

        let html = "";

        var table = document.createElement('table');
        table.setAttribute('border', '1');
        table.setAttribute('width', '100%')
        var row = table.insertRow(0);

        for (let n of allNews) {


            for (j = 1; j <= 2; j++) {
                var text = document.createTextNode(String.fromCharCode(j + 64));
                var cell = row.insertCell(j - 1);
                cell.setAttribute('align', 'center')
                cell.appendChild(text);
            }
            document.getElementById("showAllTable").appendChild(table);
        }
    }
}


async function removePost(id) {





}


async function clickAddNews() {




    let header = document.getElementById("addAreaHeader").value;
    let cat = document.getElementById("addAreaCategory").value;
    let intro = document.getElementById("addAreaIntro").value;
    let body = document.getElementById("addAreaBody").value;
    let catid = 0;

    //switch (cat) {
    //    case 'Nature':
    //        catid = 1;
    //        break;
    //    case 'Australia':
    //        catid = 2;
    //        break;


    //}


    let response = await fetch("api/news", {
        method: "POST",
        body: JSON.stringify(
            {
                header: `${header}`,
                intro: `${intro}`,
                body: `${body}`,
                category: {
                    id: catid
                }
            }),
        headers: {
            "Content-Type": "application/json"
        }
    });


    console.log('Post added')
}

