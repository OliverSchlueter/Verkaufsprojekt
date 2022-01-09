function deleteProduct(id){
    fetch("/profile/index.php", {
        method: "POST",
        headers: {
            "Content-Type": "application/x-www-form-urlencoded; charset=UTF-8",
          },
          body: `delProduct=true&id=` + id
    })
    .then(response => response.json())
    .then(data => console.log(data));
}