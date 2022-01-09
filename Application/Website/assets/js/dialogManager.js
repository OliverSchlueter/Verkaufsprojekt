function showDialog(id, name, price, description, releaseDate, autors){
    var dialogContainer = document.getElementById("dialogView");
    
    autorsList = autors.split(",");

    // remove all elements with class autor
    var paras = document.getElementsByClassName('autor');
    for (let i = 0; i < paras.length; i++) {
        const element = paras[i];
        element.parentNode.removeChild(paras[i]);
        
    }

    // add new autor elements
    var autorsDiv = document.getElementById("autors");
    autorsList.forEach(a => {
        var tag = document.createElement("p");
        var text = document.createTextNode(a);
        tag.appendChild(text);
        tag.classList.add("autor")
        autorsDiv.appendChild(tag);
    });

    document.getElementById("pID").setAttribute("value", id)
    document.getElementById("name").innerHTML = name;
    document.getElementById("id").innerHTML = id;
    document.getElementById("releaseDate").innerHTML = releaseDate;
    document.getElementById("price").innerHTML = price + " €";
    document.getElementById("description").innerHTML = description;

    dialogContainer.style.visibility = "visible";
}

function hideDialog(){
    var dialogContainer = document.getElementById("dialogView");
    dialogContainer.style.visibility = "hidden";
}