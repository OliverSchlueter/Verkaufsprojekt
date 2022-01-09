const searchProductInput = document.getElementById('searchProduct');
document.addEventListener('keyup', updateItems);

var allProducts = [];
window.onload = () => {
    for (let i = 0; i < document.getElementsByClassName("product").length; i++) {
        const element = document.getElementsByClassName("product")[i];
        allProducts.push(element);
    }
    console.log(allProducts);
}

function updateItems(){
    window.setTimeout(1000);
    var input = document.getElementById("searchProduct");
    var text = input.value;
    console.log("New Input:"+text);

    for (let i = 0; i < allProducts.length; i++) {
        const element = allProducts[i];
        
        var id = element.id.replace("product_", "");

        if(!id.startsWith(text) && !id.includes(text)){
            var products = document.querySelector(".products");
            if(childOf(element, products)){
                products.removeChild(element);
            }
        } else {
            var products = document.querySelector(".products");
            if(!childOf(element, products)){
                document.querySelector(".products").appendChild(element);
            }
        }
    }
}


function childOf(child, parent){ //returns boolean
    while((child=child.parentNode)&&child!==parent); 
    return !!child; 
  }